using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TwoDoCustomForm
{
    public partial class CustomForm : Form
    {
        #region Imports
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOREDRAW = 0x0008;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_SHOWWINDOW = 0x0040;
        private const uint SWP_HIDEWINDOW = 0x0080;
        private const uint SWP_NOCOPYBITS = 0x0100;
        private const uint SWP_NOOWNERZORDER = 0x0200;
        private const uint SWP_NOSENDCHANGING = 0x0400;

        public bool SetBevel(bool show)
        {
            foreach (Control c in this.Controls)
            {
                MdiClient client = c as MdiClient;
                if (client != null)
                {
                    int windowLong = GetWindowLong(c.Handle, GWL_EXSTYLE);

                    if (show)
                    {
                        windowLong |= WS_EX_CLIENTEDGE;
                    }
                    else
                    {
                        windowLong &= ~WS_EX_CLIENTEDGE;
                    }

                    SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong);

                    // Update the non-client area.
                    SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0,
                        SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                        SWP_NOOWNERZORDER | SWP_FRAMECHANGED);
                    return true;
                }
            }
            return false;
        }

        #endregion
        
        //properties
        public Color BackGroundColor { get; set; }

        //Containers        
        protected Rectangle DefaultFormSize = new Rectangle();
        protected Rectangle ControlButtonsContainer = new Rectangle();
        protected GraphicsPath MenuButtonsBox = new GraphicsPath();

        public CustomMenuBar MainMenuBar = new CustomMenuBar();
        private bool onlyCloseButton { get; set; }

        //internal use
        protected bool isMouseButtonDown = false;
        protected bool isMaximized = false;
        
        public CustomForm()
        {
            onlyCloseButton = false;
            SetDefaultValues();                             
        }

        public CustomForm(bool onlyCloseButton)
        {
            this.onlyCloseButton = onlyCloseButton;
            SetDefaultValues();
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

        private void SetDefaultValues()
        {
            //initial form style
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.SupportsTransparentBackColor,
                          true);  
            //blacksh like visual studio dark color
            BackColor = Color.FromArgb(34, 34, 34);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MinimumSize = new Size(500, 500);                      
            
            //add buttons in the controlbar
            if (!onlyCloseButton)
            {
                MainMenuBar.MenuButtons.Add(new CustomMenuBarButton(CustomMenuBarButton.MenuBarButtonType.Maximize, Color.FromArgb(124, 13, 2), Color.FromArgb(251, 164, 48)));
                MainMenuBar.MenuButtons.Add(new CustomMenuBarButton(CustomMenuBarButton.MenuBarButtonType.Minimize, Color.FromArgb(3, 63, 126), Color.FromArgb(119, 217, 246)));
            }  
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            this.Invalidate();
            base.OnResizeBegin(e);
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            DrawButtonsBox(e.Graphics);
            // build Menu buttons box:
            MenuButtonsBox = MainMenuBar.BuildMenuButtonsBox(ControlButtonsContainer);
        }

        protected void DrawButtonsBox(Graphics graphics)
        {
            //variables to control positon of the control buttons on the menu
            int top = 0;
            int border = 2;
            int width = 0;
            int height = 0;
            int x = this.ClientRectangle.Right - border - 14;
            int y = 9;            

            width = onlyCloseButton ? MainMenuBar.MenuButtons[0].Width : MainMenuBar.MenuButtons[0].Width * MainMenuBar.MenuButtons.Count;
            height = MainMenuBar.MenuButtons[0].Height;

            ControlButtonsContainer = new Rectangle(ClientRectangle.Right - border - width, top, width, height);
            MainMenuBar.RenderMenuBarButtonsBox(ControlButtonsContainer, graphics, x, y);
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isMouseButtonDown = true;

            // Menubar buttons actions                      
            foreach (CustomMenuBarButton btn in MainMenuBar.MenuButtons)
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
                            onExitclick();
                        }
                    }
                }
            }
        }

        public virtual void onExitclick()
        {
            Application.Exit();
        }

        protected bool PointInRect(Point p, Rectangle rc)
        {
            if ((p.X > rc.Left && p.X < rc.Right &&
                p.Y > rc.Top && p.Y < rc.Bottom))
                return true;
            else
                return false;
        }
    }
}
