using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Resources;
using System.Xml;
using System.Diagnostics;

namespace SignatureBuilder
{
    public partial class Loading : TemplateForm
    {
        public Loading()
        {
            InitializeComponent();
            Utils.XMLConfig cfg = new Utils.XMLConfig();
            cfg.CreateXmlConfig();
            this.CloseButton.Visible = false;
            this.title.Visible = false;
            this.titleboard.Visible = false;
            this.Text = "英雄联盟签名生成器";
            this.Size = new Size(300, 400);
            this.Version.Text = cfg.ProductVersion;
            this.BottomPanel.Width = this.Width - 2;
            this.BottomPanel.Left = 1;
            this.BottomPanel.Top = this.Height - 101;
            pBar.Parent = ProgressBar;
            pBar.Width = 1;
            pBar.Height = 2;
            pBar.Top = 1;
            pBar.Left = 1;
            pBar.BackColor = System.Drawing.Color.Black;

            XmlDocument xml = new XmlDocument();
            xml.Load("http://oss.aliyuncs.com/lolsignaturebuilder/LoLSignatureBuilder.xml");
            XmlNode config = xml.SelectSingleNode("Config");
            string newVersion = config.FirstChild.InnerText;
            if (this.Version.Text != newVersion)
            {
                string Updator = Application.StartupPath + "\\Update.exe";
                Process.Start(Updator);
                Process.GetCurrentProcess().Kill();
                this.LoadTimer.Enabled = false; 
            }
            else 
            {
                this.LoadTimer.Enabled = true;
            }
        }

        private void Version_Paint(object sender, PaintEventArgs e)
        {
            PointF textPoint = new PointF();
            Label label = sender as Label;
            textPoint.X = -1;
            textPoint.Y = 0;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ControlDarkDark, textPoint);
            textPoint.X = 1;
            textPoint.Y = 0;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ControlDarkDark, textPoint);
            textPoint.X = 0;
            textPoint.Y = -1;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ControlDarkDark, textPoint);
            textPoint.X = 0;
            textPoint.Y = 1;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ControlDarkDark, textPoint);
            textPoint.X = 0;
            textPoint.Y = 0;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ButtonHighlight, textPoint);
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
               
            if (pBar.Width < (ProgressBar.Width - 4))
            {
                pBar.Width += 1;
            }
            else 
            {
                this.LoadTimer.Stop();
                Utils.XMLConfig cfg = new Utils.XMLConfig();
                if (cfg.LoLFilepath.Trim() == "")
                {
                    this.label4.Text = "无法自动定位到客户端 请手动指定路径";
                    Config config = new Config();
                    config.ShowDialog(this);
                }
                else 
                {
                    //Datas.CheckVersion cv = new Datas.CheckVersion();
                    //if (cv.isNewVersion == false)
                    //{
                    //    this.label4.Text = "当前游戏版本并非最新 请先升级客户端";
                    //    Process.Start(cfg.LoLFilepath);
                    //    //this.Close();
                    //}
                    //else
                    //{
                        MainForm mf = MainForm.InstanceForm();
                        mf.Show();
                        this.Hide();
                    //}
                }

            }
        }

    }
}
