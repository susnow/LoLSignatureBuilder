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

namespace SignatureBuilder
{
    public partial class Snapshot : TemplateForm
    {

        const uint WM_SYSCOMMAND = 0x0112;
        const uint SC_MOVE = 0xF010;
        const uint HTCAPTION = 0x0002;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, uint wMsg, uint wParam, uint lParam);
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        Datas.ChampionList CListObj = new Datas.ChampionList();
        Dictionary<string,Models.FontText> Fts = new Dictionary<string,Models.FontText>();
        public Snapshot()
        {
            InitializeComponent();
            Datas.LoginSeverList LlistObj = new Datas.LoginSeverList();
            List<Models.LoginSever> lsList = LlistObj.GetSeverList();
            for (int i = 0; i < lsList.Count; i++)
            {
                Label label = this.Controls.Find("sv" + i.ToString(), true)[0] as Label;
                label.Text = lsList[i].sName;
                label.Tag = lsList[i].sID;
                label.Click += SeverLabelClick;
            }
            this.TB_Summor.Parent = this.ShotPanel;
            this.ChampionName.Parent = this.ShotPanel;
            this.LOL.Parent = this.ShotPanel;
            this.LoginSeverList.Parent = this;
            this.FileLink.Click += FileLink_Click;

            this.q.Parent = this.ShotPanel;
            this.w.Parent = this.ShotPanel;
            this.e.Parent = this.ShotPanel;
            this.r.Parent = this.ShotPanel;
            this.t.Parent = this.ShotPanel;
   
        }

        string lvdata = "";

        void Snapshot_Load(object sender, EventArgs e)
        {
            #region Datas
            Datas.LoginSeverList LlistObj = new Datas.LoginSeverList();
            Utils.FileOperate fo = new Utils.FileOperate();
            string loginQ = fo.GetGameLoginPath();
            Utils.INIConfig ini = new Utils.INIConfig(loginQ);
            this.SummorName.Tag = fo.GetLastLoginMasterName();
            string QQ = ini.GetSectionKey_StringValue("Public", "LastQQUin", "") == "" ? "" : ini.GetSectionKey_StringValue("Public", "LastQQUin", "");
            for (int i = 0; i < LlistObj.GetSeverList().Count; i++)
            {
                string key = ini.GetSectionKey_StringValue("LoginUserRecord", "QQ" + QQ.Trim(), "");
                if (key == "")
                {
                    if (LlistObj.GetSeverList()[i].sID == 257)
                    {
                        this.SeverName.Tag = LlistObj.GetSeverList()[i].sName;
                        ini.EditSectionKey_IntValue("NoLoginUserRecord", "LastLogin", 257);
                        break;

                    }
                }
                else
                {
                    if (LlistObj.GetSeverList()[i].sID == Convert.ToInt32(key))
                    {
                        this.SeverName.Tag = LlistObj.GetSeverList()[i].sName;
                        break;
                    }
                }
            }

            #endregion

            #region Widget
            Models.FontText champion = new Models.FontText();
            //champion.point = this.ChampionName.Location;
            champion.text = this.ChampionName.Tag.ToString();
            champion.family = "Verdana";
            champion.size = 10;

            Models.FontText server = new Models.FontText();
            //server.point = this.SeverName.Location;
            server.text = this.SeverName.Tag.ToString();
            server.size = 12;

            Models.FontText summor = new Models.FontText();
            //summor.point = this.SummorName.Location;
            summor.text = this.SummorName.Tag.ToString();
            summor.size = 12;

            Models.FontText lolog = new Models.FontText();
            //lol.point = this.LOL.Location;
            lolog.text = this.LOL.Tag.ToString();
            lolog.family = "Calibri";
            lolog.size = 10;

            Models.FontText rank = new Models.FontText();
            rank.text = "战斗力:";


            Fts.Add("RankName", rank);
            Fts.Add("ChampionName", champion);
            Fts.Add("SummorName", summor);
            Fts.Add("SeverName", server);
            Fts.Add("LOL", lolog);

            this.ActiveControl = this.ShotPanel;
            this.Width = this.ShotPanel.Width + 30;
            this.Height = this.ShotPanel.Height + 40;
            this.ShotPanel.Top = 15;
            this.ShotPanel.Left = 15;
            this.SeverName.Left = 10;
            this.SeverName.Top = 10;
            this.SummorName.Left = this.SeverName.Left;
            this.SummorName.Top = this.SeverName.Bottom + 5;

            

            Graphics championname = CreateGraphics();
            SizeF championsize = championname.MeasureString(Fts["ChampionName"].text, new Font(Fts["ChampionName"].family, Fts["ChampionName"].size));
            ChampionName.Width = Convert.ToInt32(championsize.Width);
            ChampionName.Height = Convert.ToInt32(championsize.Height);
            this.ChampionName.Left = this.ShotPanel.Width - Convert.ToInt32(championsize.Width) - 3;
            this.ChampionName.Top = 3;

            Graphics lol = CreateGraphics();
            SizeF lolsize = lol.MeasureString(Fts["LOL"].text, new Font(Fts["LOL"].family, Fts["LOL"].size));
            LOL.Width = Convert.ToInt32(lolsize.Width);
            LOL.Height = Convert.ToInt32(lolsize.Height);
            this.LOL.Left = this.ShotPanel.Width - this.LOL.Width + 17;
            this.LOL.Top = this.ShotPanel.Height - this.LOL.Height - 2;
            
            Graphics rankg = CreateGraphics();
            SizeF ranksize = rankg.MeasureString(Fts["RankName"].text, new Font(Fts["RankName"].family, Fts["RankName"].size));
            RankName.Width = Convert.ToInt32(ranksize.Width);
            RankName.Height = Convert.ToInt32(ranksize.Height);
            this.RankName.Top = this.SummorName.Bottom + 5;
            this.RankName.Left = this.SummorName.Left;


            this.cancelButton.Top = this.ShotPanel.Top + this.ShotPanel.Height + 2;
            this.cancelButton.Left = this.Width - this.cancelButton.Width - 10;
            this.SaveButton.Top = this.cancelButton.Top;
            this.SaveButton.Left = this.Width - this.SaveButton.Width * 2 - 15;

            this.CB_Rank.Top = this.SaveButton.Top-2;
            this.CB_Rank.Left = this.SaveButton.Left - this.CB_Rank.Width;

            this.Sig.Top = this.cancelButton.Top;
            this.Sig.Left = this.ShotPanel.Left;
            this.FileLink.Top = this.cancelButton.Top;
            this.FileLink.Left = this.Sig.Right - 2;
            this.SaveOK.Top = this.cancelButton.Top;
            this.SaveOK.Left = this.FileLink.Right - 2;

            this.q.Top = this.ShotPanel.Height - this.q.Height - 5;
            this.q.Left = 5;

            this.w.Top = this.q.Top;
            this.w.Left = this.q.Right + 3;

            this.e.Top = this.q.Top;
            this.e.Left = this.w.Right + 3;

            this.r.Top = this.q.Top;
            this.r.Left = this.e.Right + 3;
            this.t.Top = this.q.Top;
            this.t.Left = this.r.Right + 3;

            this.q.Paint += spell_Paint;
            this.w.Paint += spell_Paint;
            this.e.Paint += spell_Paint;
            this.r.Paint += spell_Paint;
            this.t.Paint += spell_Paint;

            this.Spell_Config.Top = this.ShotPanel.Bottom + 20;
            this.Label_Config.Top = this.ShotPanel.Bottom + 20;

            this.labelQ.Tag = 1;
            this.labelW.Tag = 1;
            this.labelE.Tag = 1;
            this.labelR.Tag = 1;
            this.labelT.Tag = 1;

            string severname = lList.GetSeverDataById(this.SeverName.Tag.ToString());
            Datas.WebDatas wb = new Datas.WebDatas(severname, Fts["SummorName"].text);
            Fts["RankName"].text =   wb.Level + "  " + wb.WinPoint;
            //switch (rankdisplay)
            //{
            //    case "Fight": Fts["RankName"].text = "战斗力:" + wb.Fight; break;
            //    case "SoloRank": Fts["RankName"].text = "5v5单人:" + wb.SoloRank; break;
            //    case "TeamRank": Fts["RankName"].text = "5v5组队:" + wb.TeamRank; break;
            //}
            SetPanelSize(this.RankName);
            lvdata =   wb.Level  + "  " + wb.WinPoint;
            //fightInit = wb.Fight;
            //soloInit = wb.SoloRank;
            //teamInit = wb.TeamRank;


            #endregion

        }

        void SetPanelSize(Panel panel) 
        {
            Graphics pg = CreateGraphics();
            SizeF pSize = pg.MeasureString(Fts[panel.Name].text, new Font(Fts[panel.Name].family, Fts[panel.Name].size));
            panel.Width = Convert.ToInt32(pSize.Width);
            panel.Height = Convert.ToInt32(pSize.Height);
            //panel.Invalidate();
        }

        void SeverName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.LoginSeverList.Visible = true;
            this.LoginSeverList.BringToFront();
            this.LoginSeverList.Location = new Point(0, 0);
        }

        void SeverLabelClick(object sender, EventArgs e)
        {
            Utils.FileOperate fo = new Utils.FileOperate();
            string loginPath = fo.GetGameLoginPath();
            Utils.INIConfig cfg = new Utils.INIConfig(loginPath);
            Label label = sender as Label;
            cfg.EditSectionKey_StringValue("LoginUserRecord", "QQ" + cfg.GetSectionKey_StringValue("Public","LastQQUin",""), label.Tag.ToString());

            SeverName.Tag = label.Text;
            LoginSeverList.Visible = false;
            Fts["SeverName"].text = label.Text;
            this.SeverName.Invalidate();
        }

        void SummorName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            this.TB_Summor.Visible = true;
            this.TB_Summor.Text = panel.Tag.ToString();
            this.TB_Summor.Location = new Point(panel.Left, panel.Top);
            this.TB_Summor.BringToFront();
            this.TB_Summor.Focus();
        }

        void TB_Summor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            {
                this.SummorName.Tag = TB_Summor.Text;
                TB_Summor.Visible = false;
                Fts["SummorName"].text = TB_Summor.Text;
                this.SummorName.Invalidate();
            }
            else if (e.KeyChar == 27) 
            {
                TB_Summor.Visible = false;
            }
        }

        void spell_Paint(object sender, PaintEventArgs e) 
        {
            Panel panel = sender as Panel;
            Label label = this.Controls.Find("label" + panel.Name.ToUpper(), true)[0] as Label;
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                this.spell_board_color_select.BackColor, Convert.ToInt32(label.Tag.ToString()), ButtonBorderStyle.Solid,
                this.spell_board_color_select.BackColor, Convert.ToInt32(label.Tag.ToString()), ButtonBorderStyle.Solid,
                this.spell_board_color_select.BackColor, Convert.ToInt32(label.Tag.ToString()), ButtonBorderStyle.Solid,
                this.spell_board_color_select.BackColor, Convert.ToInt32(label.Tag.ToString()), ButtonBorderStyle.Solid
                );
        }

        void ShotPanel_Paint(object sender, PaintEventArgs e) 
        {
            Panel panel = sender as Panel;
            foreach (KeyValuePair<string, Models.FontText> pair in Fts)
            {
                if (panel.Name == pair.Key)
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    SolidBrush brushWhite = new SolidBrush(Color.Transparent);
                    e.Graphics.FillRectangle(brushWhite, 0, 0,
                    panel.Width, panel.Height);
                    StringFormat strformat = new StringFormat();
                    GraphicsPath path = new GraphicsPath();
                    
                    path.AddString(pair.Value.text, new FontFamily(pair.Value.family),
                    (int)FontStyle.Regular, pair.Value.size, new Point(1,1), strformat);
                    Pen pen = new Pen(Color.FromArgb(pair.Value.outlineRed, pair.Value.outlineGreen, pair.Value.outlineBlue), pair.Value.outlineWidth);
                    e.Graphics.DrawPath(pen, path);
                    SolidBrush brush = new SolidBrush(Color.FromArgb(pair.Value.foreRed, pair.Value.foreGreen, pair.Value.foreBlue));
                    for (int j = 1; j < 8; ++j)
                    {
                        pen = new Pen(Color.FromArgb(pair.Value.glowAlpha, pair.Value.glowRed, pair.Value.glowGreen, pair.Value.glowBlue), j);
                        pen.LineJoin = LineJoin.Round;
                        e.Graphics.DrawPath(pen, path);
                        pen.Dispose();
                    }

                    e.Graphics.FillPath(brush, path);
                }
            }
           
        }

        void Panel_Paint(object sender, PaintEventArgs e) 
        {
            Panel panel = sender as Panel;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            SolidBrush brush = new SolidBrush(Color.Transparent);
            e.Graphics.FillRectangle(brush, 1, 1, panel.Width+1, panel.Height+1);

            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(1, 1, panel.Width+1, panel.Height+1));
            SolidBrush fBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            for (int i = 1; i < 8; ++i) 
            {
                Pen pen = new Pen(Color.FromArgb(20, 250, 255, 221), i);
                pen.LineJoin = LineJoin.Round;
                e.Graphics.DrawPath(pen, path);
                pen.Dispose();
            }
            e.Graphics.FillPath(brush, path);
        }

        void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SaveButton_Click(object sender, EventArgs e)
        {
            
            this.Focus();
            this.BringToFront();
            Utils.BitmapOperate bo = new Utils.BitmapOperate();
            Point point = PointToScreen(ShotPanel.Location);
            this.Sig.Show();
            this.FileLink.Show();
            this.SaveOK.Show();
            string path = bo.SaveBitMap(point.X, point.Y, this.ShotPanel.Width, this.ShotPanel.Height, this.ChampionName.Tag.ToString());
            this.FileLink.Text = System.IO.Path.GetFileNameWithoutExtension(path);
            this.FileLink.Tag = path;
        }

        void FileLink_Click(object sender, EventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            System.Diagnostics.Process.Start(link.Tag.ToString());
        }

        void InfoVisible(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label.Visible == true) 
            {
                this.Sig.Top = this.cancelButton.Top;
                this.Sig.Left = this.ShotPanel.Left;
                this.FileLink.Top = this.cancelButton.Top;
                this.FileLink.Left = this.Sig.Right - 2;
                this.SaveOK.Top = this.cancelButton.Top;
                this.SaveOK.Left = this.FileLink.Right + 20;
            }
        }

        bool LeftFlag = false;

        void Spell_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) 
            {
                LeftFlag = true;
            }
            

        }

        void Spell_MouseMove(object sender, MouseEventArgs e)
        {
            if (LeftFlag)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Panel panel = sender as Panel;
                    ReleaseCapture();
                    SendMessage((panel).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
                }
            }
        }

        void Spell_MouseUp(object sender, MouseEventArgs e)
        {
            if (LeftFlag) 
            {
                LeftFlag = false;
            }
        }

        string Sender = "";
        
        void spell_board_color_select_Click(object sender, EventArgs e)
        {
            Widgets.ColorSelector cs = new Widgets.ColorSelector();
            cs.ShowDialog(this);
            this.spell_board_color_select.BackColor = cs.ARGB;

            this.Controls.Find(Sender, true)[0].Tag = cs.colorName;
            this.Controls.Find(Sender, true)[0].Invalidate();
        }

        void q_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            {
                Sender = panel.Name;
                this.spell_board_color_select.BackColor = Color.FromName(panel.Tag.ToString());
                if (Label_Config.Visible == true) 
                {
                    this.Height -= Label_Config.Height;
                    Label_Config.Hide();
                }
                if (Spell_Config.Visible == false)
                {
                    this.Height += this.Spell_Config.Height ;
                    
                    Spell_Config.Show();
                    
                } 
            }
        }

        void spell_board_width_plus_Click(object sender, EventArgs e)
        {
            string lb = "label" + Sender;
            Label label = this.Controls.Find(lb, true)[0] as Label;
            label.Tag = Convert.ToInt32(label.Tag.ToString()) + 1;
            this.Controls.Find(Sender, true)[0].Invalidate();

        }

        void spell_board_width_minus_Click(object sender, EventArgs e)
        {
            string lb = "label" + Sender;
            Label label = this.Controls.Find(lb, true)[0] as Label;
            label.Tag = Convert.ToInt32(label.Tag.ToString()) - 1 < 0 ? 0 : Convert.ToInt32(label.Tag.ToString()) - 1;
            this.Controls.Find(Sender, true)[0].Invalidate();
        }

        void Spell_Enable_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                this.q.Hide();
                this.w.Hide();
                this.e.Hide();
                this.r.Hide();
                this.t.Hide();
            }
            else 
            {
                this.q.Show();
                this.w.Show();
                this.e.Show();
                this.r.Show();
                this.t.Show();
            }
        }

        void Label_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            if (e.Button == System.Windows.Forms.MouseButtons.Right) 
            {
                Sender = panel.Name;
                if (Spell_Config.Visible == true) 
                {
                    this.Height -= this.Spell_Config.Height;
                    this.Spell_Config.Hide();
                }
                

                if (Label_Config.Visible == false)
                {
                    this.Height += this.Label_Config.Height ;
                    
                    Label_Config.Show();
                }

                this.label_fore_color_select.BackColor = Color.FromArgb(Fts[Sender].foreAlpha, Fts[Sender].foreRed, Fts[Sender].foreGreen, Fts[Sender].foreBlue);
                this.label_outline_color_select.BackColor = Color.FromArgb(Fts[Sender].outlineAlpha, Fts[Sender].outlineRed, Fts[Sender].outlineGreen, Fts[Sender].outlineBlue);
                this.label_glow_color_select.BackColor = Color.FromArgb(Fts[Sender].glowAlpha, Fts[Sender].glowRed, Fts[Sender].glowGreen, Fts[Sender].glowBlue);

                this.label_fontstyle.Text = Fts[Sender].family;
                this.label_visible.Checked = !panel.Visible;

             }
        }

        void label_fontstyle_Click(object sender, EventArgs e)
        {
            FD.ShowEffects = false;
            FD.ShowColor = false;
            FD.Font = new System.Drawing.Font(Fts[Sender].family, Fts[Sender].size);
            FD.ShowDialog(this);
            
            this.label_fontstyle.Text = FD.Font.FontFamily.Name;
            Fts[Sender].family = FD.Font.FontFamily.Name;
            Fts[Sender].size = FD.Font.Size;
            Panel panel = this.Controls.Find(Sender, true)[0] as Panel;

            Graphics g = CreateGraphics();
            SizeF sizeF = g.MeasureString(Fts[Sender].text, new Font(Fts[Sender].family, Fts[Sender].size));
            panel.Width = Convert.ToInt32(sizeF.Width);
            panel.Height = Convert.ToInt32(sizeF.Height);
            panel.Invalidate();
        }

        void label_fore_color_select_MouseClick(object sender, MouseEventArgs e)
        {
            Widgets.ColorSelector cs = new Widgets.ColorSelector();
            cs.colorName = this.label_fore_color_select.BackColor.Name;
            cs.ARGB = this.label_fore_color_select.BackColor;
            cs.ShowDialog(this);
            this.label_fore_color_select.BackColor = Color.FromName(cs.colorName);
            Fts[Sender].foreAlpha = cs.ARGB.A;
            Fts[Sender].foreRed = cs.ARGB.R;
            Fts[Sender].foreGreen = cs.ARGB.G;
            Fts[Sender].foreBlue = cs.ARGB.B;
            Panel panel = this.Controls.Find(Sender, true)[0] as Panel;
            panel.Invalidate();

        }

        void label_outline_color_select_MouseClick(object sender, MouseEventArgs e)
        {
            Widgets.ColorSelector cs = new Widgets.ColorSelector();
            cs.colorName = this.label_outline_color_select.BackColor.Name;
            cs.ARGB = this.label_outline_color_select.BackColor;
            cs.ShowDialog(this);
            this.label_outline_color_select.BackColor = Color.FromName(cs.colorName);
            Fts[Sender].outlineAlpha = cs.ARGB.A;
            Fts[Sender].outlineRed = cs.ARGB.R;
            Fts[Sender].outlineGreen = cs.ARGB.G;
            Fts[Sender].outlineBlue = cs.ARGB.B;
            Panel panel = this.Controls.Find(Sender, true)[0] as Panel;
            panel.Invalidate();
        }

        void label_glow_color_select_MouseClick(object sender, MouseEventArgs e)
        {
            Widgets.ColorSelector cs = new Widgets.ColorSelector();
            cs.colorName = this.label_glow_color_select.BackColor.Name;
            //cs.ARGB = this.label_glow_color_select.BackColor;
            cs.ShowDialog(this);
            this.label_glow_color_select.BackColor = Color.FromName(cs.colorName);
            //Fts[Sender].glowAlpha = cs.ARGB.A;
            Fts[Sender].glowRed = cs.ARGB.R;
            Fts[Sender].glowGreen = cs.ARGB.G;
            Fts[Sender].glowBlue = cs.ARGB.B;
            Panel panel = this.Controls.Find(Sender, true)[0] as Panel;
            panel.Invalidate();
        }

        void label_outline_width_plus_MouseClick(object sender, MouseEventArgs e)
        {
            Fts[Sender].outlineWidth += 1;
            Panel panel = this.Controls.Find(Sender, true)[0] as Panel;
            panel.Invalidate();
        }

        void label_outline_width_minus_MouseClick(object sender, MouseEventArgs e)
        {
            if (Fts[Sender].outlineWidth > 0)
            {
                Fts[Sender].outlineWidth -= 1;
            }
            Panel panel = this.Controls.Find(Sender, true)[0] as Panel;
            panel.Invalidate();
        }

        void label_glow_width_plus_MouseClick(object sender, MouseEventArgs e)
        {
            if (Fts[Sender].glowAlpha < 255)
            {
                Fts[Sender].glowAlpha += 5;
            }
            Panel panel = this.Controls.Find(Sender, true)[0] as Panel;
            panel.Invalidate();
        }

        void label_glow_width_minus_MouseClick(object sender, MouseEventArgs e)
        {
            if (Fts[Sender].glowAlpha >0)
            {
                Fts[Sender].glowAlpha -= 5;
            }
            Panel panel = this.Controls.Find(Sender, true)[0] as Panel;
            panel.Invalidate();
        }

        void label_visible_CheckedChanged(object sender, EventArgs e)
        {
            Panel panel = this.Controls.Find(Sender, true)[0] as Panel;
            panel.Visible = !label_visible.Checked;
        }

        string rankdisplay = "Fight";

        Datas.LoginSeverList lList = new Datas.LoginSeverList();



        void CB_Rank_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CB_Rank.Checked)
            {
                RefreshRankMode();

            }
            else 
            {
                this.RankName.Hide();
            }
        }


        void RefreshRankMode()
        {
            //switch (rankdisplay)
            //{
            //    case "Fight": Fts["RankName"].text = "所在组:" + fightInit; break;
            //    case "SoloRank": Fts["RankName"].text = "5v5单人:" + soloInit; break;
            //    case "TeamRank": Fts["RankName"].text = "5v5组队:" + teamInit; break;
            //}
            SetPanelSize(RankName);
            this.RankName.Invalidate();
            this.RankName.Show();
        }

        void RankMode_VisibleChanged(object sender, EventArgs e)
        {
            //if (RankMode.Visible) 
            //{
            //    switch (rankdisplay)
            //    {
            //        case "Fight": rb_Level.Checked = true ; break;
            //        case "SoloRank": rb_WinPoint.Checked = true; break;
            //        case "TeamRank": rb_teamrank.Checked = true ; break;
            //    }
            //}
        }

        void rb_fight_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rb = sender as RadioButton;
            //if (rb.Checked) 
            //{
            //    rankdisplay = "Fight";
            //    RefreshRankMode();
            //    this.RankMode.Hide();
            //}
        }

        void rb_solorank_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rb = sender as RadioButton;
            //if (rb.Checked)
            //{
            //    rankdisplay = "SoloRank";
            //    RefreshRankMode();
            //    this.RankMode.Hide();
            //}
        }

        void rb_teamrank_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton rb = sender as RadioButton;
            //if (rb.Checked)
            //{
            //    rankdisplay = "TeamRank";
            //    RefreshRankMode();
            //    this.RankMode.Hide();
            //}
        }

        void RankName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            this.RankMode.Show();
            this.RankMode.Top = panel.Bottom+10;
            this.RankMode.Left = panel.Left;
        }
        
    }
}
