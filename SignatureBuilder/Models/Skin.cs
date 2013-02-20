using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureBuilder.Models
{
    public class Skin
    {
        public Skin(Champion cid, int pid,  string ename,string cname) 
        {
            this.championId = cid;
            this.pathIndex = pid;
            this.CnName = cname;
            this.EnName = ename;
        }

        public Champion championId { get; set; }
        public int pathIndex { get; set; }
        public string EnName { get; set; }
        public string CnName { get; set; }
    }
}
