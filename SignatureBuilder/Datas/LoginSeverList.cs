using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignatureBuilder.Models;
namespace SignatureBuilder.Datas
{
    public class LoginSeverList
    {
        private List<LoginSever> lsList = new List<LoginSever>();

        public LoginSeverList()
        {
            lsList.Clear();


            lsList.Add(new LoginSever(257, "艾欧尼亚","电信一"));
            lsList.Add(new LoginSever(1025, "班德尔城","电信四"));
            lsList.Add(new LoginSever(2817, "黑色玫瑰","电信十"));
            lsList.Add(new LoginSever(2305, "裁决之地","电信九"));
            lsList.Add(new LoginSever(2049, "雷瑟守备","电信八"));
            lsList.Add(new LoginSever(1793, "巨神峰","电信七"));
            lsList.Add(new LoginSever(1537, "战争学院","电信六"));
            lsList.Add(new LoginSever(1282, "恕瑞玛","网通五"));
            lsList.Add(new LoginSever(1281, "皮尔特沃夫","电信五"));
            lsList.Add(new LoginSever(1026, "无畏先锋","网通四"));
            lsList.Add(new LoginSever(770, "费雷尔卓德","网通三"));
            lsList.Add(new LoginSever(769, "诺克萨斯","电信三"));
            lsList.Add(new LoginSever(514, "德玛西亚","网通二"));
            lsList.Add(new LoginSever(513, "祖安","电信二"));
            lsList.Add(new LoginSever(258, "比尔吉沃特","网通一"));
            lsList.Add(new LoginSever(3585, "均衡教派","电信十三"));
            lsList.Add(new LoginSever(3329, "水晶之痕","电信十四"));
            lsList.Add(new LoginSever(3073, "钢铁烈阳","电信十二"));
            lsList.Add(new LoginSever(65539, "教育网专区","教育一"));
            lsList.Add(new LoginSever(3841, "影流","电信十五"));
            lsList.Add(new LoginSever(4097, "守望之海", "电信十六"));
            lsList.Add(new LoginSever(1538, "扭曲丛林", "网通六"));
            lsList.Add(new LoginSever(4353, "征服之海", "电信十七"));

        }

        public List<LoginSever> GetSeverList()
        {
            return lsList;
        }

        public string GetSeverDataById(string sname) 
        {
            string dname = "电信一";
            List<LoginSever> list = GetSeverList();
            for (int i = 0; i < list.Count; i++) 
            {
                if (sname == list[i].sName) 
                {
                    dname = list[i].dataName;
                    return dname;
                }
            }
            return dname;
        }
        
    }
}
