using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDoCustomForm
{
    public partial class CustomMainForm : CustomForm
    {      
        //Containers        
        private Rectangle StatusBarGrip = new Rectangle();              
        private Rectangle SideBarContainer = new Rectangle();
        private Rectangle ToolBoxContainer = new Rectangle();     
        
        //properties
        public bool useCustomStatusBar { get; set; }
        public bool useCustomToolBox { get; set; }
        public bool useCustomSideBar { get; set; }
        public bool useCustomMenuBar { get; set; }

        //Custom Controls        
        public CustomStatusBar StatusBar = new CustomStatusBar();        
        public CustomButtonBar SideBar = new CustomButtonBar();
        public CustomButtonBar ToolBox = new CustomButtonBar();
        public CustomMenuStrip CustomMenu;

        public CustomMenuStrip MainMenu { get { return CustomMenu; } }

        public CustomMainForm()
        {
            SetDefaultValues();                      
            CustomMenu = new CustomMenuStrip();
            this.IsMdiContainer = true;
            this.Controls.Add(CustomMenu);
            
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {                    
                    ctrl.BackColor = Color.FromArgb(65, 65, 65);                    
                }
            }
            SetBevel(false); 
        }

        protected void SetDefaultValues()
        {
            //use all custom by default
            useCustomSideBar = true;
            useCustomStatusBar = true;
            useCustomToolBox = true;
            this.MinimumSize = new Size(1280, 800);            
        }

        public void ShowButtons()
        {
            foreach (var button in ToolBox.Buttons)
            {
                this.Controls.Add(button);
            }

            foreach (var button in SideBar.Buttons)
            {
                this.Controls.Add(button);
            }
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseMove(e);
            ResizeWindow(e);
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

                        ReleaseResize();
                    }
                }
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }    

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            // rendering
            DrawStatusBar(e.Graphics);            
            base.OnPaint(e);
            DrawToolBox(e.Graphics);
            DrawSideBar(e.Graphics);            
            setPadding();
        }

        private void setPadding()
        {
            int left = 0, top = 0, rigth = 0, bottom = 0;
            left = SideBarContainer.Width + 2;
            top = ToolBoxContainer.Height + MenuContainer.Height + 3;
            bottom = StatusBar.BarHeight + 2;
            rigth = 2;

            MainMenu.setLocation(MenuContainer);
            this.Padding = new Padding(left, top, rigth, bottom);            
        }

        private void DrawToolBox(Graphics graphics)
        {
            if (useCustomToolBox)
            {
                int sideBarWidth = this.ClientRectangle.Width - 2;
                int topOffset = MenuContainer.Height + 2;
                int rectOffset = 1;
                int sideBarHight = 45;

                ToolBoxContainer = new Rectangle(rectOffset, topOffset, sideBarWidth, sideBarHight);
                //reder de menu itens
                ToolBox.ButtonFillWholeBar = true;
                ToolBox.RenderButtonBar(graphics, ToolBoxContainer);
            }
        }

        private void DrawSideBar(Graphics graphics)
        {
            if (useCustomSideBar)
            {
                int sideBarWidth = 150;
                int topOffset = MenuContainer.Height + ToolBoxContainer.Height + 2;
                int rectOffset = 1;
                int sideBarHight = this.ClientRectangle.Height - //application size
                                        StatusBar.BarHeight -    //status bar size
                                        ToolBoxContainer.Height - //toolbox size
                                        MenuContainer.Height -   //menubar size
                                        4;                       //some space for the borers dont overlay
                SideBarContainer = new Rectangle(rectOffset, topOffset, sideBarWidth, sideBarHight);
                //reder de menu itens
                SideBar.ButtonFillWholeBar = true;
                SideBar.RenderButtonBar(graphics, SideBarContainer);
            }
        }        

        private void DrawStatusBar(Graphics graphics)
        {
            if (useCustomStatusBar)
            {
                int leftBorderExcess = 2;//this value make the status bar go upa and down on the screen 
                Rectangle aux = new Rectangle(1, ClientRectangle.Bottom - leftBorderExcess - StatusBar.BarHeight, ClientRectangle.Right - ClientRectangle.Left, StatusBar.BarHeight);
                StatusBar.RenderStatusBar(graphics, aux.Left, aux.Top, aux.Width, aux.Height);
                StatusBarGrip = StatusBar.Grip;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Name = "CustomMainForm";
            this.ResumeLayout(false);
        }     
    }
}
