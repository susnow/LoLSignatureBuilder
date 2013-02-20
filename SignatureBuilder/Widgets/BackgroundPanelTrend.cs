using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SignatureBuilder.Widgets
{
    public class BackGroundPanelTrend : Panel
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // 
            // 重载基类的背景擦除函数，
            // 解决窗口刷新，放大，图像闪烁
            // do nothing here: doesn't paint background => no flickering
            return;

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // render-code goes here
            this.DoubleBuffered = true;

            if (this.BackgroundImage != null)
            {
                //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                // e.ClipRectangle
                e.Graphics.DrawImage(this.BackgroundImage, new System.Drawing.Rectangle(0, 0, this.Width, this.Height),
                        0, 0, this.BackgroundImage.Width, this.BackgroundImage.Height,
                        System.Drawing.GraphicsUnit.Pixel);

            }
            //else 
            //{
            //    //这段实话说 个人感觉没什么效果 这个broken完全不去管也可以...
            //    e.Graphics.DrawImage(this.Parent.BackgroundImage, new Rectangle(0, 0, this.Width, this.Height),
            //        Convert.ToInt32((float)this.Left * 1.85), Convert.ToInt32((float)this.Top * 1.85), Convert.ToInt32((float)this.Width * 1.85), Convert.ToInt32(((float)this.Height * 1.85)),
            //        System.Drawing.GraphicsUnit.Pixel);
            //} 

            base.OnPaint(e);
        }
    }
}
