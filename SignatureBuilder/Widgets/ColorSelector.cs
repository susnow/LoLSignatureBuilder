using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace SignatureBuilder.Widgets
{
    public partial class ColorSelector : TemplateForm
    {
        public ColorSelector()
        {
            InitializeComponent();
            Type t = typeof(System.Drawing.Color);
            PropertyInfo[] p = t.GetProperties();

            int id = 0;
            foreach (PropertyInfo i in p) 
            {
                int modNum = 16;
                int spacing = 1;
                Panel panel = new Panel();
                panel.Parent = this.colors;
                panel.BackColor = Color.FromName(i.Name);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Size = new System.Drawing.Size(16, 16);
                panel.MouseClick += panel_MouseClick;

                if (id % modNum != 0 && id > modNum)
                {
                    panel.Top = Convert.ToInt32(panel.Height * (Math.Floor(Convert.ToDouble(id / modNum))) + spacing * (Math.Floor(Convert.ToDouble(id / modNum)) + 1));
                    panel.Left = panel.Width * (id % modNum) + spacing * (id % modNum + 1);
                }
                else if (id % modNum == 0 && id >= modNum)
                {
                    panel.Left = spacing;
                    panel.Top = Convert.ToInt32(panel.Height * (Math.Floor(Convert.ToDouble(id / modNum))) + spacing * (Math.Floor(Convert.ToDouble(id / modNum)) + 1));
                }
                else if (id % modNum != 0 && id <= modNum)
                {
                    panel.Top = spacing;
                    panel.Left = panel.Width * id + spacing * (id + 1);
                }
                else if (id == 0)
                {
                    panel.Top = spacing;
                    panel.Left = spacing;
                }
                id += 1;
            }
        }

        void panel_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = sender as Panel;
            colorName = panel.BackColor.Name;
            ARGB = Color.FromArgb(panel.BackColor.R, panel.BackColor.G, panel.BackColor.B);
            this.Close();
        }

        public string colorName { get; set; }
        public Color ARGB { get; set; }

        

    }
}
