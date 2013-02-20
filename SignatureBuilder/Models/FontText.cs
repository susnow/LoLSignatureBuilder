using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SignatureBuilder.Models
{
    public class FontText
    {
        public FontText() 
        {
            this.text = "";
            this.family = "微软雅黑";
            this.size = 12;
            this.point = new Point(0, 0);

            this.foreAlpha = 255;
            this.foreRed = 255;
            this.foreGreen = 255;
            this.foreBlue = 255;

            this.outlineAlpha = 255;
            this.outlineRed = 0;
            this.outlineGreen = 0;
            this.outlineBlue = 0;
            this.outlineWidth = 2;

            this.glowAlpha = 20;
            this.glowRed = 250;
            this.glowGreen = 255;
            this.glowBlue = 221;
        }

        public FontText(string eText,FontFamily eFamily, int eSize, Point ePoint, Color foreColor, Color outlineColor, int olWidth, Color glowColor) 
        {
            this.text = eText;
            this.family = eFamily.Name;
            this.size = eSize;
            this.point = ePoint;

            this.foreAlpha = foreColor.A;
            this.foreRed = foreColor.R;
            this.foreGreen = foreColor.G;
            this.foreBlue = foreColor.B;

            this.outlineAlpha = outlineColor.A;
            this.outlineRed = outlineColor.R;
            this.outlineGreen = outlineColor.G;
            this.outlineBlue = outlineColor.B;
            this.outlineWidth = olWidth;

            this.glowAlpha = glowColor.A;
            this.glowRed = glowColor.R;
            this.glowGreen = glowColor.G;
            this.glowBlue = glowColor.B;
        }

        
        //文字
        public string text { get; set; }
        //文字样式
        public string family { get; set; }
        //文字尺寸
        public float size { get; set; }
        //文字位置
        public Point point { get; set; }

        //前景色 ARGB
        public int foreAlpha { get; set; }
        public int foreRed { get; set; }
        public int foreGreen { get; set; }
        public int foreBlue { get; set; }

        //描边 ARGB 如果alpha =0代表不使用描边效果
        public int outlineAlpha { get; set; }
        public int outlineRed { get; set; }
        public int outlineGreen { get; set; }
        public int outlineBlue { get; set; }
        //描边 宽度 如果宽度等于0代表不使用描边效果
        public int outlineWidth { get; set; }

        //光晕 ARGB 如果alpha =0那么表示不使用光晕效果
        public int glowAlpha { get; set; }
        public int glowRed { get; set; }
        public int glowGreen { get; set; }
        public int glowBlue { get; set; }

    }
}
