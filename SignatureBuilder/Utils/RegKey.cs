using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace SignatureBuilder.Utils
{
    public class RegKey
    {
        public string client = "";
        private bool regkeyExist()
        {
            bool _exist = false;
            object obj = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Tencent\LOL", "setup", null);
            if (obj == null)
            {
                _exist = false;
                return _exist;
            }
            else
            {
                _exist = true;
                return _exist;
            }

            //return _exist;
        }

        public RegKey()
        {
            bool _exist = regkeyExist();
            if (_exist)
            {
                client = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Tencent\LOL", "setup", null).ToString();
            }
            else
            {
                client = "";
            }
        }

    }
}
