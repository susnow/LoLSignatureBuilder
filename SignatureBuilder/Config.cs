using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignatureBuilder
{
    public partial class Config : TemplateForm
    {
        Utils.XMLConfig cfg = new Utils.XMLConfig();
        public Config()
        {
            InitializeComponent();
            this.CloseButton.Visible = true;
            this.title.Text = "设置";

            
            this.ClientPathLabel.Text = cfg.GetXmlNodeValue("LoLFilePath") == "empty" ? "" : cfg.GetXmlNodeValue("LoLFilePath");
            this.SigSavePathLabel.Text = cfg.GetXmlNodeValue("SavePath");
            this.CloseButton.Click += CloseButton_Click;
        }

        MainForm main;
        void CloseButton_Click(object sender, EventArgs e)
        {
            if (main == null || main.IsDisposed)
            {
                main = MainForm.InstanceForm();
                main.Show();
            }
            else 
            {
                main.Activate();
            }
            foreach (Form f in Application.OpenForms) 
            {
                if (f.Name == "Loading") 
                {
                    f.Hide();
                }
                else if (f.Name == "Config") 
                {
                    f.Close();
                }
            }
        }

        void Button_MouseEnter(object sender, EventArgs e)
        {
            if (typeof(Panel).IsInstanceOfType(sender)) 
            {
                Panel panel = sender as Panel;
                Label label = panel.GetChildAtPoint(new Point(7, 6)) as Label;
                label.ForeColor = Color.Orange;
            }
            else if (typeof(Label).IsInstanceOfType(sender)) 
            {
                Label label = sender as Label;
                label.ForeColor = Color.Orange;
            }
        }

        void Button_MouseLeave(object sender, EventArgs e)
        {
            if (typeof(Panel).IsInstanceOfType(sender))
            {
                Panel panel = sender as Panel;
                Label label = panel.GetChildAtPoint(new Point(7, 6)) as Label;
                label.ForeColor = Color.Black;
            }
            else if (typeof(Label).IsInstanceOfType(sender))
            {
                Label label = sender as Label;
                label.ForeColor = Color.Black;
            }
        }

        void ClientButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "英雄联盟运行程序|Client.exe";
            ofd.FileName = "Client.exe";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                //string suffix = cfg.LoLFilepath.Substring(cfg.LoLFilepath.LastIndexOf("\\") +1, cfg.LoLFilepath.LastIndexOf(".") - cfg.LoLFilepath.LastIndexOf("\\") -1);
                cfg.EditXmlNodeValue("LoLFilePath", ofd.FileName);
                this.ClientPathLabel.Text = ofd.FileName;
                ofd.InitialDirectory = cfg.LoLFilepath;
            }

            if (this.ClientPathLabel.Text != "") 
            {
                this.CloseButton.Visible = true;
            }
        }

        void SigFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = this.SigSavePathLabel.Text;
            fbd.ShowNewFolderButton = true;
            fbd.Description = "选择签名保存的目录";
            if (fbd.ShowDialog() == DialogResult.OK) 
            {
                cfg.EditXmlNodeValue("SavePath", fbd.SelectedPath);
                this.SigSavePathLabel.Text = fbd.SelectedPath;
            }
        }

        private void Config_Load(object sender, EventArgs e)
        {
            if (this.ClientPathLabel.Text != "")
            {
                this.CloseButton.Visible = true;
            }
            else
            {
                this.CloseButton.Visible = false;
            }
        }
    }
}
