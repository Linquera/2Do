using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDoCustomForm
{
    public partial class CustomForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,int wMsg,IntPtr wParam, IntPtr lParam);
        private const int NCLBUTTONDOWN = 0x00A1;
        private const int WM_SYSCOMMAND = 0x112;
        private const int HTCAPTION = 2;
        private const int SC_SIZE = 0xF000;

        //properties
        public Color BackGroundColor { get; set; }
        private bool isMouseButtonDown = false;
        private bool isMaximized = false;

        //Controls
        private CustomMenuBar MainMenu = new CustomMenuBar();
        private CustomStatusBar StatusBar = new CustomStatusBar();
        private CustomBorder Border = new CustomBorder();
        private Rectangle DefaultFormSize = new Rectangle();
        private Rectangle StatusBarGrip = new Rectangle();
        private Rectangle ControlButtonsContainer = new Rectangle();
        private Rectangle MenuContainer = new Rectangle();
        private GraphicsPath MenuButtonsBox = new GraphicsPath();

        public CustomForm()
        {
            SetDefaultValues();
            //initial form style
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.SupportsTransparentBackColor,
                          true);

            this.FormBorderStyle = FormBorderStyle.None;
            this.MinimumSize = new Size(400, 400);
            this.Padding = new Padding(8);

            //Initializing de MenuBar
            MainMenu.MenuButtons.Add(new CustomMenuBarButton(CustomMenuBarButton.MenuBarButtonType.Close));
            MainMenu.MenuButtons.Add(new CustomMenuBarButton(CustomMenuBarButton.MenuBarButtonType.Maximize, Color.FromArgb(124, 13, 2), Color.FromArgb(251, 164, 48)));
            MainMenu.MenuButtons.Add(new CustomMenuBarButton(CustomMenuBarButton.MenuBarButtonType.Minimize, Color.FromArgb(3, 63, 126),Color.FromArgb(119,217, 246)));

        }

        private void SetDefaultValues()
        {
            //blacksh like visual studio dark color
            BackColor = Color.FromArgb(34, 34, 34);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "TwoForm";
            this.ResumeLayout(false);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            using (SolidBrush sb = new SolidBrush(BackGroundColor))
            {
                e.Graphics.FillRectangle(
                    sb,
                    this.ClientRectangle
                );
            }
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseButtonDown = true;
           
            // Menubar buttons actions                      
            foreach (CustomMenuBarButton btn in MainMenu.MenuButtons)
            {
                if (MenuButtonsBox.IsVisible(e.Location))
                {
                    if (PointInRect(e.Location, new Rectangle(btn.LeftOffset, btn.TopOffset, btn.Width, btn.Height)))
                    {
                        if (btn.ButtonType == CustomMenuBarButton.MenuBarButtonType.Minimize)
                            this.WindowState = FormWindowState.Minimized;
                        else if (btn.ButtonType == CustomMenuBarButton.MenuBarButtonType.Maximize)
                        {
                            if (isMaximized)
                            {
                                isMaximized = false;
                                this.Size = new Size(DefaultFormSize.Width, DefaultFormSize.Height);
                                this.Location = new Point(DefaultFormSize.Left, DefaultFormSize.Top);
                            }
                            else
                            {
                                DefaultFormSize = new Rectangle(this.Location, this.Size);
                                Rectangle wa = Screen.GetWorkingArea(this);
                                this.Size = new Size(wa.Width, wa.Height);
                                this.Location = new Point(wa.Left, wa.Top);
                                isMaximized = true;
                            }
                        }
                        else if (btn.ButtonType == CustomMenuBarButton.MenuBarButtonType.Close)
                        {
                            Application.Exit();
                        }
                    }
                }
            }
        }

        private bool PointInRect(Point p, Rectangle rc)
        {
            if ((p.X > rc.Left && p.X < rc.Right &&
                p.Y > rc.Top && p.Y < rc.Bottom))
                return true;
            else
                return false;
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseButtonDown = false;
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            this.Invalidate();
            base.OnResizeBegin(e);
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {         
            HoverMenuBarButtons(e.Location);
            
            // Form moving
            DragMenuBar(e);
            ResizeWindow(e);
            
            base.OnMouseMove(e);
        }

        private void DragMenuBar(MouseEventArgs e)
        {
            if (isMouseButtonDown)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (PointInRect(e.Location, MenuContainer))
                    {
                        ReleaseCapture();
                        SendMessage(this.Handle, NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
                    }
                }
            }
        }

        private void ResizeWindow(MouseEventArgs e)
        {
            bool bResizing = true;
            if (PointInRect(e.Location, StatusBarGrip))
            {
                Cursor = Cursors.SizeNWSE;
                if (isMouseButtonDown && bResizing)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        if (this.Width < this.MinimumSize.Width)
                            bResizing = false;
                        if (this.Height < this.MinimumSize.Height)
                            bResizing = false;

                        ReleaseCapture();
                        SendMessage(this.Handle, WM_SYSCOMMAND, (IntPtr)(SC_SIZE + 8), IntPtr.Zero);
                    }
                }
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }

        private void HoverMenuBarButtons(Point pos)
        {
            bool bChanged = false;
            if (MenuButtonsBox.IsVisible(pos))
            {
                foreach (CustomMenuBarButton btn in MainMenu.MenuButtons)
                {
                    if (PointInRect(pos, new Rectangle(btn.LeftOffset, btn.TopOffset, btn.Width, btn.Height)))
                    {
                        if (!btn.Hovering)
                        {
                            btn.Hovering = true;
                            bChanged = true;
                        }
                    }
                    else
                    {
                        if (btn.Hovering)
                        {
                            btn.Hovering = false;
                            bChanged = true;
                        }
                    }
                }
            }
            else
            {
                foreach (CustomMenuBarButton btn in MainMenu.MenuButtons)
                {
                    if (btn.Hovering)
                    {
                        btn.Hovering = false;
                        bChanged = true;
                    }
                }
            }
                        
            if (bChanged)
            {
                Invalidate(ControlButtonsContainer);
            }
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Rectangle rcBorder = new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);

            // rendering
            DrawStatusBar(e.Graphics);            
            Border.Render(rcBorder, e.Graphics);
            DrawButtonsBox(e.Graphics);
            DrawMenuBar(e.Graphics);

            // build Menu buttons box:
            MenuButtonsBox = MainMenu.BuildMenuButtonsBox(ControlButtonsContainer);
        }

        private void DrawMenuBar(Graphics graphics)
        {            
            int titleBarWidth = ControlButtonsContainer.Left - 3;
            int topOffset = 1;
            int rectOffset = 1;           

            MenuContainer = new Rectangle(rectOffset, topOffset, titleBarWidth, 25);
            //reder de menu itens
            MainMenu.RenderMenuBar(graphics, MenuContainer);            
        }

        private void DrawStatusBar(Graphics graphics)
        {
            int leftBorderExcess = 2;//this value make the status bar go upa and down on the screen 
            Rectangle aux = new Rectangle(1, ClientRectangle.Bottom - leftBorderExcess - StatusBar.BarHeight, ClientRectangle.Right - ClientRectangle.Left, StatusBar.BarHeight);
            StatusBar.RenderStatusBar(graphics, aux.Left, aux.Top, aux.Width, aux.Height);
            StatusBarGrip = StatusBar.Grip;
        }

        private void DrawButtonsBox(Graphics graphics)
        {
            //variables to control positon of the control buttons on the menu
            int top = 0;
            int btnWidth = 0;
            int btnHeight = 0;
            int border = 2;
            int width = 0;
            int height = 0;
            int x = this.ClientRectangle.Right - border - 14;
            int y = 9;

            foreach (CustomMenuBarButton btn in MainMenu.MenuButtons)
            {
                btnWidth = btn.Width;
                btnHeight = btn.Height;
            }

            width = btnWidth * 3;
            height = btnHeight;

            ControlButtonsContainer = new Rectangle(ClientRectangle.Right - border - width, top, width, height);
            MainMenu.RenderMenuBarButtonsBox(ControlButtonsContainer, graphics, x, y);
        }
    }
}
