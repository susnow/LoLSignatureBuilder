using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Reflection;

namespace SignatureBuilder.Widgets
{
    public class CutBox:Panel
    {

        const uint WM_SYSCOMMAND = 0x0112;
        const uint SC_MOVE = 0xF010;
        const uint HTCAPTION = 0x0002;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(IntPtr hwnd, uint wMsg, uint wParam, uint lParam);
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        Panel left = new Panel();
        Panel right = new Panel();
        Panel top = new Panel();
        Panel bottom = new Panel();

        public CutBox() 
        {
            this.Width = 1;
            this.Height = 1;
            this.Visible = false;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MouseMove += CutBox_MouseMove;
            this.MouseDoubleClick += CutBox_MouseDoubleClick;
            this.BackColor = Color.Transparent;
            this.SizeChanged += CutBox_SizeChanged;
            


            left.Parent = this;
            top.Parent = this;
            right.Parent = this;
            bottom.Parent = this;

            left.BackColor = Color.LightYellow;
            right.BackColor = Color.LightYellow;
            bottom.BackColor = Color.LightYellow;
            top.BackColor = Color.LightYellow;

            left.Width = 1;
            right.Width = 1;
            top.Width = this.Width;
            bottom.Width = this.Width;

            left.Height = this.Height;
            right.Height = this.Height;
            top.Height = 1;
            bottom.Height = 1;

            left.Top = 0;
            left.Left = 0;
            right.Top = 0;
            right.Left = this.Width-3 ;
            top.Top = 0;
            top.Left = 0;
            bottom.Left = 0;
            bottom.Top = this.Height -3;
            

        }

        void CutBox_SizeChanged(object sender, EventArgs e)
        {
            left.Width = 1;
            right.Width = 1;
            top.Width = this.Width;
            bottom.Width = this.Width;

            left.Height = this.Height;
            right.Height = this.Height;
            top.Height = 1;
            bottom.Height = 1;

            left.Top = 0;
            left.Left = 0;
            right.Top = 0;
            right.Left = this.Width -3;
            top.Top = 0;
            top.Left = 0;
            bottom.Left = 0;
            bottom.Top = this.Height -3;
        }

        int curX;
        int curY;

        void CutBox_MouseMove(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
           
            if (e.X <10 && e.Y < 10) //TOPLEFT
            {
                panel.Cursor = Cursors.SizeNWSE;// \
            }
            else if (e.X > panel.Width - 10 && e.Y <10) //TOPRIGHT
            {
                panel.Cursor = Cursors.SizeNESW;// /
            }
            else if (e.X < 10 && e.Y > panel.Height - 10) //BOTTOMLEFT
            {
                panel.Cursor = Cursors.SizeNESW; // /
            }
            else if (e.X > panel.Width - 10 && e.Y > panel.Height - 10) //BOTTOMRIGHT
            {
                panel.Cursor = Cursors.SizeNWSE; // \
            }
            else if (e.Y < 10) //TOP
            {
                panel.Cursor = Cursors.SizeNS; //上下
            }
            else if (e.Y > panel.Height - 10) //BOTTOM
            {
                panel.Cursor = Cursors.SizeNS; //上下
            }
            else if (e.X < 10) //LEFT
            {
                panel.Cursor = Cursors.SizeWE; //左右
            }
            else if (e.X > panel.Width - 10) //RIGHT
            {
                panel.Cursor = Cursors.SizeWE;//左右
            }
            else 
            {
                panel.Cursor = Cursors.SizeAll;
            }

            if (e.Button == MouseButtons.Left) 
            {
                curX = e.X;
                curY = e.Y;
                
                if (panel.Cursor == Cursors.SizeWE) 
                {
                    
                    if (e.X < 10 )
                    {
                        if (e.X > curX )
                        {
                            panel.Width += e.X;
                            panel.Left -= e.X;
                        }
                        else
                        {
                            panel.Width -= e.X;
                            panel.Left += e.X;
                        }
                    }
            
                    else
                    {
                        panel.Width = e.X;
                    }
                    
                }
                else if (panel.Cursor == Cursors.SizeNS) 
                {
                    if (e.Y < 10)
                    {
                        if (e.Y > curY)
                        {
                            panel.Height += e.Y;
                            panel.Top -= e.Y;
                        }
                        else
                        {
                            panel.Height -= e.Y;
                            panel.Top += e.Y;
                        }
                    }
                    else 
                    {
                        panel.Height = e.Y;
                    }

                }
                else if (panel.Cursor == Cursors.SizeNESW) 
                {

                    if (e.X < 10)
                    {
                        if (e.X > curX)
                        {
                            panel.Width += e.X;
                            panel.Left -= e.X;
                        }
                        else
                        {
                            panel.Width -= e.X;
                            panel.Left += e.X;
                        }
                    }

                    else
                    {
                        panel.Width = e.X;
                    }

                    if (e.Y < 10)
                    {
                        if (e.Y > curY)
                        {
                            panel.Height += e.Y;
                            panel.Top -= e.Y;
                        }
                        else
                        {
                            panel.Height -= e.Y;
                            panel.Top += e.Y;
                        }
                    }
                    else
                    {
                        panel.Height = e.Y;
                    }
                   
                }
                else if (panel.Cursor == Cursors.SizeNWSE) 
                {
                    if (e.X < 10)
                    {
                        if (e.X > curX)
                        {
                            panel.Width += e.X;
                            panel.Left -= e.X;
                        }
                        else
                        {
                            panel.Width -= e.X;
                            panel.Left += e.X;
                        }
                    }

                    else
                    {
                        panel.Width = e.X;
                    }

                    if (e.Y < 10)
                    {
                        if (e.Y > curY)
                        {
                            panel.Height += e.Y;
                            panel.Top -= e.Y;
                        }
                        else
                        {
                            panel.Height -= e.Y;
                            panel.Top += e.Y;
                        }
                    }
                    else
                    {
                        panel.Height = e.Y;
                    }
                }
                else if (panel.Cursor == Cursors.SizeAll) 
                {
                    ReleaseCapture();
                    SendMessage((panel).Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
                }
            }
           
         }

        void CutBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;

            
            Bitmap source = (Bitmap)panel.Parent.BackgroundImage;
            Utils.BitmapOperate bo = new Utils.BitmapOperate();
            Bitmap bmp = null;
            if (panel.Parent.Name == "ChampionPanel")
            {
                bmp = bo.GetPartOfImageRec(source,
                (Int32)Math.Round(panel.Width / 0.543),
                (Int32)Math.Round(panel.Height / 0.543),
                (Int32)Math.Round(panel.Left / 0.543),
                (Int32)Math.Round(panel.Top / 0.543));
            }
            else if (panel.Parent.Name == "ShotPanel") 
            {
                bmp = bo.GetPartOfImageRec(source,
                (Int32)Math.Round(Convert.ToDouble(panel.Width / (Convert.ToDouble(panel.Parent.Width) / Convert.ToDouble(1215)))),
                (Int32)Math.Round(Convert.ToDouble(panel.Height / (Convert.ToDouble(panel.Parent.Height) / Convert.ToDouble(717)))),
                (Int32)Math.Round(Convert.ToDouble(panel.Left / (Convert.ToDouble(panel.Parent.Width) / Convert.ToDouble(1215)))),
                (Int32)Math.Round(Convert.ToDouble(panel.Top / (Convert.ToDouble(panel.Parent.Height) / Convert.ToDouble(717)))));
            }
             
            Datas.ChampionList ClistObj = new Datas.ChampionList();
            //Datas.LoginSeverList LlistObj = new Datas.LoginSeverList();
            Models.Champion champion = ClistObj.GetChampionById(panel.Parent.Tag.ToString());
            Utils.FileOperate fo = new Utils.FileOperate();
            
            Snapshot ss = new Snapshot();
            ss.ShotPanel.Width = panel.Width;
            ss.ShotPanel.Height = panel.Height;
            Point point = panel.PointToScreen(new Point(0,0));
            ss.StartPosition = FormStartPosition.Manual;
            ss.Location = new Point(point.X-15, point.Y-15);
            ss.ShotPanel.BackgroundImage = bmp;
            ss.ShotPanel.BackgroundImageLayout = ImageLayout.Stretch;
            ss.ChampionName.Tag = champion.EnName;
            

            if (champion.Spells != null && champion.Spells.Count > 0)
            {
                foreach (Models.Spell spell in champion.Spells)
                {
                    if (champion.EnName != "DrMundo")
                    {
                        Panel spellpanel = ss.ShotPanel.Controls.Find(spell.shortKey, true)[0] as Panel;
                        Bitmap spellbmp = bo.GetPartOfImageRec((fo.GetSpellPath() + spell.pathName + ".png"), spellpanel.Width - 3, spellpanel.Height - 3, spellpanel.Width, spellpanel.Height, -2, -2);
                        spellpanel.BackgroundImage = spellbmp;
                    }
                    else 
                    {
                        if (spell.shortKey == "w") 
                        {
                            Panel spellpanel = ss.ShotPanel.Controls.Find("w", true)[0] as Panel;
                            Bitmap spellbmp = bo.GetPartOfImageRec((global::SignatureBuilder.Properties.Resources.DrMundo_KissOfDeath), spellpanel.Width - 3, spellpanel.Height - 3, spellpanel.Width, spellpanel.Height, -2, -2);
                            spellpanel.BackgroundImage = spellbmp;
                        }
                        else if (spell.shortKey == "e")
                        {
                            Panel spellpanel = ss.ShotPanel.Controls.Find("e", true)[0] as Panel;
                            Bitmap spellbmp = bo.GetPartOfImageRec((global::SignatureBuilder.Properties.Resources.DrMundo_Masochism), spellpanel.Width - 3, spellpanel.Height - 3, spellpanel.Width, spellpanel.Height, -2, -2);
                            spellpanel.BackgroundImage = spellbmp;
                        }
                        else 
                        {
                            Panel spellpanel = ss.ShotPanel.Controls.Find(spell.shortKey, true)[0] as Panel;
                            Bitmap spellbmp = bo.GetPartOfImageRec((fo.GetSpellPath() + spell.pathName + ".png"), spellpanel.Width - 3, spellpanel.Height - 3, spellpanel.Width, spellpanel.Height, -2, -2);
                            spellpanel.BackgroundImage = spellbmp;
                        }
                    }
                }
            } 

            ss.ShowDialog(this);
            

        }
    }
}
