using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace SignatureBuilder.Datas
{
    public class CheckVersion
    {
        public CheckVersion() 
        {
            WebClient wb = new WebClient();
            wb.Credentials = CredentialCache.DefaultCredentials;
            Byte[] data = wb.DownloadData("http://lol.qq.com/download.shtml");
            string html = Encoding.Default.GetString(data);
            Regex regVersion = new Regex("(?s)<p class=\"downinfo\">当前版本：v(.*?) | 更新日期：.*</p><ul class=\"ofh zm\">");
            Match mcVersion = regVersion.Match(html);
            this.version = "V" + mcVersion.Groups[1].Value;
            Utils.FileOperate fo = new Utils.FileOperate();
            string gameVersion = fo.GetGameVersion();
            if (this.version.Equals(gameVersion))
            {
                this.isNewVersion = true;
            }
            else 
            {
                this.isNewVersion = false;
            }
        }

        public string version { get; set; }
        public bool isNewVersion { get; set; }
    }
}
