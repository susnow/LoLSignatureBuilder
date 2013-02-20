using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SignatureBuilder.Utils
{
    public class INIConfig
    {
        [DllImport("kernel32")]
        private static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retValue, int size, string filePath);

        public string filePath;

        //构造函数
        public INIConfig(string path)
        {
            filePath = path;
        }


        //写操作
        public void EditSectionKey_StringValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, filePath);
        }

        public void EditSectionKey_IntValue(string section, string key, int value)
        {
            WritePrivateProfileString(section, key, value.ToString(), filePath);
        }

        public void EditSectionKey_BoolValue(string section, string key, bool value)
        {
            WritePrivateProfileString(section, key, Convert.ToString(value), filePath);
        }


        //读操作
        public string GetSectionKey_StringValue(string section, string key, string value)
        {
            StringBuilder sb = new StringBuilder(500);
            Byte[] Buffer = new Byte[65535];
            int bufLen = GetPrivateProfileString(section, key, value, Buffer, Buffer.GetUpperBound(0), filePath);
            string s = Encoding.GetEncoding(0).GetString(Buffer);
            s = s.Substring(0, bufLen);
            return s.Trim();
        }

        public int GetSectionKey_IntValue(string section, string key, int value)
        {
            string intStr = GetSectionKey_StringValue(section, key, value.ToString());
            try
            {
                return Convert.ToInt32(intStr);
            }
            catch
            {
                //throw ex.InnerException;
                return value;
            }
        }

        public bool GetSectionKey_BoolValue(string section, string key, bool value)
        {
            try
            {
                return Convert.ToBoolean(GetSectionKey_StringValue(section, key, value.ToString()));
            }
            catch
            {
                return value;
            }
        }

        //删节点
        public void DeleteSection(string section)
        {
            WritePrivateProfileString(section, null, null, filePath);
        }

        //删除键
        public void DeletSection_Key(string section, string key)
        {
            WritePrivateProfileString(section, key, null, filePath);
        }

    }
}
