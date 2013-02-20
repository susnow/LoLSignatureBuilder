using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureBuilder.Models
{
    public class Champion
    {
        public string EnName { get; set; }
        public string CnName { get; set; }
        public string DefaultName { get; set; }
        public string Portrait { get; set; }
        public List<string> ShortName { get; set; }
        public List<string> Tags { get; set; }
        public List<Skin> Skins { get; set; }
        public List<Spell> Spells { get; set; }

    }
}
