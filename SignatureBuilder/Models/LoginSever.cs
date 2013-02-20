using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureBuilder.Models
{
    public class LoginSever
    {
        public LoginSever(int sid, string sname,string dname)
        {
            this.sID = sid;
            this.sName = sname;
            this.dataName = dname;
        }
        public int sID { get; set; }
        public string sName { get; set; }
        public string dataName { get; set; }
    }
}
