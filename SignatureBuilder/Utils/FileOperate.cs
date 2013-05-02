using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignatureBuilder.Models;


namespace SignatureBuilder.Utils
{
    public class FileOperate
    {
        XMLConfig xmlconfig = new XMLConfig();

        public string GetGameConfigPath()
        {
            string client = xmlconfig.LoLFilepath;
            string config = client.Substring(0, client.LastIndexOf("\\") - 4);
            config += "\\Game\\Config\\game.cfg";
            return config;
        }

        public string GetGameLoginPath()
        {
            string client = xmlconfig.LoLFilepath;
            string loginConfig = client.Substring(0, client.LastIndexOf("\\") - 4);
            loginConfig += "\\TCLS\\config\\LoginQ.dat";
            return loginConfig;
        }

        public string GetAirChampionPortrait(Champion champion)
        {
            string client = xmlconfig.LoLFilepath;
            string championPortrait = client.Substring(0, client.LastIndexOf("\\") - 4);
            championPortrait += "Air\\assets\\images\\champions\\" + champion.EnName + "_Square_0.png";
            return championPortrait;
        }

        public string GetAirChampionSkinPath(Skin skin, Champion champion)
        {
            string client = xmlconfig.LoLFilepath;
            string skinPath = client.Substring(0, client.LastIndexOf("\\") - 4);
            skinPath += "Air\\assets\\images\\champions\\" + champion.EnName + "_Splash_" + skin.pathIndex + ".jpg";
            return skinPath;
        }

        public string GetAirChampionSkinPath(int id, Champion champion)
        {
            string client = xmlconfig.LoLFilepath;
            string skinPath = client.Substring(0, client.LastIndexOf("\\") - 4);
            skinPath += "Air\\assets\\images\\champions\\" + champion.EnName + "_Splash_" + id + ".jpg";
            return skinPath;
        }

        public string GetAirChampionSkinPreviewPath(Skin skin, Champion champion)
        {
            string client = xmlconfig.LoLFilepath;
            string skinPreviewPath = client.Substring(0, client.LastIndexOf("\\") - 4);
            skinPreviewPath += "Air\\assets\\images\\champions\\" + champion.EnName + "_" + skin.pathIndex + ".jpg";
            return skinPreviewPath;
        }

        public string GetAirChampionSkinPreviewPath(int id, Champion champion)
        {
            string client = xmlconfig.LoLFilepath;
            string skinPreviewPath = client.Substring(0, client.LastIndexOf("\\") - 4);
            skinPreviewPath += "Air\\assets\\images\\champions\\" + champion.EnName + "_" + id + ".jpg";
            return skinPreviewPath;
        }

        public string GetLastLoginMasterName() 
        {
            string masterName = "";
            string client = xmlconfig.LoLFilepath;
            string preferencesPath = client.Substring(0, client.LastIndexOf("\\") - 4);
            preferencesPath += "Air\\preferences\\";
            if (!Directory.Exists(preferencesPath))
            {
                masterName = "召唤师";
            }
            else 
            { 
                DirectoryInfo folder = new DirectoryInfo(preferencesPath);
                List<FileInfo> files = folder.GetFiles().OrderBy(x => x.LastWriteTime).ToList();
                if (files.Last().Name.Contains("shared_")) 
                {
                    files.Remove(files.Last());
                }
                
                string result = files.Last().Name;
                //string result = folder.GetFiles().OrderBy(x => x.LastWriteTime).Last().Name;
                int startIndex = (result.IndexOf("_") + 1) == -1 ? 0 : result.IndexOf("_") + 1;
                result = result.Substring(startIndex, result.IndexOf("."));
                masterName = result;
            }
            
            return masterName;
        }

        public string  GetLastIndexFile(string path,string key) 
        {
            int index = 1;
            string result = "";
            DirectoryInfo folder = new DirectoryInfo(path);

            List<FileInfo> files = new List<FileInfo>();
            foreach (FileInfo file in folder.GetFiles()) 
            {
                string championName = null;
                try
                {
                    championName = file.Name.Substring(0, file.Name.IndexOf("_"));
                    if (championName != null) 
                    {
                        if (championName.Equals(key))
                        {
                            files.Add(file);
                        }
                    }
                }
                catch 
                {
                    continue;
                }
                finally 
                {
                  
                }
               
            }
            if (files.Count > 0)
            {
                string finalIndex = files.OrderBy(x => x.LastWriteTime).Last().Name;
                string newIndex = finalIndex.Substring(finalIndex.IndexOf("_") + 1, 2);
                index = Convert.ToInt32(newIndex) + 1;
            }
            if (index < 10)
            {
                result = "0" + index.ToString();
            }
            else 
            {
                result = index.ToString();
            }

            return result.ToString();
        }

        public string GetSpellPath() 
        {
            string client = xmlconfig.LoLFilepath;
            string spell = client.Substring(0, client.LastIndexOf("\\") - 4);
            //spell += "Air\\assets\\images\\championScreens\\abilities\\";
            spell += "Air\\assets\\images\\abilities\\";
            return spell;
        }

        public string GetGameVersion() 
        {
            string version = "";
            string client = xmlconfig.LoLFilepath;
            string parentPath = client.Substring(0, client.LastIndexOf("\\") - 4);
            parentPath += "data.ini";
            INIConfig ini = new INIConfig(parentPath);
            version = ini.GetSectionKey_StringValue("TCLS", "version", "");
            return version;
        }
    }
}
