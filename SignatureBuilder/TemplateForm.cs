using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SignatureBuilder
{
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
            StyleInit();
        }

        private static TemplateForm _instance;

        public static TemplateForm InstanceObject() 
        {
            if (_instance == null)
                _instance = new TemplateForm();
            return _instance;
        }

        void StyleInit()
        {
            LeftBoardPanel.Height = this.Height;
            LeftBoardPanel.Width = 1;
            LeftBoardPanel.Top = 0;
            LeftBoardPanel.Left = 0;
            LeftBoardPanel.BackColor = Color.SteelBlue;

            RightBoardPanel.Height = this.Height;
            RightBoardPanel.Width = 1;
            RightBoardPanel.Top = 0;
            RightBoardPanel.Left = this.Width - 1;
            RightBoardPanel.BackColor = Color.SteelBlue;

            TopBoardPanel.Height = 1;
            TopBoardPanel.Width = this.Width;
            TopBoardPanel.Top = 0;
            TopBoardPanel.Left = 0;
            TopBoardPanel.BackColor = Color.SteelBlue;

            BottomBoardPanel.Height = 1;
            BottomBoardPanel.Width = this.Width;
            BottomBoardPanel.Left = 0;
            BottomBoardPanel.Top = this.Height - 1;
            BottomBoardPanel.BackColor = Color.SteelBlue;

            CloseButton.Location = new System.Drawing.Point(this.Width - 38, 10);
        }

        void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            Panel CloseButton = sender as Panel;
            CloseButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.close24_black;
        }

        void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            Panel CloseButton = sender as Panel;
            CloseButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.close24_orange;
        }

       

        Point mouseOff;
        bool leftFlag;

        void ParentMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }

        void ParentMouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                Location = mouseSet;
                this.Opacity = 0.5;
            }
        }

        void ParentMouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
                this.Opacity = 1;
            }
        }

        void TemplateForm_SizeChanged(object sender, EventArgs e)
        {
            StyleInit();
        }

        void TemplateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }
    }
}
