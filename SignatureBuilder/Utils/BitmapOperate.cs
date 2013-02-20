using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SignatureBuilder.Utils
{
    public class BitmapOperate
    {

        public Bitmap GetPartOfImageRec(string sourceBmp, int width, int height, int newWidth, int newHeight, int offsetX, int offsetY)
        {
            Bitmap result = new Bitmap(width, height);
            Bitmap source = new Bitmap(sourceBmp);
            using (Graphics g = Graphics.FromImage(result)) 
            {
                Rectangle rec = new Rectangle(offsetX, offsetY, newWidth, newHeight);
                //g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(source, rec);
            }
            return result;
        }

        public Bitmap GetPartOfImageRec(Bitmap sourceBmp, int width, int height, int newWidth, int newHeight, int offsetX, int offsetY)
        {
            Bitmap result = new Bitmap(width, height);
            Bitmap source = new Bitmap(sourceBmp);
            using (Graphics g = Graphics.FromImage(result))
            {
                Rectangle rec = new Rectangle(offsetX, offsetY, newWidth, newHeight);
                //g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(source, rec);
            }
            return result;
        }

        public Bitmap GetPartOfImageRec(Bitmap source, int width, int height, int offsetX, int offsetY) 
        {

            Bitmap resultBitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resultBitmap))
            {
                Rectangle resultRectangle = new Rectangle(0, 0, width, height);
                Rectangle sourceRectangle = new Rectangle(0 + offsetX, 0 + offsetY, width, height);
                //g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(source, resultRectangle, sourceRectangle, GraphicsUnit.Pixel);
            }
            return resultBitmap;
        }

        public string SaveBitMap(int offsetX, int offsetY, int width, int height,string championName) 
        {
            string path = "";
            Bitmap shot = new Bitmap(width, height);
            XMLConfig xml = new XMLConfig();
            Utils.FileOperate fo = new FileOperate();

            using (Graphics g = Graphics.FromImage(shot)) 
            {
                //g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.CopyFromScreen(offsetX, offsetY, 0, 0, new Size(width, height));
                string index = fo.GetLastIndexFile(xml.SavePath, championName);
                shot.Save(xml.SavePath +"\\" +championName + "_" + index +  ".png");
                path = xml.SavePath + "\\" + championName + "_" + index + ".png";
                shot.Dispose();
                g.Dispose();
            }
            return path;
        }
               
    }
}
