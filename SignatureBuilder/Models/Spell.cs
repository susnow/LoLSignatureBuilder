using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureBuilder.Models
{
    public class Spell
    {
        public Spell(string pname, string skey) 
        { 
            //this.championId = cid;
            this.pathName = pname;
            this.shortKey = skey;
        }

        //public Champion championId { get; set; }
        public string pathName { get; set; }
        public string shortKey { get; set; }
    }
}
