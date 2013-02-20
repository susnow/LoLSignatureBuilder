using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SignatureBuilder
{
    public partial class MaxSizeSnapshot : TemplateForm
    {
        private static MaxSizeSnapshot _instance;
        public MaxSizeSnapshot()
        {
            InitializeComponent();
            this.title.Text = "缩放模式";
            //this.titleboard.Visible = false;
            this.ActiveControl = this.ShotPanel;
            this.cutBox.Parent = this.ShotPanel;
            this.ShotPanel.MouseWheel += ShotPanel_MouseWheel;
        }

        void ShotPanel_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta == 120)
            {
                if (this.ShotPanel.Width > 658)
                {
                    this.ShotPanel.Width -= 25;
                    this.ShotPanel.Height -= 15;
                }
            }
            else if (e.Delta == -120) 
            {
                if (this.ShotPanel.Width < 1215)
                {
                    this.ShotPanel.Width += 25;
                    this.ShotPanel.Height += 15;
                }
            }
        }

        public static MaxSizeSnapshot InstanceForm()
        {
            if (_instance == null)
                _instance = new MaxSizeSnapshot();
            return _instance;
        }

        void _FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

        void ShotPanel_Resize(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            this.Width = panel.Width + 24;
            this.Height = panel.Height + 53;
            panel.Top = 42;
            panel.Left = 12;
        }


        Point point;
        bool leftFlag;
        void ShotPanel_MouseDown(object sender, MouseEventArgs e) 
        {
            cutBox.Parent = ShotPanel;
            cutBox.Width = 400;
            cutBox.Height = 150;
            cutBox.Top = e.Y;
            cutBox.Left = e.X;
            cutBox.Show();
            cutBox.BringToFront();
            this.ActiveControl = cutBox;
            point.X = e.X;
            point.Y = e.Y;
            leftFlag = true;
        }

        void ShotPanel_MouseMove(object sender, MouseEventArgs e) 
        {
            Panel panel = sender as Panel;
            if (leftFlag)
            {
                Point newPoint = panel.PointToClient(Control.MousePosition);
                cutBox.Width = newPoint.X - point.X;
                cutBox.Height = newPoint.Y - point.Y;
            }
        }

        void ShotPanel_MouseUp(object sender, MouseEventArgs e) 
        {
            leftFlag = false;
        }
    }
}
