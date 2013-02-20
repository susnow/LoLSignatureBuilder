using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace SignatureBuilder.Datas
{
    public class WebDatas
    {
        public WebDatas(string severName, string summorName)
        {
            WebClient wb = new WebClient();
            wb.Credentials = CredentialCache.DefaultCredentials;
            Byte[] data = wb.DownloadData("http://lolbox.duowan.com/playerDetail.php?serverName=" + severName + "&playerName=" + summorName);
            string html = Encoding.UTF8.GetString(data);
            Regex regFight = new Regex(@"(?s)<p><em><span title=.*?>(\d*)</span></em></p>");
            Match mcFight = regFight.Match(html);
            this.Fight = mcFight.Groups[1].Value == "0" ? "无" : mcFight.Groups[1].Value;

            Regex regSolo = new Regex(@"(?m)<td>5v5单人</td>[\s\S]*?<td>(\d*)</td>");
            Match mcSolo = regSolo.Match(html);
            this.SoloRank = mcSolo.Groups[1].Value == "" ? "无" : mcSolo.Groups[1].Value;

            Regex regTeam = new Regex(@"(?m)<td>5v5组队</td>[\s\S]*?<td>(\d*)</td>");
            Match mcTeam = regTeam.Match(html);
            this.TeamRank = mcTeam.Groups[1].Value == "" ? "无" : mcTeam.Groups[1].Value;
        }

        
        public string Fight { get; set; }
        public string SoloRank { get; set; }
        public string TeamRank { get; set; }

    }
}
