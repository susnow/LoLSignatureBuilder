using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignatureBuilder
{
    public partial class MainForm : TemplateForm
    {

        private static MainForm _instance;

        Datas.ChampionList CListObj = new Datas.ChampionList();

        //静态字典表 用来获取一张完整的英雄对象表 Dictionary<"Champion English Name", Models.Champion>
        Dictionary<string, Models.Champion> CHAMPION_LIST = Datas.ChampionList.GetChampionList();
        
        //两张字典表 收录显示列表和结果集列表面板中的Panel item(Panel Parent,Panel Parent.championItem,Label Parent.championName)
        Dictionary<int, Panel> panelList = new Dictionary<int, Panel>();
        Dictionary<int, Panel> resultList = new Dictionary<int, Panel>();

        //皮肤预览图字典表 显示某个英雄所拥有的皮肤缩略图
        Dictionary<int, Panel> previewList = new Dictionary<int, Panel>();

        //保存一下多选框控件
        List<CheckBox> cbList = new List<CheckBox>();

        public MainForm()
        {
            InitializeComponent();
            #region Debug

            Utils.FileOperate fo = new Utils.FileOperate();
            this.debugLabel.Visible = false; 
            this.debugLabel.Text = fo.GetLastLoginMasterName();

            #endregion

            #region Widget
            this.CloseButton.Visible = true;
            this.title.Visible = true;
            this.titleboard.Visible = true;
            this.title.Text = "选择英雄";

            this.ListPanel.Parent = this.ParentPanel;
            this.ListPanel.Height = 1320;
            this.ListPanel.Top = 0;
            this.ListPanel.Left = 0;

            this.ResultListPanel.Parent = this.ParentPanel;
            this.ResultListPanel.Top = 0;
            this.ResultListPanel.Left = 0;
            this.ResultListPanel.Height = 1320;

            this.ActiveControl = this.ListPanel;

            InitPanels(this.ListPanel,panelList,PP_MouseClick,Panel_Item_MouseDoubleClick);
            InitPanels(this.ResultListPanel, resultList, PP_MouseClick, Panel_Item_MouseDoubleClick);

            for (int i = 0; i < 9; i++)  //如果未来需要增加皮肤上限数量的话 这里的上标也要修改
            {
                Panel preview = this.Controls.Find("preview" + i.ToString(), true)[0] as Panel;
                previewList.Add(i, preview);
                preview.MouseClick += previewPanel_MouseClick;
            }


            cbList.Add(this.MeleeCB);
            cbList.Add(this.RangeCB);
            cbList.Add(this.ADCB);
            cbList.Add(this.APCB);
            cbList.Add(this.SupportCB);
            cbList.Add(this.JungleCB);
            cbList.Add(this.TankCB);
            cbList.Add(this.PusherCB);

            this.cutBox.Parent = ChampionPanel;
            this.CloseButton.MouseClick +=CloseButton_MouseClick;
            #endregion
        }

        public static MainForm InstanceForm() 
        {
            if (_instance == null)
                _instance = new MainForm();
            return _instance;
        }

        //初始化两个面板层 根据ChampionList表循环生成
        void InitPanels(Panel parent,Dictionary<int,Panel> PanelList,MouseEventHandler pp_MouseClick,MouseEventHandler item_MouseDoubleClick) 
        {
            int id = 0;
            foreach (KeyValuePair<string, Models.Champion> pair in CHAMPION_LIST) 
            {
                int modNum = 9;
                int spacing = 1;

                Panel pp = new Panel();
                //pp.Name = "Champion_" + pair.Key + "_Panel";
                pp.Parent = parent;
                pp.Width = 70;
                pp.Height = 100;
                pp.BackColor = Color.Transparent;
                pp.MouseClick+=pp_MouseClick;

                Panel panel = new Panel();
                panel.Width = 60;
                panel.Height = 60;
                panel.Parent = pp;
                //这里判断一下是哪个面板层 如果是结果集列表的话就先把item的背景图片置空 在其他地方处理
                panel.BackgroundImage = PanelList.Equals(panelList) ? Image.FromFile(pair.Value.Portrait) : null ;
                panel.BackgroundImageLayout = ImageLayout.Stretch;
                panel.TabIndex = 2;
                panel.Tag = pair.Key;
                panel.Top = 5;
                panel.Left = 5;
                panel.MouseClick +=pp_MouseClick;
                panel.MouseDoubleClick+=item_MouseDoubleClick;

                Label label = new Label();
                label.Text = pair.Value.DefaultName;
                label.Parent = pp;
                label.Width = 70;
                label.Height = 25;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("微软雅黑", 7, FontStyle.Bold);
                label.Top = 70;
                label.Left = 0;
                label.MouseClick+=pp_MouseClick;
                label.MouseDoubleClick+=item_MouseDoubleClick;

                if (id % modNum != 0 && id > modNum)
                {
                    pp.Top = Convert.ToInt32(pp.Height * (Math.Floor(Convert.ToDouble(id / modNum))) + spacing * (Math.Floor(Convert.ToDouble(id / modNum)) + 1));
                    pp.Left = pp.Width * (id % modNum) + spacing * (id % modNum + 1);
                }
                else if (id % modNum == 0 && id >= modNum)
                {
                    pp.Left = spacing;
                    pp.Top = Convert.ToInt32(pp.Height * (Math.Floor(Convert.ToDouble(id / modNum))) + spacing * (Math.Floor(Convert.ToDouble(id / modNum)) + 1));
                }
                else if (id % modNum != 0 && id <= modNum)
                {
                    pp.Top = spacing;
                    pp.Left = pp.Width * id + spacing * (id + 1);
                }
                else if (id == 0)
                {
                    pp.Top = spacing;
                    pp.Left = spacing;
                }
                if (!PanelList.ContainsKey(id))
                {
                    PanelList.Add(id, pp);
                }
                id += 1;
            }
        }

        void PP_MouseClick(object sender, MouseEventArgs e) 
        {
            
            foreach (KeyValuePair<int, Panel> pair in panelList)
            {
                pair.Value.BackColor = Color.White;
            }
            foreach (KeyValuePair<int, Panel> pair in resultList) 
            {
                pair.Value.BackColor = Color.White;
            }
            if (typeof(Panel).IsInstanceOfType(sender)) 
            {
                Panel panel = sender as Panel;
                if (panel.Height == 100)
                {
                    panel.BackColor = Color.Orange;
                }
                else 
                {
                    panel.Parent.BackColor = Color.Orange;
                }
            }
            else if (typeof(Label).IsInstanceOfType(sender)) 
            {
                Label label = sender as Label;
                label.Parent.BackColor = Color.Orange;
            }
            
            
        }

        void Panel_Item_MouseDoubleClick(object sender, MouseEventArgs e) 
        {

            if (!ChampionPanel.Visible)
            {
                Panel panel = sender as Panel;
                Panel parent = panel.Parent as Panel;
                Label label = parent.GetChildAtPoint(new Point(0, 70)) as Label;
                Models.Champion champion = CListObj.GetChampionByKid(label.Text);
                Utils.FileOperate fo = new Utils.FileOperate();
                Utils.BitmapOperate bo = new Utils.BitmapOperate();
                ChampionName.Tag = champion.EnName;
                ChampionName.Text = champion.DefaultName + " - " + champion.CnName;
                ChampionSkinName.Text = "经典";

                string portraitPath = fo.GetAirChampionPortrait(champion);
                ChampionPortrait.BackgroundImage = Image.FromFile(portraitPath);

                string backgroundPath = fo.GetAirChampionSkinPath(0,champion);
                ChampionPanel.BackgroundImage = Image.FromFile(backgroundPath);
                ChampionPanel.Tag = ChampionName.Tag;

                for (int i = 0; i < previewList.Count; i++)
                {
                    previewList[i].BackgroundImage = null;
                    previewList[i].BorderStyle = BorderStyle.None;
                    previewList[i].Visible = false;
                }
                for (int i = 0; i < champion.Skins.Count; i++)
                {
                    string prePath = fo.GetAirChampionSkinPreviewPath(i, champion);
                    Bitmap bmp = bo.GetPartOfImageRec(prePath, 162, 43, 162, 295, 0, -50);
                  
                    previewList[i].BackgroundImage = bmp;
                    previewList[i].BorderStyle = BorderStyle.FixedSingle;
                    previewList[i].Visible = true;
                }
                this.SkinPreviewPanel.BringToFront();
                this.SkinPreviewPanel.Visible = true;
                
                this.ActiveControl = this.SkinPreviewsPanel;
                this.ChampionPanel.BringToFront();
                this.ChampionPanel.Visible = true;

            }
            
        }

        void previewPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Utils.FileOperate fo = new Utils.FileOperate();
            Panel previewPanel = sender as Panel;
            for (int i = 0; i < previewList.Count; i++)
            {
                if (previewPanel.Equals(previewList[i]))
                {
                    Models.Champion champion = CListObj.GetChampionById(ChampionName.Tag.ToString());
                    string bgPath = fo.GetAirChampionSkinPath(i, champion);
                    ChampionPanel.BackgroundImage = Image.FromFile(bgPath);
                    ChampionSkinName.Text = champion.Skins[i].CnName;
                }
                else
                {

                }
            }
        }

        void BackButton_MouseEnter(object sender, EventArgs e)
        {
            Panel BackButton = sender as Panel;
            BackButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.back24_orange;
        }

        void BackButton_MouseLeave(object sender, EventArgs e)
        {
            Panel BackButton = sender as Panel;
            BackButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.back24_black;
        }

        void BackButton_Click(object sender, EventArgs e)
        {
            this.cutBox.Hide();
            this.ChampionPanel.Visible = false;
            this.SkinPreviewPanel.Visible = false;
        }

        void AboutButton_MouseEnter(object sender, EventArgs e)
        {
            Panel AboutButton = sender as Panel;
            AboutButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.about24_orange;
        }

        void AboutButton_MouseLeave(object sender, EventArgs e)
        {
            Panel AboutButton = sender as Panel;
            AboutButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.about24_black;
        }

        void AboutButton_MouseClick(object sender, MouseEventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog(this);
        }

        void SettingButton_MouseEnter(object sender, EventArgs e)
        {
            Panel SettingButton = sender as Panel;
            SettingButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.setting24_orange;
        }

        void SettingButton_MouseLeave(object sender, EventArgs e)
        {
            Panel SettingButton = sender as Panel;
            SettingButton.BackgroundImage = global::SignatureBuilder.Properties.Resources.setting24_black;
        }

        void SettingButton_MouseClick(object sender, MouseEventArgs e)
        {
            Config configForm = new Config();
            configForm.ShowDialog(this);
        }

        void Label_Paint(object sender, PaintEventArgs e)
        {
            PointF textPoint = new PointF();
            Label label = sender as Label;
            textPoint.X = -1;
            textPoint.Y = 0;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ButtonShadow, textPoint);
            textPoint.X = 1;
            textPoint.Y = 0;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ButtonShadow, textPoint);
            textPoint.X = 0;
            textPoint.Y = -1;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ButtonShadow, textPoint);
            textPoint.X = 0;
            textPoint.Y = 1;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ButtonShadow, textPoint);
            textPoint.X = 0;
            textPoint.Y = 0;
            e.Graphics.DrawString(label.Text, label.Font, SystemBrushes.ControlText, textPoint);
        }

        void Panel_OnMouseWheel(object sender, MouseEventArgs e) 
        {
            Panel panel = sender as Panel;

            if (e.Delta == 120)   //up
            {
                if (panel.Top >= 0)
                {
                    panel.Top = 0;
                }
                else 
                {
                    panel.Top += e.Delta;
                }
            }
            else if (e.Delta == -120)  //down
            {
                if (panel.Top <= ((0 - panel.Height) + 400))
                {
                    panel.Top = (0 - panel.Height) + 400;
                }
                else
                {
                    panel.Top += e.Delta;
                }
            }
            
        }

        void SkinPreviewPanel_MouseWheel(object sender, MouseEventArgs e) 
        {
            Panel panel = sender as Panel;
            
            if (e.Delta == 120) 
            {
                if (panel.Top >= 0)
                {
                    panel.Top = 0;
                }
                else
                {
                    panel.Top += 51;
                }
            }
            else if (e.Delta == -120) 
            {
                if (panel.Top <=-51)   //如果未来需要增加皮肤上限的话 这里也需要进行修改
                {
                    panel.Top = -51;
                }
                else
                {
                    panel.Top -= 51;
                }
                
            }
        }

        private TimeSpan oldTimeInput;
        private TimeSpan newTimeInput;

        void SearchChampionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            oldTimeInput = new TimeSpan(DateTime.Now.Ticks);
            newTimeInput = new TimeSpan(DateTime.Now.Ticks);
            stopInput.Stop();
            if (e.KeyChar == 13) 
            {
                if (SearchChampionTextBox.Text.Trim() == "")
                {
                    ResultListPanel.Visible = false;
                    //this.ActiveControl = this.ListPanel;
                }
                else 
                {
                    QueryResult("TextBox",null);
                }
            }
            else if (e.KeyChar == 27)
            {
                this.SearchChampionTextBox.Text = "";
                this.ActiveControl = this.ListPanel;
                ListPanel.Top = 0;
            }
            else 
            {
                if (SearchChampionTextBox.Text.Trim() == "")
                {
                    ResultListPanel.Visible = false;
                    ListPanel.Top = 0;
                    //this.ActiveControl = this.ListPanel;
                }
            }

        }

        void SearchChampionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchChampionTextBox.Text.Trim() == "")
            {
                ResultListPanel.Visible = false;
                ListPanel.Top = 0;
                //this.ActiveControl = this.ListPanel;
            }
        }

        void SearchChampionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            oldTimeInput = new TimeSpan(DateTime.Now.Ticks);
            newTimeInput = new TimeSpan(DateTime.Now.Ticks);
            stopInput.Start();
        }

        void stopInput_Tick(object sender, EventArgs e)
        {
            newTimeInput = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan ts = newTimeInput.Subtract(oldTimeInput).Duration();
            if (ts.Milliseconds > 300)
            {
                if (SearchChampionTextBox.Text.Trim() == "")
                {
                    ResultListPanel.Visible = false;
                    //this.ActiveControl = this.ListPanel;
                }
                else
                {
                    QueryResult("TextBox",null);

                }
                stopInput.Stop();
            }
        }

        private TimeSpan oldTimeCheck;
        private TimeSpan newTimeCheck;

        void CheckedBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.SearchChampionTextBox.Enabled = false;
            ListPanel.Top = 0;
            ResultListPanel.Top = 0;
            oldTimeCheck = new TimeSpan(DateTime.Now.Ticks);
            newTimeCheck = new TimeSpan(DateTime.Now.Ticks);
            stopChecked.Stop();
        }

        void CheckedBox_MouseUp(object sender, MouseEventArgs e)
        {
            oldTimeCheck = new TimeSpan(DateTime.Now.Ticks);
            newTimeCheck = new TimeSpan(DateTime.Now.Ticks);
            stopChecked.Start();
        }

        void stopChecked_Tick(object sender, EventArgs e)
        {
            newTimeCheck = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan ts = newTimeCheck.Subtract(oldTimeCheck).Duration();
            if (ts.Milliseconds > 500)
            {
                List<string> checkedCB = new List<string>();
                bool allClear = true;
                for (int i = 0; i < cbList.Count; i++)
                {
                    if (cbList[i].Checked)
                    {
                        allClear = false;
                        this.SearchChampionTextBox.Enabled = false;
                        checkedCB.Add(cbList[i].Text);
                    }
                }

                if (!allClear)
                {
                    this.SearchChampionTextBox.Enabled = false;
                    QueryResult("CheckBox", checkedCB);

                    stopChecked.Stop();
                }
                else 
                {
                    this.SearchChampionTextBox.Enabled = true;
                    ResultListPanel.Visible = false;
                    stopChecked.Stop();
                }
            }
        }

        void Panel_VisibleChanged(object sender, EventArgs e) 
        {
            
            if (this.ResultListPanel.Visible == true)
            {
                ResultListPanel.Focus();
            }
            else 
            {
                ListPanel.Focus();
            }
        }

        void QueryResult(string flag,List<string> CheckedTag) 
        {
            List<Models.Champion> rList = new List<Models.Champion>();
            rList.Clear();
            switch(flag)
            {
                case "TextBox": rList = CListObj.GetChampionsByKeyWord(SearchChampionTextBox.Text.Trim()); break;
                case "CheckBox": rList = CListObj.GetChampionsByTag(CheckedTag); break;
            }
            ResultListPanel.Visible = true;
            ResultListPanel.Top = 0;
            ResultListPanel.BringToFront();
            for (int i = 0; i < resultList.Count; i++) 
            {
                Panel item = resultList[i];
                item.BackColor = Color.Transparent;
                Panel panel = item.GetChildAtPoint(new Point(5, 5)) as Panel;
                Label label = item.GetChildAtPoint(new Point(0, 70)) as Label;
                panel.BorderStyle = BorderStyle.None;
                panel.BackgroundImage = null;
                label.Text = "";
                
                item.MouseClick -= PP_MouseClick;

                panel.MouseClick -=PP_MouseClick;
                label.MouseClick -=PP_MouseClick;

                panel.MouseDoubleClick -= Panel_Item_MouseDoubleClick;
                label.MouseDoubleClick -= Panel_Item_MouseDoubleClick;
            }

            for (int i = 0; i < rList.Count; i++) 
            {
                Panel item = resultList[i];
                Panel panel = item.GetChildAtPoint(new Point(5, 5)) as Panel;
                panel.BackgroundImage = Image.FromFile(rList[i].Portrait);
                panel.BorderStyle = BorderStyle.FixedSingle;
                

                Label label = resultList[i].GetChildAtPoint(new Point(0, 70)) as Label;
                label.Text = rList[i].DefaultName;

                item.MouseClick += PP_MouseClick;

                panel.MouseClick += PP_MouseClick;
                label.MouseClick += PP_MouseClick;

                panel.MouseDoubleClick += Panel_Item_MouseDoubleClick;
                label.MouseDoubleClick += Panel_Item_MouseDoubleClick;

            }
        }

        void ChampionPanel_VisibleChanged(object sender, EventArgs e) 
        {
            if (this.ChampionPanel.Visible == true)
            {
                this.BackButton.Visible = true;
                this.MaxSizeBox.Visible = false;
            }
            else 
            {
                this.BackButton.Visible = false;
                this.MaxSizeBox.Visible = false;
            }
        }

        Point point;
        bool leftFlag;
        void ChampionPanel_MouseDown(object sender, MouseEventArgs e) 
        {
            cutBox.Parent = ChampionPanel;
            cutBox.Width = 400;
            cutBox.Height = 150;
            cutBox.Top = e.Y ;
            cutBox.Left = e.X ;
            cutBox.Show();
            cutBox.BringToFront();
            point.X = e.X;
            point.Y = e.Y;
            leftFlag = true;
        }

        void ChampionPanel_MouseMove(object sender, MouseEventArgs e) 
        {
            Panel panel = sender as Panel;
            if (leftFlag) 
            {
                Point newPoint = panel.PointToClient(Control.MousePosition);
                cutBox.Width = newPoint.X - point.X;
                cutBox.Height = newPoint.Y - point.Y;
            }
        }

        void ChampionPanel_MouseUp(object sender, MouseEventArgs e) 
        {
            leftFlag = false;
        }

        void CloseButton_MouseClick(object sender, MouseEventArgs e) 
        {
            Process.GetCurrentProcess().Kill();
        }

        void _FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance = null;
        }

        void MaxSizeBox_MouseClick(object sender, MouseEventArgs e)
        {
            MaxSizeSnapshot ms = MaxSizeSnapshot.InstanceForm();
            ms.ShotPanel.BackgroundImage = this.ChampionPanel.BackgroundImage;
            ms.ShotPanel.Tag = this.ChampionName.Tag;
            ms.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


    }
}
