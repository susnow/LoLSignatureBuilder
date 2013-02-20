using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignatureBuilder.Models;
using SignatureBuilder.Utils;


namespace SignatureBuilder.Datas
{
    public class ChampionList
    {
       
           private static Dictionary<string, Champion> getChampionList()
            {
                Dictionary<string, Champion> cList = new Dictionary<string, Champion>();
                FileOperate fo = new FileOperate();

                //阿狸 九尾妖狐
                Champion Ahri = new Champion();
                Ahri.EnName = "Ahri";
                Ahri.CnName = "阿狸";
                Ahri.DefaultName = "九尾妖狐";
                Ahri.Portrait = fo.GetAirChampionPortrait(Ahri);
                
                Ahri.ShortName = new List<string> { "狐狸", "狐女" };
                Ahri.Skins = new List<Skin> { 
                    new Skin(Ahri, 0,  "Classic", "经典"), 
                    new Skin(Ahri, 1, "Dynasty","高丽风情"),
                    new Skin(Ahri, 2, "Midnight","暗影妖狐"),
                    new Skin(Ahri, 3, "FireFox","焰尾妖狐"),
                };
                Ahri.Spells = new List<Spell>() {
                    new Spell("Ahri_OrbofDeception","q"),
                    new Spell("Ahri_FoxFire","w"),
                    new Spell("Ahri_Charm","e"),
                    new Spell("Ahri_SpiritRush","r"),
                    new Spell("Ahri_SoulEater","t"),
                };
               Ahri.Tags = new List<string>() { "远程", "法术", "刺客" };
               cList.Add(Ahri.EnName, Ahri);

                //阿卡丽 暗影之拳
                Champion Akali = new Champion();
                Akali.EnName = "Akali";
                Akali.CnName = "阿卡丽";
                Akali.DefaultName = "暗影之拳";
                Akali.Portrait = fo.GetAirChampionPortrait(Akali);
                
                Akali.ShortName = null;

                Akali.Skins = new List<Skin>() {
                    new Skin(Akali,0,"Classic","经典"),
                    new Skin(Akali,1,"Stinger","蜂刺"),
                    new Skin(Akali,2,"Crimson","绯红"),
                    new Skin(Akali,3,"All-Star","足球宝贝"),
                    new Skin(Akali,4,"Nurse","实习护士"),
                    new Skin(Akali,5,"Blood Moon","鬼舞姬"),
                    new Skin(Akali,6,"Silverfang","银色之牙"),
				};
                Akali.Spells = new List<Spell>() {
                    new Spell("AkaliMota","q"),
                    new Spell("AkaliTwilightShroud","w"),
                    new Spell("AkaliCrescentSlash","e"),
                    new Spell("AkaliShadowDance","r"),
                    new Spell("AkaliTwinDisciplines","t"),
                };
                Akali.Tags = new List<string>() { "近战", "法术", "刺客" };
                cList.Add(Akali.EnName, Akali);

                //阿利斯塔 牛头酋长 (牛头)
                Champion Alistar = new Champion();
                Alistar.EnName = "Alistar";
                Alistar.CnName = "阿利斯塔";
                Alistar.DefaultName = "牛头酋长";
                Alistar.Portrait = fo.GetAirChampionPortrait(Alistar);
                
                Alistar.ShortName = new List<string> { "牛头", "老牛" };
                Alistar.Skins = new List<Skin>() {
                    new Skin(Alistar,0,"Classic","经典"),
                    new Skin(Alistar,1,"Black","暗黑灵魂"),
                    new Skin(Alistar,2,"Golden","金牛座"),
                    new Skin(Alistar,3,"Matador","斗牛士"),
                    new Skin(Alistar,4,"Longhorn","荒野嫖客"),
                    new Skin(Alistar,5,"Unchained","巨角幻兽"),
                    new Skin(Alistar,6,"Infernal","地狱火"),
				};
                Alistar.Spells = new List<Spell>() {
                    new Spell("Minotaur_Pulverize","q"),
                    new Spell("Minotaur_Headbutt","w"),
                    new Spell("Minotaur_FerociousHowl","e"),
                    new Spell("Minotaur_DeepSniff","r"),
                    new Spell("Minotaur_ColossalStrength","t"),
                };
				Alistar.Tags = new List<string>() { "近战", "物理", "辅助", "打野", "坦克" };
				cList.Add(Alistar.EnName, Alistar);

				//阿木木
				Champion Amumu = new Champion();
				Amumu.EnName = "Amumu";
				Amumu.CnName = "阿木木";
				Amumu.DefaultName = "殇之木乃伊";
				Amumu.Portrait = fo.GetAirChampionPortrait(Amumu);

				Amumu.ShortName = new List<string> { "木木" };
				Amumu.Skins = new List<Skin>() { 
					new Skin(Amumu,0,"Classic","经典"),
					new Skin(Amumu,1,"Pharaoh","法老"),
					new Skin(Amumu,2,"Vancouver","狂欢"),
					new Skin(Amumu,3,"Emumu","摇滚情绪"),
					new Skin(Amumu,4,"Re-Gifted","主人不要我了"),
					new Skin(Amumu,5,"Almost-Prow-King","王子不是我"),
					new Skin(Amumu,6,"Little Knight","小小骑士"),
					new Skin(Amumu,7,"Sad Robot","殇之机器人"),
				};
                Amumu.Spells = new List<Spell>() {
                    new Spell("SadMummy_BandageFlinger","q"),
                    new Spell("SadMummy_AuraOfDespair","w"),
                    new Spell("SadMummy_Tantrum","e"),
                    new Spell("SadMummy_BandAidThingy","r"),
                    new Spell("SadMummy_CorpseExplosion","t"),
                };
				Amumu.Tags = new List<string>() { "近战", "法术", "打野", "坦克" };
				cList.Add(Amumu.EnName, Amumu);


				//艾尼维亚 冰晶凤凰 (凤凰)
				Champion Anivia = new Champion();
				Anivia.EnName = "Anivia";
				Anivia.CnName = "艾尼维亚";
				Anivia.DefaultName = "冰晶凤凰";
				Anivia.Portrait = fo.GetAirChampionPortrait(Anivia);

				Anivia.ShortName = new List<string> { "凤凰", "冰鸟" };
				Anivia.Skins = new List<Skin>() {
					new Skin(Anivia,0,"Classic","经典"),
					new Skin(Anivia,1,"Team Spilit","双重冰晶"),
					new Skin(Anivia,2,"Bird of Prey","联盟之喙"),
					new Skin(Anivia,3,"Noxus Hunter","重甲猎鹰"),
					new Skin(Anivia,4,"Hextech","海克斯科技"),
				};
                Anivia.Spells = new List<Spell>() {
                    new Spell("Cryophoenix_FrigidOrb","q"),
                    new Spell("Cryophoenix_Crystallize","w"),
                    new Spell("Cryophoenix_DeepFreeze","e"),
                    new Spell("Cryophoenix_GlacialStorm","r"),
                    new Spell("Cryophoenix_Rebirth","t"),
                };
				Anivia.Tags = new List<string>() { "远程", "法术", "推进" };
				cList.Add(Anivia.EnName, Anivia);

				//安妮 黑暗之女
				Champion Annie = new Champion();
				Annie.EnName = "Annie";
				Annie.CnName = "安妮";
				Annie.DefaultName = "黑暗之女";
				Annie.Portrait = fo.GetAirChampionPortrait(Annie);

				Annie.ShortName = new List<string> { "火女" };
				Annie.Skins = new List<Skin>() {
					new Skin(Annie,0,"Classic","经典"),
					new Skin(Annie,1,"Goth","哥特萝莉"),
					new Skin(Annie,2,"Red Riding","小红帽"),
					new Skin(Annie,3,"Annie in Wonderland","梦游仙境"),
					new Skin(Annie,4,"Prow Queen","舞会公主"),
					new Skin(Annie,5,"Frostfire","冰霜烈焰"),
					new Skin(Annie,6,"Reverse","反宠为主"),
					new Skin(Annie,7,"Frankentibbers","科学怪熊的新娘"),
                    new Skin(Annie,8,"","你看见过我的熊猫吗"),
				};
                Annie.Spells = new List<Spell>() { 
                    new Spell("Annie_Disintegrate","q"),
                    new Spell("Annie_Incinerate","w"),
                    new Spell("Annie_GhastlyShield","e"),
                    new Spell("Annie_GuardianIncinerate","r"),
                    new Spell("Annie_Brilliance","t"),
                };
				Annie.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Annie.EnName, Annie);

				//艾希 寒冰射手 
				Champion Ashe = new Champion();
				Ashe.EnName = "Ashe";
				Ashe.CnName = "艾希";
				Ashe.DefaultName = "寒冰射手";
				Ashe.Portrait = fo.GetAirChampionPortrait(Ashe);

				Ashe.ShortName = new List<string> { "冰弓", "寒冰", "爱射" };
				Ashe.Skins = new List<Skin>() {
					new Skin(Ashe,0,"Classic","经典"),
					new Skin(Ashe,1,"Freljord","极地女神"),
					new Skin(Ashe,2,"Sherwood Forest","丛林侠盗"),
					new Skin(Ashe,3,"Woad","暗夜精灵"),
					new Skin(Ashe,4,"Queen","女皇"),
					new Skin(Ashe,5,"Amethyst","紫晶射手"),
				};
                Ashe.Spells = new List<Spell>() {
                    new Spell("Bowmaster_IceArrow","q"),
                    new Spell("Bowmaster_Volley","w"),
                    new Spell("Bowmaster_Hawkshot","e"),
                    new Spell("Bowmaster_EnchantedArrow","r"),
                    new Spell("Bowmaster_BullsEye","t"),
                };
				Ashe.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Ashe.EnName, Ashe);


				//布里茨 蒸汽机器人
				Champion Blitzcrank = new Champion();
				Blitzcrank.EnName = "Blitzcrank";
				Blitzcrank.CnName = "布里茨";
				Blitzcrank.DefaultName = "蒸汽机器人";
				Blitzcrank.Portrait = fo.GetAirChampionPortrait(Blitzcrank);

				Blitzcrank.ShortName = new List<string> { "机器人" };
				Blitzcrank.Skins = new List<Skin>() {
					new Skin(Blitzcrank,0,"Classic","经典"),
					new Skin(Blitzcrank,1,"Rusty","铁锈斑斑"),
					new Skin(Blitzcrank,2,"Goalkeeper","钢铁之门"),
					new Skin(Blitzcrank,3,"Boom Boom","擂台皇帝"),
					new Skin(Blitzcrank,4,"Piltover Customs","陆地王者4WD"),
					new Skin(Blitzcrank,5,"Definitely","戴一个表"),
				};
                Blitzcrank.Spells = new List<Spell>() {
                    new Spell("Blitzcrank_RocketGrab","q"),
                    new Spell("Blitzcrank_Overdrive","w"),
                    new Spell("Blitzcrank_PowerFist","e"),
                    new Spell("Blitzcrank_StaticField","r"),
                    new Spell("Blitzcrank_ManaBarrier","t"),
                };
				Blitzcrank.Tags = new List<string>() { "近战", "物理", "辅助", "坦克" };
				cList.Add(Blitzcrank.EnName, Blitzcrank);


				//布兰德 复仇烈焰
				Champion Brand = new Champion();
				Brand.EnName = "Brand";
				Brand.CnName = "布兰德";
				Brand.DefaultName = "复仇烈焰";
				Brand.Portrait = fo.GetAirChampionPortrait(Brand);

				Brand.ShortName = new List<string> { "火人", "火男" };
				Brand.Skins = new List<Skin>() 
				{
					new Skin(Brand,0,"Classic","经典"),
					new Skin(Brand,1,"Apocalyptic","末日余生"),
					new Skin(Brand,2,"Vandal","V字仇杀者"),
					new Skin(Brand,3,"Cryocore","冰晶之核"),
					new Skin(Brand,4,"Zombie","僵尸"),
				};
                Brand.Spells = new List<Spell>() { 
                    new Spell("BrandSear","q"),
                    new Spell("BrandPillarOfFlame","w"),
                    new Spell("BrandConflagration","e"),
                    new Spell("BrandPyroclasm","r"),
                    new Spell("BrandBlaze","t"),
                };
				Brand.Tags = new List<string>() { "远程", "法术", "推进" };
				cList.Add(Brand.EnName, Brand);

				//凯特琳 皮城女警
				Champion Caitlyn = new Champion();
				Caitlyn.EnName = "Caitlyn";
				Caitlyn.CnName = "凯特琳";
				Caitlyn.DefaultName = "皮城女警";
				Caitlyn.Portrait = fo.GetAirChampionPortrait(Caitlyn);

				Caitlyn.ShortName = new List<string> { "皮城", "女警" };
				Caitlyn.Skins = new List<Skin>() {
					new Skin(Caitlyn,0,"Classic","经典"),
					new Skin(Caitlyn,1,"Resistance","抵抗军天使"),
					new Skin(Caitlyn,2,"Sheriff","荒野治安官"),
					new Skin(Caitlyn,3,"Safari","古墓丽影"),
					new Skin(Caitlyn,4,"Arctic Warfare","自由战士"),
					new Skin(Caitlyn,5,"Officer","女警狙击"),
				};
                Caitlyn.Spells = new List<Spell>() { 
                    new Spell ("Caitlyn_PiltoverPeacemaker","q"),
                    new Spell ("Caitlyn_YordleSnapTrap","w"),
                    new Spell ("Caitlyn_90CaliberNet","e"),
                    new Spell ("Caitlyn_AceintheHole","r"),
                    new Spell ("Caitlyn_Headshot","t"),
                };
				Caitlyn.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Caitlyn.EnName, Caitlyn);

				//卡西奥佩娅 魔蛇之拥
				Champion Cassiopeia = new Champion();
				Cassiopeia.EnName = "Cassiopeia";
				Cassiopeia.CnName = "卡西奥佩娅";
				Cassiopeia.DefaultName = "魔蛇之拥";
				Cassiopeia.Portrait = fo.GetAirChampionPortrait(Cassiopeia);

				Cassiopeia.ShortName = new List<string> { "蛇女" };
				Cassiopeia.Skins = new List<Skin>() {
					new Skin(Cassiopeia,0,"Classic","经典"),
					new Skin(Cassiopeia,1,"Desperada","荒漠之咬"),
					new Skin(Cassiopeia,2,"Siren","深海妖姬"),
					new Skin(Cassiopeia,3,"Mythic","蛇发女妖"),
                    new Skin(Cassiopeia,4,"","碧玉之牙"),
				};
                Cassiopeia.Spells = new List<Spell>() {
                    new Spell ("Cassiopeia_NoxiousBlast","q"),
                    new Spell ("Cassiopeia_Miasma","w"),
                    new Spell ("Cassiopeia_TwinFang","e"),
                    new Spell ("Cassiopeia_PetrifyingGaze","r"),
                    new Spell ("Cassiopeia_DeadlyCadence","t"),
                };
				Cassiopeia.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Cassiopeia.EnName, Cassiopeia);

				//科加斯 虚空恐惧(大虫子)
				Champion Chogath = new Champion();
				Chogath.EnName = "Chogath";
				Chogath.CnName = "科加斯";
				Chogath.DefaultName = "虚空恐惧";
				Chogath.Portrait = fo.GetAirChampionPortrait(Chogath);

				Chogath.ShortName = new List<string> { "大虫子" };
				Chogath.Skins = new List<Skin>() {
					new Skin(Chogath,0,"Classic","经典"),
					new Skin(Chogath,1,"Nightmare","梦魇"),
					new Skin(Chogath,2,"Gentleman","绅士"),
					new Skin(Chogath,3,"Lock Ness","尼斯巨兽"),
					new Skin(Chogath,4,"Jurassio","侏罗纪化石"),
					new Skin(Chogath,5,"Battlecast Prime","战地机甲"),
				};
                Chogath.Spells = new List<Spell>() {
                    new Spell ("GreenTerror_SpikeSlam","q"),
					new Spell ("GreenTerror_FeralScream","w"),
					new Spell ("GreenTerror_ChitinousExoplates","e"),
					new Spell ("GreenTerror_Feast","r"),
					new Spell ("GreenTerror_TailSpike","t"),
                };
				Chogath.Tags = new List<string>() { "近战", "物理", "打野", "坦克" };
				cList.Add(Chogath.EnName, Chogath);


				//库奇 英勇投弹手(飞机)
				Champion Corki = new Champion();
				Corki.EnName = "Corki";
				Corki.CnName = "库奇";
				Corki.DefaultName = "英勇投弹手";
				Corki.Portrait = fo.GetAirChampionPortrait(Corki);

				Corki.ShortName = new List<string> { "飞机" };
				Corki.Skins = new List<Skin>() {
					new Skin(Corki,0,"Classic","经典"),
					new Skin(Corki,1,"UFO","外星装甲"),
					new Skin(Corki,2,"Ice Toboggen","雪橇速滑"),
					new Skin(Corki,3,"Red Baron","红色男爵"),
					new Skin(Corki,4,"Hot Rod","急速前进"),
					new Skin(Corki,5,"Urfrider","海牛骑士"),
                    new Skin(Corki,6,"","神龙之翼"),
				};
                Corki.Spells = new List<Spell>() {
                    new Spell ("Corki_PhosphorusBomb","q"),
					new Spell ("Corki_Valkyrie","w"),
					new Spell ("Corki_GatlingGun","e"),
					new Spell ("Corki_MissileBarrage","r"),
					new Spell ("Corki_RapidReload","t"),
                };
				Corki.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Corki.EnName, Corki);

				//德莱厄斯 诺克萨斯之手(断头台)
				Champion Darius = new Champion();
				Darius.EnName = "Darius";
				Darius.CnName = "德莱厄斯";
				Darius.DefaultName = "诺克萨斯之手";
				Darius.Portrait = fo.GetAirChampionPortrait(Darius);

				Darius.ShortName = new List<string> { "诺手", "断头台" };
				Darius.Skins = new List<Skin>() {
					new Skin(Darius,0,"Classic","经典"),
					new Skin(Darius,1,"Lord","铁血帝皇"),
                    new Skin(Darius,2,"Bioforge","生化骑士"),
				};
                Darius.Spells = new List<Spell>() {
                    new Spell ("Darius_Icon_Decimate","q"),
					new Spell ("Darius_Icon_Hamstring","w"),
					new Spell ("Darius_Icon_Axe_Grab","e"),
					new Spell ("Darius_Icon_Sudden_Death","r"),
					new Spell ("Darius_Icon_Hemorrhage","t"),
                };
				Darius.Tags = new List<string>() { "近战", "物理", "打野" };
				cList.Add(Darius.EnName, Darius);

				//戴安娜 皎月女神
				Champion Diana = new Champion();
				Diana.EnName = "Diana";
				Diana.CnName = "戴安娜";
				Diana.DefaultName = "皎月女神";
				Diana.Portrait = fo.GetAirChampionPortrait(Diana);

				Diana.ShortName = new List<string> { "皎月", "月女", "包大人" };
				Diana.Skins = new List<Skin>() { 
					new Skin(Diana,0,"Classic","经典"),
					new Skin(Diana,1,"Dark Valkyrie","暗黑女武神"),
				};
                Diana.Spells = new List<Spell>() {
                    new Spell ("Diana_Q_MoonsEdge","q"),
					new Spell ("Diana_W_LunarShower","w"),
					new Spell ("Diana_E_MoonFall","e"),
					new Spell ("Diana_R_FasterThanLight","r"),
					new Spell ("Diana_Passive_LunarBlade","t"),
                };
				Diana.Tags = new List<string>() { "近战", "法术", "打野", "推进" };
				cList.Add(Diana.EnName, Diana);

				//德莱文 荣耀行刑官
				Champion Draven = new Champion();
				Draven.EnName = "Draven";
				Draven.CnName = "德莱文";
				Draven.DefaultName = "荣耀行刑官";
				Draven.Portrait = fo.GetAirChampionPortrait(Draven);

				Draven.ShortName = new List<string> { "飞斧男", "杂技男" };
				Draven.Skins = new List<Skin>() {
					new Skin(Draven,0,"Classic","经典"),
					new Skin(Draven,1,"Soul Reaver","灵魂收割者"),
				};
                Draven.Spells = new List<Spell>() {
                    new Spell ("Draven_SpinningAxe","q"),
					new Spell ("Draven_Bloodrage","w"),
					new Spell ("Draven_TwinAxe","e"),
					new Spell ("Draven_WhirlingDeath","r"),
					new Spell ("Draven_passive","t"),
                };
				Draven.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Draven.EnName, Draven);


				//蒙多 祖安狂人
				Champion DrMundo = new Champion();
				DrMundo.EnName = "DrMundo";
				DrMundo.CnName = "蒙多";
				DrMundo.DefaultName = "祖安狂人";
				DrMundo.Portrait = fo.GetAirChampionPortrait(DrMundo);

				DrMundo.ShortName = new List<string> { "蒙多医生", "医生" };
				DrMundo.Skins = new List<Skin>() {
					new Skin(DrMundo,0,"Classic","经典"),
					new Skin(DrMundo,1,"Toxic","战栗之毒"),
					new Skin(DrMundo,2,"Mr. Mundoverse","健美教练"),
					new Skin(DrMundo,3,"Corporate","律政大亨"),
					new Skin(DrMundo,4,"Mundo","蒙多"),
					new Skin(DrMundo,5,"Executioner","嗜血行刑"),
					new Skin(DrMundo,6,"Rageborn","战争血统"),
				};
				DrMundo.Tags = new List<string>() { "近战", "物理", "打野", "坦克" };
                DrMundo.Spells = new List<Spell>() {
                    new Spell ("DrMundo_InfectedCleaver","q"),
                    new Spell("","w"),
                    new Spell("","e"),
                    new Spell ("DrMundo_Sadism","r"),
                    new Spell ("DrMundo_AdrenalineRush","t"),
                };
				cList.Add(DrMundo.EnName, DrMundo);

                //伊莉丝 蜘蛛女王
                Champion Elise = new Champion();
                Elise.EnName = "Elise";
                Elise.CnName = "伊莉丝";
                Elise.DefaultName = "蜘蛛女王";
                Elise.Portrait = fo.GetAirChampionPortrait(Elise);
                Elise.ShortName = new List<string> {"蜘蛛" };
                Elise.Skins = new List<Skin>() {
                    new Skin(Elise,0,"Classic","经典"),
                    new Skin(Elise,1,"Slide Shadow","死亡绽放"),
                };
                Elise.Tags = new List<string>() {"近战","远程","法术","打野" };
                Elise.Spells = new List<Spell>() {
                    new Spell ("EliseHumanQ","q"),
					new Spell ("EliseHumanW","w"),
					new Spell ("EliseHumanE","e"),
					new Spell ("EliseR","r"),
					new Spell ("ElisePassive","t"),
                };
                cList.Add(Elise.EnName, Elise);


				//伊芙琳 寡妇制造者
				Champion Evelynn = new Champion();
				Evelynn.EnName = "Evelynn";
				Evelynn.CnName = "伊芙琳";
				Evelynn.DefaultName = "寡妇制造者";
				Evelynn.Portrait = fo.GetAirChampionPortrait(Evelynn);

				Evelynn.ShortName = new List<string> { "寡妇", "EVE", "eve" };
				Evelynn.Skins = new List<Skin>() {
					new Skin(Evelynn,0,"Classic","经典"),
					new Skin(Evelynn,1,"Shadow","黑暗女王"),
					new Skin(Evelynn,2,"Masquerade","假面女皇"),
					new Skin(Evelynn,3,"Tango","探戈灵魂"),
				};
                Evelynn.Spells = new List<Spell>() {
                    new Spell ("Evelynn_OnlyHellToPay","q"),
					new Spell ("Evelynn_ReadyToBetray","w"),
					new Spell ("Evelynn_Ravage","e"),
					new Spell ("Evelynn_AgonysEmbrace","r"),
					new Spell ("Evelynn_ShadowWalk","t"),
                };
				Evelynn.Tags = new List<string>() { "近战", "法术", "打野", "刺客" };
				cList.Add(Evelynn.EnName, Evelynn);

				//伊泽瑞尔 探险家
				Champion Ezreal = new Champion();
				Ezreal.EnName = "Ezreal";
				Ezreal.CnName = "伊泽瑞尔";
				Ezreal.DefaultName = "探险家";
				Ezreal.Portrait = fo.GetAirChampionPortrait(Ezreal);

				Ezreal.ShortName = new List<string> { "EZ", "ez", "黄毛", "黄毛跳蚤", "跳蚤" };
				Ezreal.Skins = new List<Skin>() {
					new Skin(Ezreal,0,"Classic","经典"),
					new Skin(Ezreal,1,"Nottinghaw","冒险精神"),
					new Skin(Ezreal,2,"Striker","足球先生"),
					new Skin(Ezreal,3,"Frosted","冰川勇者"),
					new Skin(Ezreal,4,"Explorer","失落的世界"),
					new Skin(Ezreal,5,"Pulsefire","未来战士"),
				};
                Ezreal.Spells = new List<Spell>() {
                    new Spell ("Ezreal_MysticShot","q"),
					new Spell ("Ezreal_EssenceFlux","w"),
					new Spell ("Ezreal_ArcaneShift","e"),
					new Spell ("Ezreal_TrueshotBarrage","r"),
					new Spell ("Ezreal_RisingSpellForce","t"),
                };
				Ezreal.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Ezreal.EnName, Ezreal);

				//费德提克 末日使者
				Champion FiddleSticks = new Champion();
				FiddleSticks.EnName = "FiddleSticks";
				FiddleSticks.CnName = "费德提克";
				FiddleSticks.DefaultName = "末日行者";
				FiddleSticks.Portrait = fo.GetAirChampionPortrait(FiddleSticks);

				FiddleSticks.ShortName = new List<string> { "稻草人", "草人", "末日" };
				FiddleSticks.Skins = new List<Skin>() {
					new Skin(FiddleSticks,0,"Classic","经典"),
					new Skin(FiddleSticks,1,"Spectral","幽魂"),
					new Skin(FiddleSticks,2,"Union Jack","联合王国"),
					new Skin(FiddleSticks,3,"Bandito","荒野幽灵"),
					new Skin(FiddleSticks,4,"Pumpkinhead","南瓜头"),
					new Skin(FiddleSticks,5,"Fiddle Me Timbers","铁钩船长"),
					new Skin(FiddleSticks,6,"Suprise Party","惊悚派对"),
                    new Skin(FiddleSticks,7,"","糖果使徒"),
				};
				FiddleSticks.Tags = new List<string>() { "远程", "法术", "打野" };
                FiddleSticks.Spells = new List<Spell>() {
                    new Spell ("Fiddlesticks_Terrify","q"),
					new Spell ("Fiddlesticks_ConjureScarecrow","w"),
					new Spell ("Fiddlesticks_DarkWind","e"),
					new Spell ("Fiddlesticks_Crowstorm","r"),
					new Spell ("Fiddlesticks_Paranoia","t"),
                };
				cList.Add(FiddleSticks.EnName, FiddleSticks);

				//菲奥娜 无双剑姬
				Champion Fiora = new Champion();
				Fiora.EnName = "Fiora";
				Fiora.CnName = "菲奥娜";
				Fiora.DefaultName = "无双剑姬";
				Fiora.Portrait = fo.GetAirChampionPortrait(Fiora);

				Fiora.ShortName = new List<string> { "女剑", "无双", "剑姬" };
				Fiora.Skins = new List<Skin>() {
					new Skin(Fiora,0,"Classic","经典"),
					new Skin(Fiora,1,"Royal Guard","皇家守卫"),
					new Skin(Fiora,2,"Nightraven","夜鸦"),
				    new Skin(Fiora,3,"Headmistress","女校长"),
				};
                Fiora.Spells = new List<Spell>() {
					new Spell ("Fiora_Lunge","q"),
					new Spell ("Fiora_Parry","w"),
					new Spell ("Fiora_BurstofSpeed","e"),
					new Spell ("Fiora_DanceofDeath","r"),
					new Spell ("Fiora_Duelist","t"),
                };
				Fiora.Tags = new List<string>() { "近战", "物理" };
				cList.Add(Fiora.EnName, Fiora);


				//菲兹 潮汐海灵
				Champion Fizz = new Champion();
				Fizz.EnName = "Fizz";
				Fizz.CnName = "菲兹";
				Fizz.DefaultName = "潮汐海灵";
				Fizz.Portrait = fo.GetAirChampionPortrait(Fizz);

				Fizz.ShortName = new List<string> { "小鱼人", "凤姐" };
				Fizz.Skins = new List<Skin>() {
					new Skin(Fizz,0,"Classic","经典"),
					new Skin(Fizz,1,"Atlantean","失落的大陆"),
					new Skin(Fizz,2,"Tundra","苔原猎手"),
				};
                Fizz.Spells = new List<Spell>() {
                    new Spell ("FizzPiercingStrike","q"),
					new Spell ("FizzSeastonePassive","w"),
					new Spell ("FizzJump","e"),
					new Spell ("FizzMarinerDoom","r"),
					new Spell ("FizzPassive","t"),
                };
				Fizz.Tags = new List<string>() { "近战", "法术", "刺客" };
				cList.Add(Fizz.EnName, Fizz);


				//加里奥 哨兵之殇
				Champion Galio = new Champion();
				Galio.EnName = "Galio";
				Galio.CnName = "加里奥";
				Galio.DefaultName = "哨兵之殇";
				Galio.Portrait = fo.GetAirChampionPortrait(Galio);

				Galio.ShortName = new List<string> { "加料", "烧饼", "哨兵" };
				Galio.Skins = new List<Skin>() {
					new Skin(Galio,0,"Classic","经典"),
					new Skin(Galio,1,"Enchanted","幽蓝梦魇"),
					new Skin(Galio,2,"Hextech","机械迷城"),
					new Skin(Galio,3,"Commando","战地之王"),
					new Skin(Galio,4,"Gatekeeper","地狱守门人"),
				};
                Galio.Spells = new List<Spell>() {
                    new Spell ("Galio_ResoluteSmite","q"),
					new Spell ("Galio_Bulwark","w"),
					new Spell ("Galio_RighteousGust","e"),
					new Spell ("Galio_IdolOfDurand","r"),
					new Spell ("Galio_RunicSkin","t"),
                };
				Galio.Tags = new List<string>() { "近战", "法术", "坦克" };
				cList.Add(Galio.EnName, Galio);

				//普朗克 海洋之灾
				Champion Gangplank = new Champion();
				Gangplank.EnName = "Gangplank";
				Gangplank.CnName = "普朗克";
				Gangplank.DefaultName = "海洋之灾";
				Gangplank.Portrait = fo.GetAirChampionPortrait(Gangplank);

				Gangplank.ShortName = new List<string> { "船长" };
				Gangplank.Skins = new List<Skin>() {
					new Skin(Gangplank,0,"Classic","经典"),
					new Skin(Gangplank,1,"Spooky","幽灵船长"),
					new Skin(Gangplank,2,"Minuteman","老兵"),
					new Skin(Gangplank,3,"Sailor","大力水手"),
					new Skin(Gangplank,4,"Toy Soldier","英勇玩具兵"),
					new Skin(Gangplank,5,"Special Forces","特种部队"),
				};
                Gangplank.Spells = new List<Spell>() {
                    new Spell ("Pirate_Parley","q"),
					new Spell ("Pirate_RemoveScurvy","w"),
					new Spell ("Pirate_RaiseMorale","e"),
					new Spell ("Pirate_CannonBarrage","r"),
					new Spell ("Pirate_GrogSoakedBlade","t"),
                };
				Gangplank.Tags = new List<string>() { "近战", "物理" };
				cList.Add(Gangplank.EnName, Gangplank);


				//盖伦 德玛西亚之力
				Champion Garen = new Champion();
				Garen.EnName = "Garen";
				Garen.CnName = "盖伦";
				Garen.DefaultName = "德玛西亚之力";
				Garen.Portrait = fo.GetAirChampionPortrait(Garen);

				Garen.ShortName = new List<string> { "gay伦", "Gay伦", "草丛伦", "德玛", "德玛西亚" };
				Garen.Skins = new List<Skin>() {
					new Skin(Garen,0,"Classic","经典"),
					new Skin(Garen,1,"Sanguine","战神阿瑞斯"),
					new Skin(Garen,2,"Desert Trooper","黄金骑士"),
					new Skin(Garen,3,"Commando","铁甲雄心"),
					new Skin(Garen,4,"Dreadknight","死亡骑士"),
					new Skin(Garen,5,"Rugged","孤高游侠"),
				};
                Garen.Spells = new List<Spell>() {
                    new Spell ("Garen_DecisiveStrike","q"),
					new Spell ("Garen_CommandingPresence","w"),
					new Spell ("Garen_KeepingthePeace","e"),
					new Spell ("Garen_Justice","r"),
					new Spell ("Garen_Perseverance","t"),
                };
				Garen.Tags = new List<string>() { "近战", "物理", "辅助", "坦克" };
				cList.Add(Garen.EnName, Garen);

				//古拉加斯 酒桶
				Champion Gragas = new Champion();
				Gragas.EnName = "Gragas";
				Gragas.CnName = "古拉加斯";
				Gragas.DefaultName = "酒桶";
				Gragas.Portrait = fo.GetAirChampionPortrait(Gragas);

				Gragas.ShortName = null;
				Gragas.Skins = new List<Skin>() {
					new Skin(Gragas,0,"Classic","经典"),
					new Skin(Gragas,1,"Souba","深潜蛙人"),
					new Skin(Gragas,2,"Hillbilly","乡村农夫"),
					new Skin(Gragas,3,"Santa","圣诞老人"),
					new Skin(Gragas,4,"Esg","品酒大师"),
					new Skin(Gragas,5,"Vandal","飞车暴走族"),
					new Skin(Gragas,6,"Oktoberfest","美酒节特使"),
				};
                Gragas.Spells = new List<Spell>() {
                    new Spell ("GragasBarrelRoll","q"),
					new Spell ("GragasDrunkenRage","w"),
					new Spell ("GragasBodySlam","e"),
					new Spell ("GragasExplosiveCask","r"),
					new Spell ("GragasPassiveHeal","t"),
                };
				Gragas.Tags = new List<string>() { "近战", "法术", "推进" };
				cList.Add(Gragas.EnName, Gragas);

				//格雷福斯 法外狂徒
				Champion Graves = new Champion();
				Graves.EnName = "Graves";
				Graves.CnName = "格雷福斯";
				Graves.DefaultName = "法外狂徒";
				Graves.Portrait = fo.GetAirChampionPortrait(Graves);

				Graves.ShortName = new List<string> { "男枪", "法外" };
				Graves.Skins = new List<Skin>() {
					new Skin(Graves,0,"Classic","经典"),
					new Skin(Graves,1,"Hired Gun","怒之炮火"),
					new Skin(Graves,2,"Jailbreak","杀出重围"),
					new Skin(Graves,3,"Mafia","黑帮教父"),
					new Skin(Graves,4,"Riot","防爆士兵"),
				};
                Graves.Spells = new List<Spell>() {
                    new Spell ("GravesBuckshot","q"),
					new Spell ("GravesSmokeGrenade","w"),
					new Spell ("GravesQuickDraw","e"),
					new Spell ("GravesHighNoon","r"),
					new Spell ("GravesTrueGrit","t"),
                };
				Graves.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Graves.EnName, Graves);

				//赫卡莱姆 战争之影(半人马)
				Champion Hecarim = new Champion();
				Hecarim.EnName = "Hecarim";
				Hecarim.CnName = "赫卡莱姆";
				Hecarim.DefaultName = "战争之影";
				Hecarim.Portrait = fo.GetAirChampionPortrait(Hecarim);

				Hecarim.ShortName = new List<string> { "人马", "半人马" };
				Hecarim.Skins = new List<Skin>() {
					new Skin(Hecarim,0,"Classic","经典"),
					new Skin(Hecarim,1,"Blood Knight","血色骑士"),
					new Skin(Hecarim,2,"Reaper","幽魂骑士"),
					new Skin(Hecarim,3,"Headless","南瓜头骑士"),
				};
                Hecarim.Spells = new List<Spell>() {
                    new Spell ("Hecarim_Rampage","q"),
					new Spell ("Hecarim_SpiritofDread","w"),
					new Spell ("Hecarim_DevastingCharge","e"),
					new Spell ("Hecarim_OnslaughtofShadows","r"),
					new Spell ("Hecarim_Passive","t"),
                };
				Hecarim.Tags = new List<string>() { "近战", "物理", "打野" };
				cList.Add(Hecarim.EnName, Hecarim);

				//黑默丁格 大发明家
				Champion Heimerdinger = new Champion();
				Heimerdinger.EnName = "Heimerdinger";
				Heimerdinger.CnName = "黑默丁格";
				Heimerdinger.DefaultName = "大发明家";
				Heimerdinger.Portrait = fo.GetAirChampionPortrait(Heimerdinger);

				Heimerdinger.ShortName = new List<string> { "大头" };
				Heimerdinger.Skins = new List<Skin>() {
					new Skin(Heimerdinger,0,"Classic","经典"),
					new Skin(Heimerdinger,1,"Alien Invader","第三类接触"),
					new Skin(Heimerdinger,2,"Blast Zone","拆弹专家"),
					new Skin(Heimerdinger,3,"Piltover","创意工坊"),
					new Skin(Heimerdinger,4,"Snowmerdinger","雪默丁格"),
				};
                Heimerdinger.Spells = new List<Spell>() {
                    new Spell ("Heimerdinger_H28GEvolutionTurret","q"),
					new Spell ("Heimerdinger_HextechMicroRockets","w"),
					new Spell ("Heimerdinger_CH1ConcussionGrenade","e"),
					new Spell ("Heimerdinger_UPGRADE","r"),
					new Spell ("Heimerdinger_TechmaturgicalRepairBots","t"),
                };
				Heimerdinger.Tags = new List<string>() { "远程", "法术", };
				cList.Add(Heimerdinger.EnName, Heimerdinger);

				//艾瑞莉娅 刀锋意志
				Champion Irelia = new Champion();
				Irelia.EnName = "Irelia";
				Irelia.CnName = "艾瑞莉娅";
				Irelia.DefaultName = "刀锋意志";
				Irelia.Portrait = fo.GetAirChampionPortrait(Irelia);

				Irelia.ShortName = new List<string> { "女刀", "刀锋", "刀妹" };
				Irelia.Skins = new List<Skin>() {
					new Skin(Irelia,0,"Classic","经典"),
					new Skin(Irelia,1,"Nightblad","夜刃"),
					new Skin(Irelia,2,"Aviator","自由之翼"),
					new Skin(Irelia,3,"Infiltrator","夜行义贼"),
					new Skin(Irelia,4,"Frostblade","冰霜之刃"),
				};
                Irelia.Spells = new List<Spell>() {
                    new Spell ("Irelia_Bladesurge","q"),
					new Spell ("Irelia_HitenStyle","w"),
					new Spell ("Irelia_EquilibriumStrike","e"),
					new Spell ("Irelia_TranscendentBlades","r"),
					new Spell ("Irelia_IonianFervor","t"),
                };
				Irelia.Tags = new List<string>() { "近战", "物理", "刺客" };
				cList.Add(Irelia.EnName, Irelia);

				//迦娜 风暴之怒
				Champion Janna = new Champion();
				Janna.EnName = "Janna";
				Janna.CnName = "迦娜";
				Janna.DefaultName = "风暴之怒";
				Janna.Portrait = fo.GetAirChampionPortrait(Janna);

				Janna.ShortName = new List<string> { "风女" };
				Janna.Skins = new List<Skin>() {
					new Skin(Janna,0,"Classic","经典"),
					new Skin(Janna,1,"Tempest","暴风女神"),
					new Skin(Janna,2,"Hextech","海克斯科技"),
					new Skin(Janna,3,"Frost Queen","寒冰女王"),
					new Skin(Janna,4,"Victorious","胜利女神"),
				};
                Janna.Spells = new List<Spell>() {
                    new Spell ("Janna_HowlingGale","q"),
					new Spell ("Janna_Zephyr","w"),
					new Spell ("Janna_EyeOfTheStorm","e"),
					new Spell ("Janna_ReapTheWhirlwind","r"),
					new Spell ("Janna_Tailwind","t"),
                };
				Janna.Tags = new List<string>() { "远程", "法术", "辅助" };
				cList.Add(Janna.EnName, Janna);

				//嘉文四世 德玛西亚皇子
				Champion JarvanIV = new Champion();
				JarvanIV.EnName = "JarvanIV";
				JarvanIV.CnName = "嘉文四世";
				JarvanIV.DefaultName = "德玛西亚皇子";
				JarvanIV.Portrait = fo.GetAirChampionPortrait(JarvanIV);

				JarvanIV.ShortName = new List<string> { "嘉文", "皇子", "四阿哥", "周杰伦" };
				JarvanIV.Skins = new List<Skin>() {
					new Skin(JarvanIV,0,"Classic","经典"),
					new Skin(JarvanIV,1,"Commando","孤胆英豪"),
					new Skin(JarvanIV,2,"Dragon Slayer","屠龙勇士"),
					new Skin(JarvanIV,3,"Darkforge","龙骑统帅"),
					new Skin(JarvanIV,4,"Victorious","凯旋英雄"),
                    new Skin(JarvanIV,5,"","吕布 奉先"),
				};
                JarvanIV.Spells = new List<Spell>() {
                    new Spell ("JarvanIV_DragonStrike","q"),
					new Spell ("JarvanIV_GoldenAegis","w"),
					new Spell ("JarvanIV_DemacianStandard","e"),
					new Spell ("JarvanIV_Cataclysm","r"),
					new Spell ("JarvanIV_MartialCadence","t"),
                };
				JarvanIV.Tags = new List<string>() { "近战", "物理", "辅助", "打野" };
				cList.Add(JarvanIV.EnName, JarvanIV);


				//贾科斯 武器大师
				Champion Jax = new Champion();
				Jax.EnName = "Jax";
				Jax.CnName = "贾克斯";
				Jax.DefaultName = "武器大师";
				Jax.Portrait = fo.GetAirChampionPortrait(Jax);

				Jax.ShortName = new List<string> { "jax", "武器", "Jax" };
				Jax.Skins = new List<Skin>() {
					new Skin(Jax,0,"Classic","经典"),
					new Skin(Jax,1,"The Mighty","冰球队员"),
					new Skin(Jax,2,"Vandal","万夫莫开"),
					new Skin(Jax,3,"Angler","宗师级钓鱼训练师"),
					new Skin(Jax,4,"PAX","卧虎藏龙"),
					new Skin(Jax,5,"Jaximus","百夫长"),
					new Skin(Jax,6,"Temple","少林武僧"),
					new Skin(Jax,7,"Nemesis","复仇武神"),
				};
				Jax.Tags = new List<string>() { "近战", "物理", "打野" };
                Jax.Spells = new List<Spell>() {
                    new Spell("Armsmaster_RelentlessAssault","q"),
                    new Spell("Armsmaster_Empower","w"),
                    new Spell("Armsmaster_Disarm","e"),
                    new Spell("Armsmaster_CoupDeGrace","r"),
                    new Spell("Armsmaster_MasterOfArms","t"),
                };
                
				cList.Add(Jax.EnName, Jax);

				//杰斯 未来守护者
				Champion Jayce = new Champion();
				Jayce.EnName = "Jayce";
				Jayce.CnName = "杰斯";
				Jayce.DefaultName = "未来守护者";
				Jayce.Portrait = fo.GetAirChampionPortrait(Jayce);

				Jayce.ShortName = new List<string> { "基佬杰", "基佬" };
				Jayce.Skins = new List<Skin>() {
					new Skin(Jayce,0,"Classic","经典"),
					new Skin(Jayce,1,"Full Metal","全金属狂潮"),
				};
                Jayce.Spells = new List<Spell>() {
                    new Spell ("Jayce_ToTheSkies","q"),
					new Spell ("Jayce_StaticField","w"),
					new Spell ("Jayce_ThunderingBlow","e"),
					new Spell ("Jayce_TransformCannon","r"),
					new Spell ("JayceManOfTomorrow","t"),
                };
				Jayce.Tags = new List<string>() { "近战", "远程", "物理", "辅助" };
				cList.Add(Jayce.EnName, Jayce);

				//卡尔玛 天启者
				Champion Karma = new Champion();
				Karma.EnName = "Karma";
				Karma.CnName = "卡尔玛";
				Karma.DefaultName = "天启者";
				Karma.Portrait = fo.GetAirChampionPortrait(Karma);

				Karma.ShortName = new List<string> { "扇子妈" };
				Karma.Skins = new List<Skin>() { 
					new Skin(Karma,0,"Classic","经典"),
					new Skin(Karma,1,"Sun Goddess","日冕女神"),
					new Skin(Karma,2,"Sakura","樱花乱舞"),
				};
                Karma.Spells = new List<Spell>() {
                    new Spell ("KarmaHeavenlyWave","q"),
					new Spell ("KarmaSpiritBond","w"),
					new Spell ("KarmaSoulShield","e"),
					new Spell ("KarmaMantra","r"),
					new Spell ("KarmaInnerFlame","t"),
                };
				Karma.Tags = new List<string>() { "远程", "辅助", "法术" };
				cList.Add(Karma.EnName, Karma);

				//卡尔萨斯 死亡颂唱者
				Champion Karthus = new Champion();
				Karthus.EnName = "Karthus";
				Karthus.CnName = "卡尔萨斯";
				Karthus.DefaultName = "死亡颂唱者";
				Karthus.Portrait = fo.GetAirChampionPortrait(Karthus);

				Karthus.ShortName = new List<string> { "四哥", "死歌" };
				Karthus.Skins = new List<Skin>() {
					new Skin(Karthus,0,"Classic","经典"),
					new Skin(Karthus,1,"Phantom","幽灵幻影"),
					new Skin(Karthus,2,"Statue","自由女神"),
					new Skin(Karthus,3,"Grim Reaper","死神"),
					new Skin(Karthus,4,"Pentakill","五杀摇滚主唱"),
				};
                Karthus.Spells = new List<Spell>() {
                    new Spell ("Lich_LayWaste","q"),
					new Spell ("Lich_WallOfPain","w"),
					new Spell ("Lich_Defile","e"),
					new Spell ("Lich_DeathRay","r"),
					new Spell ("Lich_Defied","t"),
                };
				Karthus.Tags = new List<string>() { "远程", "法术", "推进" };
				cList.Add(Karthus.EnName, Karthus);


				//卡萨丁 虚空行者
				Champion Kassadin = new Champion();
				Kassadin.EnName = "Kassadin";
				Kassadin.CnName = "卡萨丁";
				Kassadin.DefaultName = "虚空行者";
				Kassadin.Portrait = fo.GetAirChampionPortrait(Kassadin);

				Kassadin.ShortName = new List<string> { "鸡巴脸", "J8脸" };
				Kassadin.Skins = new List<Skin>() {
					new Skin(Kassadin,0,"Classic","经典"),
					new Skin(Kassadin,1,"Festival","寒冰王座"),
					new Skin(Kassadin,2,"Deep One","深海一号"),
					new Skin(Kassadin,3,"Pre-Void","虚空前世"),
					new Skin(Kassadin,4,"Harbringer","先驱行者"),
				};
				Kassadin.Tags = new List<string>() { "近战", "法术", "刺客" };
                Kassadin.Spells = new List<Spell>() {
                    new Spell ("Averdrian_AstralBeam","q"),
					new Spell ("Voidwalker_Nullblade","w"),
					new Spell ("Kassadin_ForcePulse","e"),
					new Spell ("Voidwalker_Riftwalk","r"),
					new Spell ("Voidwalker_Netherburn","t"),
                };
				cList.Add(Kassadin.EnName, Kassadin);

				//卡特琳娜 不祥之刃
				Champion Katarina = new Champion();
				Katarina.EnName = "Katarina";
				Katarina.CnName = "卡特琳娜";
				Katarina.DefaultName = "不祥之刃";
				Katarina.Portrait = fo.GetAirChampionPortrait(Katarina);

				Katarina.ShortName = new List<string> { "卡特", "凯特", "kat", "不详" };
				Katarina.Skins = new List<Skin>() {
					new Skin(Katarina,0,"Classic","经典"),
					new Skin(Katarina,1,"Meroenary","赏金猎人"),
					new Skin(Katarina,2,"Red Card","红牌! 退场!"),
					new Skin(Katarina,3,"Bilgewater","海贼魅影"),
					new Skin(Katarina,4,"Kitty Cat","暗夜猫女"),
					new Skin(Katarina,5,"High Command","前线指挥官"),
					new Skin(Katarina,6,"Sandstorm","沙漠风暴"),
                    new Skin(Katarina,7,"","夺命美人"),
				};
                Katarina.Spells = new List<Spell>() {
                    new Spell ("Katarina_BouncingBlade","q"),
					new Spell ("Katarina_KillerInstincts","w"),
					new Spell ("Katarina_Shunpo","e"),
					new Spell ("Katarina_DeathLotus","r"),
					new Spell ("Katarina_Voracity","t"),
                };
				Katarina.Tags = new List<string>() { "近战", "法术", "刺客" };
				cList.Add(Katarina.EnName, Katarina);

				//凯尔 审判天使
				Champion Kayle = new Champion();
				Kayle.EnName = "Kayle";
				Kayle.CnName = "凯尔";
				Kayle.DefaultName = "审判天使";
				Kayle.Portrait = fo.GetAirChampionPortrait(Kayle);

				Kayle.ShortName = new List<string> { "天使" };
				Kayle.Skins = new List<Skin>() {
					new Skin(Kayle,0,"Classic","经典"),
					new Skin(Kayle,1,"Silver","银白审判"),
					new Skin(Kayle,2,"Viridian","末世天使"),
					new Skin(Kayle,3,"Unmasked","大天使长米迦勒"),
					new Skin(Kayle,4,"Battleborn","战场女武神"),
					new Skin(Kayle,5,"Judgement","圣光审判"),
                    new Skin(Kayle,6,"Wing","钢铁之翼"),
				};
                Kayle.Spells = new List<Spell>() {
                    new Spell ("Judicator_Reckoning","q"),
					new Spell ("Judicator_AngelicEmbrace","w"),
					new Spell ("Judicator_RighteousFury","e"),
					new Spell ("Judicator_EyeforanEye","r"),
					new Spell ("Judicator_DivineBlessing","t"),
                };
				Kayle.Tags = new List<string>() { "近战", "远程", "物理", "法术", "辅助", };
				cList.Add(Kayle.EnName, Kayle);

				//凯南 狂暴之心
				Champion Kennen = new Champion();
				Kennen.EnName = "Kennen";
				Kennen.CnName = "凯南";
				Kennen.DefaultName = "狂暴之心";
				Kennen.Portrait = fo.GetAirChampionPortrait(Kennen);

				Kennen.ShortName = new List<string> { "电耗子", "电猫" };
				Kennen.Skins = new List<Skin>() {
					new Skin(Kennen,0,"Classic","经典"),
					new Skin(Kennen,1,"Deadly","红色彗星"),
					new Skin(Kennen,2,"Swamp Master","银色闪电"),
					new Skin(Kennen,3,"Karate","空手道"),
					new Skin(Kennen,4,"M.D","医学博士"),
					new Skin(Kennen,5,"Arctic","刺客信条"),
				};
                Kennen.Spells = new List<Spell>() {
                    new Spell ("Kennen_ThunderingShuriken","q"),
					new Spell ("Kennen_ElectricalSurge","w"),
					new Spell ("Kennen_LightningRush","e"),
					new Spell ("Kennen_SlicingMaelstrom","r"),
					new Spell ("Kennen_MarkOfStorm","t"),
                };
				Kennen.Tags = new List<string>() { "远程", "法术", "物理" };
				cList.Add(Kennen.EnName, Kennen);

				//卡兹克 虚空掠食者
				Champion Khazix = new Champion();
				Khazix.EnName = "Khazix";
				Khazix.CnName = "卡'兹克";
				Khazix.DefaultName = "虚空掠食者";
				Khazix.Portrait = fo.GetAirChampionPortrait(Khazix);

				Khazix.ShortName = new List<string> { "螳螂", "飞天螳螂" };
				Khazix.Skins = new List<Skin>() {
					new Skin(Khazix,0,"Classic","经典"),
					new Skin(Khazix,1,"Mecha","霸天异型"),
				};
                Khazix.Spells = new List<Spell>() {
                    new Spell ("Khazix_Q","q"),
					new Spell ("Khazix_W","w"),
					new Spell ("Khazix_E","e"),
					new Spell ("Khazix_R","r"),
					new Spell ("Khazix_P","t"),
                };
				Khazix.Tags = new List<string>() { "近战", "物理", "打野" };
				cList.Add(Khazix.EnName, Khazix);

				//克格莫 深渊之首
				Champion KogMaw = new Champion();
				KogMaw.EnName = "KogMaw";
				KogMaw.CnName = "克格'莫";
				KogMaw.DefaultName = "深渊巨口";
				KogMaw.Portrait = fo.GetAirChampionPortrait(KogMaw);

				KogMaw.ShortName = new List<string> { "大嘴" };
				KogMaw.Skins = new List<Skin>() {
					new Skin(KogMaw,0,"Classic","经典"),
					new Skin(KogMaw,1,"Caterpillar","毛毛虫"),
					new Skin(KogMaw,2,"Sonoran","索诺拉沙虫"),
					new Skin(KogMaw,3,"Monarch","帝皇斑蝶"),
					new Skin(KogMaw,4,"Reindeer","圣诞驯鹿"),
					new Skin(KogMaw,5,"Lion Dance","醒狮"),
					new Skin(KogMaw,6,"Deep Sea","深海怪鱼"),
					new Skin(KogMaw,7,"Jurassic","侏罗纪化石"),
				};
                KogMaw.Spells = new List<Spell>() {
                    new Spell ("KogMaw_CausticSpittle","q"),
					new Spell ("KogMaw_BioArcaneBarrage","w"),
					new Spell ("KogMaw_VoidOoze","e"),
					new Spell ("KogMaw_LivingArtillery","r"),
					new Spell ("KogMaw_IcathianSurprise","t"),
                };
				KogMaw.Tags = new List<string>() { "远程", "物理", "法术" };
				cList.Add(KogMaw.EnName, KogMaw);

				//乐芙兰 诡术妖姬
				Champion Leblanc = new Champion();
				Leblanc.EnName = "Leblanc";
				Leblanc.CnName = "乐芙兰";
				Leblanc.DefaultName = "诡术妖姬";
				Leblanc.Portrait = fo.GetAirChampionPortrait(Leblanc);

				Leblanc.ShortName = new List<string> { "妖姬" };
				Leblanc.Skins = new List<Skin>() {
					new Skin(Leblanc,0,"Classic","经典"),
					new Skin(Leblanc,1,"Wicked","潮流女王"),
					new Skin(Leblanc,2,"Prestigious","社会名流"),
					new Skin(Leblanc,3,"Mistletoe","幸福女神"),
				};
                Leblanc.Spells = new List<Spell>() {
                    new Spell ("LeblancMarkOfSilence","q"),
					new Spell ("LeblancDisplacement","w"),
					new Spell ("LeblancConjureChains","e"),
					new Spell ("LeblancMimic","r"),
					new Spell ("LeblancMirrorImage","t"),
                };
				Leblanc.Tags = new List<string>() { "远程", "法术", "刺客" };
				cList.Add(Leblanc.EnName, Leblanc);

				//李青 盲僧
				Champion LeeSin = new Champion();
				LeeSin.EnName = "LeeSin";
				LeeSin.CnName = "李青";
				LeeSin.DefaultName = "盲僧";
				LeeSin.Portrait = fo.GetAirChampionPortrait(LeeSin);

				LeeSin.ShortName = new List<string> { "瞎子" };
				LeeSin.Skins = new List<Skin>() {
					new Skin(LeeSin,0,"Classic","经典"),
					new Skin(LeeSin,1,"Traditional","传统僧侣"),
					new Skin(LeeSin,2,"Acolyte","侍僧"),
					new Skin(LeeSin,3,"Dragon Fist","龙的传人"),
					new Skin(LeeSin,4,"Muay Thai","志高之拳"),
				};
                LeeSin.Spells = new List<Spell>() {
                    new Spell("BlindMonKQOne","q"),
                    new Spell("BlindMonkWOne","w"),
                    new Spell("BlindMonkEOne","e"),
                    new Spell("BlindMonkR","r"),
                    new Spell("BlindMonk_SightUnseeing","t"),
                };
				LeeSin.Tags = new List<string>() { "近战", "物理", "打野" };
				cList.Add(LeeSin.EnName, LeeSin);


				//蕾欧娜 曙光女神
				Champion Leona = new Champion();
				Leona.EnName = "Leona";
				Leona.CnName = "蕾欧娜";
				Leona.DefaultName = "曙光女神";
				Leona.Portrait = fo.GetAirChampionPortrait(Leona);

				Leona.ShortName = new List<string> { "日女", "女坦" };
				Leona.Skins = new List<Skin>() {
					new Skin(Leona,0,"Classic","经典"),
					new Skin(Leona,1,"Valkyrie","瓦尔基里"),
					new Skin(Leona,2,"Defender","神圣守卫"),
					new Skin(Leona,3,"Iron Solari","钢铁烈阳"),
				};
                Leona.Spells = new List<Spell>() {
                    new Spell ("LeonaShieldOfDaybreak","q"),
					new Spell ("LeonaSolarBarrier","w"),
					new Spell ("LeonaZenithBlade","e"),
					new Spell ("LeonaSolarFlare","r"),
					new Spell ("LeonaSunlight","t"),
                };
				Leona.Tags = new List<string>() { "近战", "法术", "辅助", "坦克" };
				cList.Add(Leona.EnName, Leona);

				//璐璐 仙灵女巫
				Champion Lulu = new Champion();
				Lulu.EnName = "Lulu";
				Lulu.CnName = "璐璐";
				Lulu.DefaultName = "仙灵女巫";
				Lulu.Portrait = fo.GetAirChampionPortrait(Lulu);

				Lulu.ShortName = null;
				Lulu.Skins = new List<Skin>() {
					new Skin(Lulu,0,"Classic","经典"),
					new Skin(Lulu,1,"Bittersweet","糖果女巫"),
					new Skin(Lulu,2,"Wicked","邪恶女巫"),
                    new Skin(Lulu,3,"","驯龙女巫"),
				};
                Lulu.Spells = new List<Spell>() {
                    new Spell ("Lulu_Glitterbolt","q"),
					new Spell ("Lulu_Whimsy","w"),
					new Spell ("Lulu_CommandPix","e"),
					new Spell ("Lulu_GiantGrowth","r"),
					new Spell ("Lulu_PixFaerieCompanion","t"),
                };
				Lulu.Tags = new List<string>() { "远程", "法术", "辅助" };
				cList.Add(Lulu.EnName, Lulu);

				//拉克丝 光辉女郎
				Champion Lux = new Champion();
				Lux.EnName = "Lux";
				Lux.CnName = "拉克丝";
				Lux.DefaultName = "拉克丝";
				Lux.Portrait = fo.GetAirChampionPortrait(Lux);

				Lux.ShortName = new List<string> { "光辉" };
				Lux.Skins = new List<Skin>() {
					new Skin(Lux,0,"Classic","经典"),
					new Skin(Lux,1,"Sorceress","奥术光辉"),
					new Skin(Lux,2,"Spellthief","游侠法师"),
					new Skin(Lux,3,"Commando","ODST地狱伞兵"),
					new Skin(Lux,4,"Imperial","星际迷航"),
				};
                Lux.Spells = new List<Spell>() {
                    new Spell ("LuxCrashingBlitz2","q"),
					new Spell ("LuxPrismaWrap","w"),
					new Spell ("LuxLightStrikeKugel","e"),
					new Spell ("LuxFinaleFunkeln","r"),
					new Spell ("LuxIlluminatingFraulein","t"),
                };
				Lux.Tags = new List<string>() { "远程", "法术", "辅助", "推进" };
				cList.Add(Lux.EnName, Lux);

				//墨菲特 熔岩巨兽
				Champion Malphite = new Champion();
				Malphite.EnName = "Malphite";
				Malphite.CnName = "墨菲特";
				Malphite.DefaultName = "熔岩巨兽";
				Malphite.Portrait = fo.GetAirChampionPortrait(Malphite);

				Malphite.ShortName = new List<string> { "石头人", "石头", "熔岩" };
				Malphite.Skins = new List<Skin>() {
					new Skin(Malphite,0,"Classic","经典"),
					new Skin(Malphite,1,"Shamrock","三叶草"),
					new Skin(Malphite,2,"Coral Reef","珊瑚礁"),
					new Skin(Malphite,3,"Marble","石破天惊"),
					new Skin(Malphite,4,"Obsidian","黑曜石守护者"),
					new Skin(Malphite,5,"Glacial","冰川巨兽"),
				};
                Malphite.Spells = new List<Spell>() {
                    new Spell ("Malphite_SeismicShard","q"),
					new Spell ("Malphite_BrutalStrikes","w"),
					new Spell ("Malphite_GroundSlam","e"),
					new Spell ("Malphite_UnstoppableForce","r"),
					new Spell ("Malphite_GraniteShield","t"),
                };
				Malphite.Tags = new List<string>() { "近战", "物理", "辅助", "打野", "坦克" };
				cList.Add(Malphite.EnName, Malphite);

				//玛尔扎哈 虚空先知
				Champion Malzahar = new Champion();
				Malzahar.EnName = "Malzahar";
				Malzahar.CnName = "玛尔扎哈";
				Malzahar.DefaultName = "虚空先知";
				Malzahar.Portrait = fo.GetAirChampionPortrait(Malzahar);

				Malzahar.ShortName = new List<string> { "马扎", "蚂蚱" };
				Malzahar.Skins = new List<Skin>() {
					new Skin(Malzahar,0,"Classic","经典"),
					new Skin(Malzahar,1,"Vizier","元老议会"),
					new Skin(Malzahar,2,"Shadow Prince","暗影王子"),
					new Skin(Malzahar,3,"Djinn","魔灵"),
					new Skin(Malzahar,4,"Overlord","至高君王"),
				};
                Malzahar.Spells = new List<Spell>() {
                    new Spell("AlZahar_CalloftheVoid","q"),
                    new Spell("AlZahar_NullZone","w"),
                    new Spell("AlZahar_MaleficVisions","e"),
                    new Spell("AlZahar_NetherGrasp","r"),
                    new Spell("AlZahar_SummonVoidling","t"),
                };
				Malzahar.Tags = new List<string>() { "远程", "法术", "推进" };
				cList.Add(Malzahar.EnName, Malzahar);

				//茂凯 扭曲树精
				Champion Maokai = new Champion();
				Maokai.EnName = "Maokai";
				Maokai.CnName = "茂凯";
				Maokai.DefaultName = "扭曲树精";
				Maokai.Portrait = fo.GetAirChampionPortrait(Maokai);

				Maokai.ShortName = new List<string> { "大树", "树精" };
				Maokai.Skins = new List<Skin>() {
					new Skin(Maokai,0,"Classic","经典"),
					new Skin(Maokai,1,"Charred","烈焰古树"),
					new Skin(Maokai,2,"Totemic","图腾古树"),
					new Skin(Maokai,3,"Festive","喜庆之树"),
					//new Skin(Maokai,4,"Haunted",""),
				};
                Maokai.Spells = new List<Spell>() {
                    new Spell ("Maokai_ArcaneSmash","q"),
					new Spell ("Maokai_TwistedAdvance","w"),
					new Spell ("Maokai_SaplingToss","e"),
					new Spell ("Maokai_VengefulMaelstrom","r"),
					new Spell ("Maokai_SapMagic","t"),
                };
				Maokai.Tags = new List<string>() { "近战", "法术", "打野" };
				cList.Add(Maokai.EnName, Maokai);

				//易 无极剑圣
				Champion MasterYi = new Champion();
				MasterYi.EnName = "MasterYi";
				MasterYi.CnName = "易";
				MasterYi.DefaultName = "无极剑圣";
				MasterYi.Portrait = fo.GetAirChampionPortrait(MasterYi);

				MasterYi.ShortName = new List<string> { "剑圣", "易大师" };
				MasterYi.Skins = new List<Skin>() {
					new Skin(MasterYi,0,"Classic","经典"),
					new Skin(MasterYi,1,"Assassin","暗影"),
					new Skin(MasterYi,2,"Chosen","星战"),
					new Skin(MasterYi,3,"Ionian","天人合一"),
					new Skin(MasterYi,4,"Samurai","侍魂"),
					new Skin(MasterYi,5,"Headhunter","铁血剑豪"),
				};
                MasterYi.Spells = new List<Spell>() {
                    new Spell ("MasterYi_LeapStrike","q"),
					new Spell ("MasterYi_InnerFocus","w"),
					new Spell ("MasterYi_SunderingStrikes","e"),
					new Spell ("MasterYi_InnerFocus2","r"),
					new Spell ("MasterYi_DoubleStrike","t"),
                };
				MasterYi.Tags = new List<string>() { "近战", "物理", "法术", "打野" };
				cList.Add(MasterYi.EnName, MasterYi);

				//厄运小姐 赏金猎人
				Champion MissFortune = new Champion();
				MissFortune.EnName = "MissFortune";
				MissFortune.CnName = "厄运小姐";
				MissFortune.DefaultName = "赏金猎人";
				MissFortune.Portrait = fo.GetAirChampionPortrait(MissFortune);

				MissFortune.ShortName = new List<string> { "好运姐", "女枪" };
				MissFortune.Skins = new List<Skin>() {
					new Skin(MissFortune,0,"Classic","经典"),
					new Skin(MissFortune,1,"Cowgirl","西部牛仔"),
					new Skin(MissFortune,2,"Waterloo","法国皇室"),
					new Skin(MissFortune,3,"Secret Agent","特工狂花"),
					new Skin(MissFortune,4,"Candy Cane","圣诞糖果棒"),
					new Skin(MissFortune,5,"Road Warrior","荒野女警"),
					new Skin(MissFortune,6,"Mafia","黑帮狂花"),
				};
				MissFortune.Tags = new List<string>() { "远程", "物理" };
                MissFortune.Spells = new List<Spell>() {
                    new Spell ("MissFortune_DoubleUp","q"),
					new Spell ("MissFortune_ImpureShots","w"),
					new Spell ("MissFortune_MakeItRain","e"),
					new Spell ("MissFortune_BulletTime","r"),
					new Spell ("MissFortune_Strut","t"),
                };
				cList.Add(MissFortune.EnName, MissFortune);

				//悟空 齐天大圣
				Champion MonkeyKing = new Champion();
				MonkeyKing.EnName = "MonkeyKing";
				MonkeyKing.CnName = "孙悟空";
				MonkeyKing.DefaultName = "齐天大圣";
				MonkeyKing.Portrait = fo.GetAirChampionPortrait(MonkeyKing);

				MonkeyKing.ShortName = new List<string> { "猴子", "孙猴子", "悟空", "大圣", "猴" };
				MonkeyKing.Skins = new List<Skin>() {
					new Skin(MonkeyKing,0,"Classic","经典"),
					new Skin(MonkeyKing,1,"Volcanic","三昧真火"),
					new Skin(MonkeyKing,2,"General","斗战神"),
					new Skin(MonkeyKing,3,"Jade Dragon","定海神针"),
				};
                MonkeyKing.Spells = new List<Spell>() {
                    new Spell ("MonkeyKingCrushingBlow","q"),
					new Spell ("MonkeyKingDecoy","w"),
					new Spell ("MonkeyKingNimbusStrike","e"),
					new Spell ("MonkeyKingCyclone","r"),
					new Spell ("MonkeyKingStoneSkin","t"),
                };
				MonkeyKing.Tags = new List<string>() { "近战", "物理", "刺客" };
				cList.Add(MonkeyKing.EnName, MonkeyKing);

				//莫德凯撒 金属大师
				Champion Mordekaiser = new Champion();
				Mordekaiser.EnName = "Mordekaiser";
				Mordekaiser.CnName = "莫德凯撒";
				Mordekaiser.DefaultName = "金属大师";
				Mordekaiser.Portrait = fo.GetAirChampionPortrait(Mordekaiser);

				Mordekaiser.ShortName = new List<string> { "金属" };
				Mordekaiser.Skins = new List<Skin>() {
					new Skin(Mordekaiser,0,"Classic","经典"),
					new Skin(Mordekaiser,1,"Dragon Knight","龙骑士"),
					new Skin(Mordekaiser,2,"Infeernal","地狱火"),
					new Skin(Mordekaiser,3,"Pentakill","五杀摇滚吉他手"),
					new Skin(Mordekaiser,4,"Lord","死亡领主"),
				};
                Mordekaiser.Spells = new List<Spell>() {
                    new Spell ("MordekaiserMaceOfSpades","q"),
					new Spell ("MordekaiserCreepingDeath","w"),
					new Spell ("MordekaiserSiphonOfDestruction","e"),
					new Spell ("Mordekaiser_COTG","r"),
					new Spell ("Mordekaiser_IronMan","t"),
                };
				Mordekaiser.Tags = new List<string>() { "近战", "法术", "推进" };
				cList.Add(Mordekaiser.EnName, Mordekaiser);

				//莫甘娜 堕落天使
				Champion Morgana = new Champion();
				Morgana.EnName = "Morgana";
				Morgana.CnName = "莫甘娜";
				Morgana.DefaultName = "堕落天使";
				Morgana.Portrait = fo.GetAirChampionPortrait(Morgana);

				Morgana.ShortName = new List<string> { "莫干吗", "地沟油" };
				Morgana.Skins = new List<Skin>() {
					new Skin(Morgana,0,"Classic","经典"),
					new Skin(Morgana,1,"Exiled","杀戮天使昔拉"),
					new Skin(Morgana,2,"Sinful Succulence","地狱厨房"),
					new Skin(Morgana,3,"Blade","刀锋女王"),
					new Skin(Morgana,4,"Blackthorn","黑色荆棘"),
				};
				Morgana.Tags = new List<string>() { "远程", "法术", "辅助", "推进" };
                Morgana.Spells = new List<Spell>() {
                    new Spell ("FallenAngel_DarkBinding","q"),
					new Spell ("FallenAngel_TormentedSoil","w"),
					new Spell ("FallenAngel_BlackShield","e"),
					new Spell ("FallenAngel_Purgatory","r"),
					new Spell ("FallenAngel_Empathize","t"),
                };
				cList.Add(Morgana.EnName, Morgana);

                //唤潮鲛姬 娜美
                Champion Nami = new Champion();
                Nami.EnName = "Nami";
                Nami.CnName = "娜美";
                Nami.DefaultName = "唤潮鲛姬";
                Nami.Portrait = fo.GetAirChampionPortrait(Nami);
                Nami.ShortName = new List<string> { "纳米","搅基","人鱼"};
                Nami.Skins = new List<Skin>() {
                    new Skin(Nami,0,"Classic","经典"),
                    new Skin(Nami,1,"Koi","湖伊"),
                };
                Nami.Spells = new List<Spell>() {
                    new Spell("NamiQ","q"),
                    new Spell("NamiW","w"),
                    new Spell("NamiE","e"),
                    new Spell("NamiR","r"),
                    new Spell("NamiPassive","t"),
                };
                Nami.Tags = new List<string>(){"远程","法术","辅助" };
                cList.Add(Nami.EnName, Nami); 

				//内瑟斯 沙漠死神
				Champion Nasus = new Champion();
				Nasus.EnName = "Nasus";
				Nasus.CnName = "内瑟斯";
				Nasus.DefaultName = "沙漠死神";
				Nasus.Portrait = fo.GetAirChampionPortrait(Nasus);

				Nasus.ShortName = new List<string> { "狗头" };
				Nasus.Skins = new List<Skin>() {
					new Skin(Nasus,0,"Classic","经典"),
					new Skin(Nasus,1,"Galactic","星空之门"),
					new Skin(Nasus,2,"Pharaoh","法老王朝"),
					new Skin(Nasus,3,"Dreadknight","恐惧骑士"),
					new Skin(Nasus,4,"Riot K-9","警用试作体K-9"),
				};
                Nasus.Spells = new List<Spell>() {
                    new Spell("Nasus_SiphoningStrike","q"),
                    new Spell("Nasus_Wither","w"),
                    new Spell("Nasus_SpiritFire","e"),
                    new Spell("Nasus_AvatarOfDeath","r"),
                    new Spell("Nasus_SoulEater","t"),
                };
				Nasus.Tags = new List<string>() { "近战", "法术" };
				cList.Add(Nasus.EnName, Nasus);

				//诺提勒斯 深海泰坦
				Champion Nautilus = new Champion();
				Nautilus.EnName = "Nautilus";
				Nautilus.CnName = "诺提勒斯";
				Nautilus.DefaultName = "深海泰坦";
				Nautilus.Portrait = fo.GetAirChampionPortrait(Nautilus);

				Nautilus.ShortName = new List<string> { "泰坦" };
				Nautilus.Skins = new List<Skin>() {
					new Skin(Nautilus,0,"Classic","经典"),
					new Skin(Nautilus,1,"Abyssal","失落大陆"),
					new Skin(Nautilus,2,"Subterranean","地底迷城"),
					new Skin(Nautilus,3,"Astro","宇航员"),
				};
                Nautilus.Spells = new List<Spell>() {
                    new Spell ("Nautilus_AnchorChain","q"),
					new Spell ("Nautilus_Wrath","w"),
					new Spell ("Nautilus_RippleEffect","e"),
					new Spell ("Nautilus_GrandLine","r"),
					new Spell ("Nautilus_StaggeringBlow","t"),
                };
				Nautilus.Tags = new List<string>() { "近战", "物理", "打野", "坦克" };
				cList.Add(Nautilus.EnName, Nautilus);

				//奈德丽 狂野女猎手
				Champion Nidalee = new Champion();
				Nidalee.EnName = "Nidalee";
				Nidalee.CnName = "奈德丽";
				Nidalee.DefaultName = "狂野女猎手";
				Nidalee.Portrait = fo.GetAirChampionPortrait(Nidalee);

				Nidalee.ShortName = new List<string> { "奶大力", "乃大力", "豹女" };
				Nidalee.Skins = new List<Skin>() {
					new Skin(Nidalee,0,"Classic","经典"),
					new Skin(Nidalee,1,"Snow Bunny","雪装"),
					new Skin(Nidalee,2,"Leopard","丛林猎豹"),
					new Skin(Nidalee,3,"French Maid","法国女仆"),
					new Skin(Nidalee,4,"Pharaoh","艳后"),
					new Skin(Nidalee,5,"Bewitching","魅惑女巫"),
				};
                Nidalee.Spells = new List<Spell>() {
                    new Spell ("Nidalee_JavelinThrow","q"),
					new Spell ("Nidalee_Bushwhack","w"),
					new Spell ("Nidalee_PrimalSurge","e"),
					new Spell ("Nidalee_AspectOfTheCougar","r"),
					new Spell ("Nidalee_OnTheProwl","t"),
                };
				Nidalee.Tags = new List<string>() { "近战", "远程", "物理", "法术", "辅助", "推进" };
				cList.Add(Nidalee.EnName, Nidalee);

				//魔腾 永恒梦魇
				Champion Nocturne = new Champion();
				Nocturne.EnName = "Nocturne";
				Nocturne.CnName = "魔腾";
				Nocturne.DefaultName = "永恒梦魇";
				Nocturne.Portrait = fo.GetAirChampionPortrait(Nocturne);

				Nocturne.ShortName = new List<string> { "梦魇", "noc", "NOC" };
				Nocturne.Skins = new List<Skin>() {
					new Skin(Nocturne,0,"Classic","经典"),
					new Skin(Nocturne,1,"Frozen Terror", "蓝焰梦魔"),
					new Skin(Nocturne,2,"Void","幻影梦魔"),
					new Skin(Nocturne,3,"Ravager","劫掠梦魇"),
					new Skin(Nocturne,4,"Haunting","鬼影重重"),
                    new Skin(Nocturne,5,"","上古战魂"),
				};
                Nocturne.Spells = new List<Spell>() {
                    new Spell ("Nocturne_Duskbringer","q"),
					new Spell ("Nocturne_ShroudOfDarkness","w"),
					new Spell ("Nocturne_UnspeakableHorror","e"),
					new Spell ("Nocturne_Paranoia","r"),
					new Spell ("Nocturne_UmbraBlades","t"),
                };
				Nocturne.Tags = new List<string>() { "近战", "法术", "打野" };
				cList.Add(Nocturne.EnName, Nocturne);

				//努努 雪人骑士
				Champion Nunu = new Champion();
				Nunu.EnName = "Nunu";
				Nunu.CnName = "努努";
				Nunu.DefaultName = "雪人骑士";
				Nunu.Portrait = fo.GetAirChampionPortrait(Nunu);

				Nunu.ShortName = new List<string> { "雪人" };
				Nunu.Skins = new List<Skin>() {
					new Skin(Nunu,0,"Classic","经典"),
					new Skin(Nunu,1,"Sasquatch","荒野巨兽"),
					new Skin(Nunu,2,"Workshop","圣诞狂欢"),
					new Skin(Nunu,3,"Grungy","脏兮兮"),
					new Skin(Nunu,4,"Bot","合金装备"),
					new Skin(Nunu,5,"Demolisher","攻城巨兽"),
				};
                Nunu.Spells = new List<Spell>() {
                    new Spell ("Yeti_Consume","q"),
					new Spell ("Yeti_YetiSmash","w"),
					new Spell ("Yeti_IceBlast","e"),
					new Spell ("Yeti_Shatter","r"),
					new Spell ("Yeti_FrostNova","t"),
                };
				Nunu.Tags = new List<string>() { "近战", "法术", "辅助", "打野", "坦克" };
				cList.Add(Nunu.EnName, Nunu);

				//奥拉夫 狂战士
				Champion Olaf = new Champion();
				Olaf.EnName = "Olaf";
				Olaf.CnName = "奥拉夫";
				Olaf.DefaultName = "狂战士";
				Olaf.Portrait = fo.GetAirChampionPortrait(Olaf);

				Olaf.ShortName = new List<string> { "疯狗", "无情奥拉夫" };
				Olaf.Skins = new List<Skin>() {
					new Skin(Olaf,0,"Classic","经典"),
					new Skin(Olaf,1,"Forsaken","烈焰猛士"),
					new Skin(Olaf,2,"Glacial","冰河时代"),
					new Skin(Olaf,3,"Brolaf","铁哥们"),
					new Skin(Olaf,4,"Pentakill","五杀摇滚鼓手"),
				};
                Olaf.Spells = new List<Spell>() {
                    new Spell ("OlafAxeThrow","q"),
					new Spell ("OlafViciousStrikes","w"),
					new Spell ("OlafRecklessSwing","e"),
					new Spell ("OlafRagnarok","r"),
					new Spell ("OlafBerserkerRage","t"),
                };
				Olaf.Tags = new List<string>() { "近战", "物理", "打野" };
				cList.Add(Olaf.EnName, Olaf);

				//奥莉安娜 发条魔灵
				Champion Orianna = new Champion();
				Orianna.EnName = "Orianna";
				Orianna.CnName = "奥莉安娜";
				Orianna.DefaultName = "发条魔灵";
				Orianna.Portrait = fo.GetAirChampionPortrait(Orianna);

				Orianna.ShortName = new List<string> { "发条" };
				Orianna.Skins = new List<Skin>() {
					new Skin(Orianna,0,"Classic","经典"),
					new Skin(Orianna,1,"Gothic","哥特女仆"),
					new Skin(Orianna,2,"Sewn Chaos","木偶奇遇记"),
					new Skin(Orianna,3,"Bladecraft","灵骨工匠"),
				};
                Orianna.Spells = new List<Spell>() {
                    new Spell ("OriannaCommandAttack","q"),
					new Spell ("OriannaCommandDissonance","w"),
					new Spell ("OriannaCommandRedact","e"),
					new Spell ("OriannaCommandDetonate","r"),
					new Spell ("OriannaPassive","t"),
                };
				Orianna.Tags = new List<string>() { "远程", "法术", "推进" };
				cList.Add(Orianna.EnName, Orianna);

				//潘森 战争之王
				Champion Pantheon = new Champion();
				Pantheon.EnName = "Pantheon";
				Pantheon.CnName = "潘森";
				Pantheon.DefaultName = "战争之王";
				Pantheon.Portrait = fo.GetAirChampionPortrait(Pantheon);

				Pantheon.ShortName = null;
				Pantheon.Tags = new List<string>() { "近战", "物理", "打野", };
				Pantheon.Skins = new List<Skin>() {
					new Skin(Pantheon,0,"Classic","经典"),
					new Skin(Pantheon,1,"Mymidon","斯巴达之魂"),
					new Skin(Pantheon,2,"Ruthless","万人敌"),
					new Skin(Pantheon,3,"Perseus","英仙座珀尔修斯"),
					new Skin(Pantheon,4,"Full Metal","钢铁意志"),
					new Skin(Pantheon,5,"Glaive Warrior","大夏武士"),
				};
                Pantheon.Spells = new List<Spell>() {
                    new Spell ("Pantheon_SpearShot","q"),
					new Spell ("Pantheon_LeapBash","w"),
					new Spell ("Pantheon_HSS","e"),
					new Spell ("Pantheon_GrandSkyFall","r"),
					new Spell ("Pantheon_AOZ","t"),
                };
				cList.Add(Pantheon.EnName, Pantheon);

				//波比 钢铁大使
				Champion Poppy = new Champion();
				Poppy.EnName = "Poppy";
				Poppy.CnName = "波比";
				Poppy.DefaultName = "钢铁大使";
				Poppy.Portrait = fo.GetAirChampionPortrait(Poppy);

				Poppy.ShortName = null;
				Poppy.Skins = new List<Skin>() {
					new Skin(Poppy,0,"Classic","经典"),
					new Skin(Poppy,1,"Noxus","诺克萨斯"),
					new Skin(Poppy,2,"Lollipoppy","波比的巧克力工坊"),
					new Skin(Poppy,3,"Blacksmith","宗师级锻造训练师"),
					new Skin(Poppy,4,"Regdoll","圣诞玩偶"),
					new Skin(Poppy,5,"Battle Regalia","军神战甲"),
					new Skin(Poppy,6,"Scarlet Hammer","血色之锤"),
				};
                Poppy.Spells = new List<Spell>() { 
                    new Spell ("PoppyDevastatingBlow","q"),
					new Spell ("PoppyDefenseOfDemacia","w"),
					new Spell ("Poppy_HeroicCharge","e"),
					new Spell ("Poppy_DiplomaticImmunity","r"),
					new Spell ("Poppy_ValiantFighter","t"),
                };
				Poppy.Tags = new List<string>() { "近战", "物理" };
				cList.Add(Poppy.EnName, Poppy);

				//拉莫斯 披甲龙龟
				Champion Rammus = new Champion();
				Rammus.EnName = "Rammus";
				Rammus.CnName = "拉莫斯";
				Rammus.DefaultName = "披甲龙龟";
				Rammus.Portrait = fo.GetAirChampionPortrait(Rammus);

				Rammus.ShortName = new List<string> { "龙龟", "乌龟" };
				Rammus.Skins = new List<Skin>() {
					new Skin(Rammus,0,"Classic","经典"),
					new Skin(Rammus,1,"King","国王"),
					new Skin(Rammus,2,"Chrome","饹金铠甲"),
					new Skin(Rammus,3,"Molten","熔火之心"),
					new Skin(Rammus,4,"Freljord","极度深寒"),
					new Skin(Rammus,5,"Ninja","忍龟"),
					new Skin(Rammus,6,"Full Metal","全金属狂潮"),

				};
                Rammus.Spells = new List<Spell>() {
                    new Spell("Armordillo_Powerball","q"),
                    new Spell("Armordillo_ShellBash","w"),
                    new Spell("Armordillo_ScaledPlating","e"),
                    new Spell("Armordillo_RecklessCharge","r"),
                    new Spell("Armordillo_ScavengeArmor","t"),

                };
				Rammus.Tags = new List<string>() { "近战", "物理", "打野", "辅助" };
				cList.Add(Rammus.EnName, Rammus);

				//雷克顿 荒漠屠夫
				Champion Renekton = new Champion();
				Renekton.EnName = "Renekton";
				Renekton.CnName = "雷克顿";
				Renekton.DefaultName = "荒漠屠夫";
				Renekton.Portrait = fo.GetAirChampionPortrait(Renekton);

				Renekton.ShortName = new List<string> { "鳄鱼" };
				Renekton.Skins = new List<Skin>() {
					new Skin(Renekton,0,"Classic","经典"),
					new Skin(Renekton,1,"Galactic","星河战队"),
					new Skin(Renekton,2,"Outback","荒野之咬"),
					new Skin(Renekton,3,"Bloodfury","血色暴君"),
					new Skin(Renekton,4,"Rune Wars","符文战神"),
				};
                Renekton.Spells = new List<Spell>() {
                    new Spell ("Renekton_Cleave","q"),
					new Spell ("Renekton_Execute","w"),
					new Spell ("Renekton_SliceAndDice","e"),
					new Spell ("Renekton_Dominus","r"),
					new Spell ("Renekton_Predator","t"),
                };
				Renekton.Tags = new List<string>() { "近战", "物理" };
				cList.Add(Renekton.EnName, Renekton);

				//雷恩加尔 傲之追猎者
				Champion Rengar = new Champion();
				Rengar.EnName = "Rengar";
				Rengar.CnName = "雷恩加尔";
				Rengar.DefaultName = "傲之追猎者";
				Rengar.Portrait = fo.GetAirChampionPortrait(Rengar);

				Rengar.ShortName = new List<string> { "狮子头", "狮子", "瑞星小狮子" };
				Rengar.Skins = new List<Skin>() {
					new Skin(Rengar,0,"Classic","经典"),
					new Skin(Rengar,1,"Headhunter","铁血猎人"),
				};
				Rengar.Tags = new List<string>() { "近战", "物理", "法术", "刺客", "打野" };
                Rengar.Spells = new List<Spell>() {
                    new Spell ("RengarQ","q"),
					new Spell ("RengarW","w"),
					new Spell ("RengarE","e"),
					new Spell ("RengarUlt","r"),
					new Spell ("Rengar_Passive","t"),
                };
				cList.Add(Rengar.EnName, Rengar);

				//瑞雯 放逐之刃
				Champion Riven = new Champion();
				Riven.EnName = "Riven";
				Riven.CnName = "瑞雯";
				Riven.DefaultName = "放逐之刃";
				Riven.Portrait = fo.GetAirChampionPortrait(Riven);

				Riven.ShortName = new List<string> { "放逐" };
				Riven.Skins = new List<Skin>() {
					new Skin(Riven,0,"Classic","经典"),
					new Skin(Riven,1,"Redeemed","刺客信条"),
					new Skin(Riven,2,"Crimson","血色精锐"),
					new Skin(Riven,3,"Battle Bunny","兔女郎"),
					new Skin(Riven,4,"Championship","冠军之刃"),
				};
                Riven.Spells = new List<Spell>() {
                    new Spell ("RivenBrokenWings","q"),
					new Spell ("RivenKiShout","w"),
					new Spell ("RivenPathoftheExile","e"),
					new Spell ("RivenBladeoftheExile","r"),
					new Spell ("RivenRunicBlades","t"),
                };
				Riven.Tags = new List<string>() { "近战", "物理", "打野" };
				cList.Add(Riven.EnName, Riven);

				//兰博 机械公敌
				Champion Rumble = new Champion();
				Rumble.EnName = "Rumble";
				Rumble.CnName = "兰博";
				Rumble.DefaultName = "机械公敌";
				Rumble.Portrait = fo.GetAirChampionPortrait(Rumble);

				Rumble.ShortName = new List<string> { "蓝波", "兰波" };
				Rumble.Skins = new List<Skin>() {
					new Skin(Rumble,0,"Classic","经典"),
					new Skin(Rumble,1,"in the Jungle","热带丛林"),
					new Skin(Rumble,2,"Bilgerat","独眼海盗"),
				};
				Rumble.Tags = new List<string>() { "近战", "法术" };
                Rumble.Spells = new List<Spell>() {
                    new Spell ("Rumble_Flamespitter","q"),
					new Spell ("Rumble_Scrap Shield","w"),
					new Spell ("Rumble_Electro Harpoon","e"),
					new Spell ("Rumble_R","r"),
					new Spell ("Rumble_Junkyard Titan1","t"),
                };
				cList.Add(Rumble.EnName, Rumble);


				//瑞兹 流浪法师
				Champion Ryze = new Champion();
				Ryze.EnName = "Ryze";
				Ryze.CnName = "瑞兹";
				Ryze.DefaultName = "流浪法师";
				Ryze.Portrait = fo.GetAirChampionPortrait(Ryze);

				Ryze.ShortName = new List<string> { "光头", "流浪", "大光头" };
				Ryze.Skins = new List<Skin>() {
					new Skin(Ryze,0,"Classic","经典"),
					new Skin(Ryze,1,"Human","大魔法师"),
					new Skin(Ryze,2,"Tribal","部落精神"),
					new Skin(Ryze,3,"Uncle","美国大叔"),
					new Skin(Ryze,4,"Triumphant","守护者雕像"),
					new Skin(Ryze,5,"Professor","宗师级法师训练师"),
					new Skin(Ryze,6,"Zombie","至死不渝"),
					new Skin(Ryze,7,"Dark Crystal","恶魔男爵"),
                    //new Skin(Ryze,8, "Private","海盗"),
				};
                Ryze.Spells = new List<Spell>() {
                    new Spell ("Ryze_Overload","q"),
					new Spell ("Ryze_PowerOverwhelming","w"),
					new Spell ("Ryze_LightningFlux","e"),
					new Spell ("Ryze_DesperatePower","r"),
					new Spell ("Ryze_SpellStrike","t"),
                };
				Ryze.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Ryze.EnName, Ryze);

				//瑟庄妮 凛冬之怒
				Champion Sejuani = new Champion();
				Sejuani.EnName = "Sejuani";
				Sejuani.CnName = "瑟庄妮";
				Sejuani.DefaultName = "凛冬之怒";
				Sejuani.Portrait = fo.GetAirChampionPortrait(Sejuani);

				Sejuani.ShortName = new List<string> { "猪妹", "凛冬" };
				Sejuani.Skins = new List<Skin>() {
					new Skin(Sejuani,0,"Classic","经典"),
					new Skin(Sejuani,1,"Sabretusk","野兽女王"),
					new Skin(Sejuani,2,"Darkrider","死亡骑士"),
				};
                Sejuani.Spells = new List<Spell>() {
                    new Spell ("Sejuani_ArcticAssault","q"),
					new Spell ("Sejuani_GlacialPrison","w"),
					new Spell ("Sejuani_Permafrost","e"),
					new Spell ("Sejuani_NorthernWinds","r"),
					new Spell ("Sejuani_Frost","t"),
                };
				Sejuani.Tags = new List<string>() { "近战", "法术", "打野" };
				cList.Add(Sejuani.EnName, Sejuani);


				//萨科 恶魔小丑
				Champion Shaco = new Champion();
				Shaco.EnName = "Shaco";
				Shaco.CnName = "萨科";
				Shaco.DefaultName = "恶魔小丑";
				Shaco.Portrait = fo.GetAirChampionPortrait(Shaco);

				Shaco.ShortName = new List<string> { "小丑" };
				Shaco.Skins = new List<Skin>() {
					new Skin(Shaco,0,"Classic","经典"),
					new Skin(Shaco,1,"Mad Hatter","恐怖之源"),
					new Skin(Shaco,2,"Royal","贵族血统"),
					new Skin(Shaco,3,"Nutcracko","胡桃夹子"),
					new Skin(Shaco,4,"Workshop","小丑工作坊"),
					new Skin(Shaco,5,"Asylum","飞越疯人院"),
				};
                Shaco.Spells = new List<Spell>() {
                    new Spell ("Jester_Deceive","q"),
					new Spell ("Jester_JackInTheBox","w"),
					new Spell ("Jester_TwoShivPoison","e"),
					new Spell ("Jester_Hallucinate","r"),
					new Spell ("Jester_CarefulStrikes","t"),
                };
				Shaco.Tags = new List<string>() { "近战", "物理", "打野" };
				cList.Add(Shaco.EnName, Shaco);

				//慎 暮光之眼
				Champion Shen = new Champion();
				Shen.EnName = "Shen";
				Shen.CnName = "慎";
				Shen.DefaultName = "暮光之眼";
				Shen.Portrait = fo.GetAirChampionPortrait(Shen);

				Shen.ShortName = new List<string> { "肾" };
				Shen.Skins = new List<Skin>() {
					new Skin(Shen,0,"Classic","经典"),
					new Skin(Shen,1,"Frozen","极寒"),
					new Skin(Shen,2,"Yellow Jacket","炎爆"),
					new Skin(Shen,3,"Surgeon","主治医师"),
					new Skin(Shen,4,"Blood Moon","鬼武者"),
					new Skin(Shen,5,"Warlord","战国大名"),
				};
                Shen.Spells = new List<Spell>() {
                    new Spell ("Shen_VorpalBlade","q"),
					new Spell ("Shen_Feint","w"),
					new Spell ("Shen_ShadowDash","e"),
					new Spell ("Shen_StandUnited","r"),
					new Spell ("Shen_KiStrike","t"),
                };
				Shen.Tags = new List<string>() { "近战", "物理", "坦克", "打野", "辅助" };
				cList.Add(Shen.EnName, Shen);

				//希瓦纳 龙血武姬
				Champion Shyvana = new Champion();
				Shyvana.EnName = "Shyvana";
				Shyvana.CnName = "希瓦纳";
				Shyvana.DefaultName = "龙血武姬";
				Shyvana.Portrait = fo.GetAirChampionPortrait(Shyvana);

				Shyvana.ShortName = new List<string> { "龙女" };
				Shyvana.Skins = new List<Skin>() {
					new Skin(Shyvana,0,"Classic","经典"),
					new Skin(Shyvana,1,"Ironscale","钢之逆鳞"),
					new Skin(Shyvana,2,"Boneclaw","骸骨之爪"),
					new Skin(Shyvana,3,"Darkflame","黯黑魔龙"),
				};
                Shyvana.Spells = new List<Spell>() {
                    new Spell ("ShyvanaTwinBite","q"),
					new Spell ("ShyvanaScorchedEarth","w"),
					new Spell ("ShyvanaFlameBreath","e"),
					new Spell ("ShyvanaDragonsDescent","r"),
					new Spell ("ShyvanaReinforcedScales","t"),
                };
				Shyvana.Tags = new List<string>() { "近战", "物理", "打野", "坦克" };
				cList.Add(Shyvana.EnName, Shyvana);

				//辛吉德 炼金术士
				Champion Singed = new Champion();
				Singed.EnName = "Singed";
				Singed.CnName = "辛吉德";
				Singed.DefaultName = "炼金术士";
				Singed.Portrait = fo.GetAirChampionPortrait(Singed);

				Singed.ShortName = new List<string> { "炼金" };
				Singed.Skins = new List<Skin>() {
					new Skin(Singed,0,"Classic","经典"),
					new Skin(Singed,1,"Riot Squad","防暴士兵"),
					new Skin(Singed,2,"Hextech","机械污染"),
					new Skin(Singed,3,"Surfer","冲浪高手"),
					new Skin(Singed,4,"Mad Scientist","科学狂人"),
					new Skin(Singed,5,"Augmented","炼金狂士"),
				};
                Singed.Spells = new List<Spell>() {
                    new Spell ("ChemicalMan_AcidSpray","q"),
					new Spell ("ChemMan_MegaAdhesive","w"),
					new Spell ("ChemicalMan_fling","e"),
					new Spell ("ChemicalMan_ChemicalRage","r"),
					new Spell ("ChemicalMan_EmpoweredBulwark","t"),
                };
				Singed.Tags = new List<string>() { "近战", "法术" };
				cList.Add(Singed.EnName, Singed);

				//塞恩 亡灵勇士
				Champion Sion = new Champion();
				Sion.EnName = "Sion";
				Sion.CnName = "塞恩";
				Sion.DefaultName = "亡灵勇士";
				Sion.Portrait = fo.GetAirChampionPortrait(Sion);

				Sion.ShortName = new List<string> { "亡灵", "UD", "ud" };
				Sion.Skins = new List<Skin>() {
					new Skin(Sion,0,"Classic","经典"),
					new Skin(Sion,1,"Hextech","钢铁终结者"),
					new Skin(Sion,2,"Barbarian","武仙座海格力斯"),
					new Skin(Sion,3,"Lumberjack","原野伐木工"),
					new Skin(Sion,4,"Warmonger","战争机器"),
				};
                Sion.Spells = new List<Spell>() {
                    new Spell ("Sion_CrypticGaze","q"),
					new Spell ("Sion_DeathsCaress","w"),
					new Spell ("Sion_EnrageOff","e"),
					new Spell ("Sion_Cannibalism","r"),
					new Spell ("Sion_FeelNoPain","t"),
                };
				Sion.Tags = new List<string>() { "近战", "物理", "法术", "推进" };
				cList.Add(Sion.EnName, Sion);

				//西瓦尔 战争女神
				Champion Sivir = new Champion();
				Sivir.EnName = "Sivir";
				Sivir.CnName = "西瓦尔";
				Sivir.DefaultName = "战争女神";
				Sivir.Portrait = fo.GetAirChampionPortrait(Sivir);

				Sivir.ShortName = new List<string> { "轮子妈" };
				Sivir.Skins = new List<Skin>() {
					new Skin(Sivir,0,"Classic","经典"),
					new Skin(Sivir,1,"Warrior Princess","战场公主"),
					new Skin(Sivir,2,"Spectacular","亮丽女神"),
					new Skin(Sivir,3,"Huntress","女猎手"),
					new Skin(Sivir,4,"Bandit","钢铁之心"),
					new Skin(Sivir,5,"PAX","创世纪"),
				};
                Sivir.Spells = new List<Spell>() {
                    new Spell ("Sivir_SpiralBlade","q"),
					new Spell ("Sivir_Ricochet","w"),
					new Spell ("Sivir_SpellBlock","e"),
					new Spell ("Sivir_Deadeye","r"),
					new Spell ("Sivir_Sprint","t"),
                };
				Sivir.Tags = new List<string>() { "远程", "物理", "推进" };
				cList.Add(Sivir.EnName, Sivir);

				//斯卡纳 水晶先锋(蝎子)
				Champion Skarner = new Champion();
				Skarner.EnName = "Skarner";
				Skarner.CnName = "斯卡纳";
				Skarner.DefaultName = "水晶先锋";
				Skarner.Portrait = fo.GetAirChampionPortrait(Skarner);

				Skarner.ShortName = new List<string> { "蝎子" };
				Skarner.Skins = new List<Skin>() {
					new Skin(Skarner,0,"Classic","经典"),
					new Skin(Skarner,1,"Sandscourge","沙暴巨蝎"),
					new Skin(Skarner,2,"Earthrune","远土之灵"),
				};
                Skarner.Spells = new List<Spell>() {
                    new Spell ("SkarnerVirulentSlash","q"),
					new Spell ("SkarnerExoskeleton","w"),
					new Spell ("SkarnerFracture","e"),
					new Spell ("SkarnerImpale","r"),
					new Spell ("SkarnerEnergize","t"),
                };
				Skarner.Tags = new List<string>() { "近战", "物理", "打野", "坦克" };
				cList.Add(Skarner.EnName, Skarner);



				//娑娜 琴瑟仙女
				Champion Sona = new Champion();
				Sona.EnName = "Sona";
				Sona.CnName = "娑娜";
				Sona.DefaultName = "琴瑟仙女";
				Sona.Portrait = fo.GetAirChampionPortrait(Sona);

				Sona.ShortName = new List<string> { "索娜", "琴女", "琴妈" };
				Sona.Skins = new List<Skin>() {
					new Skin(Sona,0,"Classic","经典"),
					new Skin(Sona,1,"Muse","缪斯女神"),
					new Skin(Sona,2,"Pentakill","五杀摇滚键盘手"),
					new Skin(Sona,3,"Silent Night","平安夜女神"),
					new Skin(Sona,4,"Guqin","古琴余韵"),
					new Skin(Sona,5,"Arcade","电玩女神"),
				};
                Sona.Spells = new List<Spell>() {
                    new Spell ("Sona_HymnofValor","q"),
					new Spell ("Sona_AriaofPerseverance","w"),
					new Spell ("Sona_SongofDiscord","e"),
					new Spell ("Sona_Crescendo","r"),
					new Spell ("Sona_PowerChordCharged","t"),
                };
				Sona.Tags = new List<string>() { "远程", "法术", "辅助" };
				cList.Add(Sona.EnName, Sona);

				//索拉卡 众星之子
				Champion Soraka = new Champion();
				Soraka.EnName = "Soraka";
				Soraka.CnName = "索拉卡";
				Soraka.DefaultName = "众星之子";
				Soraka.Portrait = fo.GetAirChampionPortrait(Soraka);

				Soraka.ShortName = new List<string> { "奶妈", "星妈", "星妹", "众星" };
				Soraka.Skins = new List<Skin>() {
					new Skin(Soraka,0,"Classic","经典"),
					new Skin(Soraka,1,"Dryad","森林女神"),
					new Skin(Soraka,2,"Divine","月光女神阿忒弥斯"),
				};
                Soraka.Spells = new List<Spell>() {
                    new Spell ("Soraka_Starcall","q"),
					new Spell ("Soraka_Bless","w"),
					new Spell ("Soraka_Wish","e"),
					new Spell ("Soraka_Purify","r"),
					new Spell ("Soraka_Consecration","t"),
                };
				Soraka.Tags = new List<string>() { "远程", "法术", "辅助" };
				cList.Add(Soraka.EnName, Soraka);

				//斯维因 策士统领
				Champion Swain = new Champion();
				Swain.EnName = "Swain";
				Swain.CnName = "斯维因";
				Swain.DefaultName = "策士统领";
				Swain.Portrait = fo.GetAirChampionPortrait(Swain);

				Swain.ShortName = new List<string> { "乌鸦", "瘸子" };
				Swain.Skins = new List<Skin>() {
					new Skin(Swain,0,"Classic","经典"),
					new Skin(Swain,1,"Northern Front","北领前线"),
					new Skin(Swain,2,"Bilgewater","海贼参谋"),
					new Skin(Swain,3,"Tyrant","绝代智将"),
				};
                Swain.Spells = new List<Spell>() {
                    new Spell ("SwainDecrepify","q"),
					new Spell ("SwainNevermove","w"),
					new Spell ("SwainTorment","e"),
					new Spell ("SwainRavenousFlock","r"),
					new Spell ("SwainCarrionRenewal","t"),
                };
				Swain.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Swain.EnName, Swain);

				//辛德拉 暗黑元首
				Champion Syndra = new Champion();
				Syndra.EnName = "Syndra";
				Syndra.CnName = "辛德拉";
				Syndra.DefaultName = "暗黑元首";
				Syndra.Portrait = fo.GetAirChampionPortrait(Syndra);

				Syndra.ShortName = new List<string> { "球女" };
				Syndra.Skins = new List<Skin>() {
					new Skin(Syndra,0,"Classic","经典"),
					new Skin(Syndra,1,"Justiciar","仲裁圣女"),
				};
                Syndra.Spells = new List<Spell>() {
                    new Spell ("SyndraQ","q"),
					new Spell ("SyndraW","w"),
					new Spell ("SyndraE","e"),
					new Spell ("SyndraR","r"),
					new Spell ("SyndraPassive","t"),
                };
				Syndra.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Syndra.EnName, Syndra);

				//泰隆 刀锋之影
				Champion Talon = new Champion();
				Talon.EnName = "Talon";
				Talon.CnName = "泰隆";
				Talon.DefaultName = "刀锋之影";
				Talon.Portrait = fo.GetAirChampionPortrait(Talon);

				Talon.ShortName = new List<string> { "男刀" };
				Talon.Skins = new List<Skin>() {
					new Skin(Talon,0,"Classic","经典"),
					new Skin(Talon,1,"Renegade","刺客信条"),
					new Skin(Talon,2,"Crimson Elite","血色精锐"),
					new Skin(Talon,3,"Dragonblade","银龙裁决"),
				};
				Talon.Tags = new List<string>() { "近战", "物理" };
                Talon.Spells = new List<Spell>() {
                    new Spell ("TalonNoxianDiplomacy","q"),
					new Spell ("TalonRake","w"),
					new Spell ("TalonCutthroat","e"),
					new Spell ("TalonShadowAssault","r"),
					new Spell ("TalonMercy","t"),
                };
				cList.Add(Talon.EnName, Talon);

				//塔里克 宝石骑士
				Champion Taric = new Champion();
				Taric.EnName = "Taric";
				Taric.CnName = "塔里克";
				Taric.DefaultName = "宝石骑士";
				Taric.Portrait = fo.GetAirChampionPortrait(Taric);

				Taric.ShortName = new List<string> { "宝石" };
				Taric.Skins = new List<Skin>() {
					new Skin(Taric,0,"Classic","经典"),
					new Skin(Taric,1,"Emerald","绿水晶光辉"),
					new Skin(Taric,2,"Armor of the Fifth Age","紫水晶意志"),
					new Skin(Taric,3,"Bloodstone","血精石诅咒"),
				};
				Taric.Tags = new List<string>() { "近战", "法术", "辅助", "坦克" };
                Taric.Spells = new List<Spell>() {
                    new Spell ("GemKnight_Imbue","q"),
					new Spell ("GemKnight_Shatter","w"),
					new Spell ("GemKnight_Dazzle","e"),
					new Spell ("GemKnight_Radiance","r"),
					new Spell ("GemKnight_Gemcraft","t"),
                };
				cList.Add(Taric.EnName, Taric);

				//提莫 迅捷斥候
				Champion Teemo = new Champion();
				Teemo.EnName = "Teemo";
				Teemo.CnName = "提莫";
				Teemo.DefaultName = "迅捷斥候";
				Teemo.Portrait = fo.GetAirChampionPortrait(Teemo);

				Teemo.ShortName = new List<string> { "提百万", "200W", "提莫队长", "大队长", "小莫", "萌主" };
				Teemo.Skins = new List<Skin>() {
					new Skin(Teemo,0,"Classic","经典"),
					new Skin(Teemo,1,"Happy Elf","圣诞开心鬼"),
					new Skin(Teemo,2,"Recon","军情五处"),
					new Skin(Teemo,3,"Badger","密林猎手"),
					new Skin(Teemo,4,"Astronaut","约德尔人的一大步"),
					new Skin(Teemo,5,"Cottontail","兔宝宝"),
					new Skin(Teemo,6,"Super","约德尔国队长"),
					new Skin(Teemo,7,"Panda","熊猫"),
				};
                Teemo.Spells = new List<Spell>() {
                    new Spell ("Teemo_TranquilizingShot","q"),
					new Spell ("Teemo_MoveQuick","w"),
					new Spell ("Teemo_PoisonedDart","e"),
					new Spell ("Bowmaster_ArchersMark","r"),
					new Spell ("Teemo_Camouflage","t"),
                };
				Teemo.Tags = new List<string>() { "远程", "物理", "法术", "辅助" };
				cList.Add(Teemo.EnName, Teemo);

                Champion Thresh = new Champion();
                Thresh.EnName = "Thresh";
                Thresh.CnName = "锤石";
                Thresh.DefaultName = "魂锁典狱长";
                Thresh.Portrait = fo.GetAirChampionPortrait(Thresh);
                Thresh.ShortName = new List<string> { };
                Thresh.Skins = new List<Skin>()
                {
                    new Skin(Thresh,0,"Classic","经典"),
                    new Skin(Thresh,1,"","深渊恐惧"),
                };
                Thresh.Spells = new List<Spell>() 
                {
                    new Spell("Thresh_Q","q"),
                    new Spell("Thresh_W","w"),
                    new Spell("Thresh_E","e"),
                    new Spell("Thresh_R","r"),
                    new Spell("Thresh_Passive","t"),
                };
                Thresh.Tags = new List<string>() { "远程","法术","辅助"};
                cList.Add(Thresh.EnName, Thresh);

				//崔丝塔娜 麦林炮手
				Champion Tristana = new Champion();
				Tristana.EnName = "Tristana";
				Tristana.CnName = "崔丝塔娜";
				Tristana.DefaultName = "麦林炮手";
				Tristana.Portrait = fo.GetAirChampionPortrait(Tristana);

				Tristana.ShortName = new List<string> { "小炮" };
				Tristana.Skins = new List<Skin>() {
					new Skin(Tristana,0,"Classic","经典"),
					new Skin(Tristana,1,"Riot Girl","粉色萝莉"),
					new Skin(Tristana,2,"Earnest Elf","圣诞精灵"),
					new Skin(Tristana,3,"Firefighter","烈焰雄心"),
					new Skin(Tristana,4,"Guerilla","游击队员"),
					new Skin(Tristana,5,"Buccaneer","约德尔海贼团"),
					new Skin(Tristana,6,"Rocketeer","火箭达人"),
				};
                Tristana.Spells = new List<Spell>() {
                    new Spell ("Tristana_HeadShot","q"),
					new Spell ("Tristana_RendingShot","w"),
					new Spell ("Tristana_DetonatingShot","e"),
					new Spell ("Tristana_BusterShot","r"),
					new Spell ("Tristana_DrawAbead","t"),
                };
				Tristana.Tags = new List<string>() { "远程", "物理", "推进" };
				cList.Add(Tristana.EnName, Tristana);

				//特朗德尔 诅咒巨魔
				Champion Trundle = new Champion();
				Trundle.EnName = "Trundle";
				Trundle.CnName = "特朗德尔";
				Trundle.DefaultName = "诅咒巨魔";
				Trundle.Portrait = fo.GetAirChampionPortrait(Trundle);

				Trundle.ShortName = new List<string> { "巨魔" };
				Trundle.Skins = new List<Skin>() {
					new Skin(Trundle,0,"Classic","经典"),
					new Skin(Trundle,1,"Lil' Slugger","里尔击球手"),
					new Skin(Trundle,2,"Junkyard","垃圾场"),
				};
                Trundle.Spells = new List<Spell>() {
                    new Spell ("Trundle_Bite","q"),
					new Spell ("Trundle_Contaminate","w"),
					new Spell ("Trundle_Pillar","e"),
					new Spell ("Trundle_Agony","r"),
					new Spell ("Trundle_Decompose","t"),
                };
				Trundle.Tags = new List<string>() { "近战", "物理", "打野", "坦克" };
				cList.Add(Trundle.EnName, Trundle);


				//泰达米尔 蛮族之王
				Champion Tryndamere = new Champion();
				Tryndamere.EnName = "Tryndamere";
				Tryndamere.CnName = "泰达米尔";
				Tryndamere.DefaultName = "蛮族之王";
				Tryndamere.Portrait = fo.GetAirChampionPortrait(Tryndamere);

				Tryndamere.ShortName = new List<string> { "蛮子", "蛮王", "蛮三刀" };
				Tryndamere.Skins = new List<Skin>() {
					new Skin(Tryndamere,0,"Classic","经典"),
					new Skin(Tryndamere,1,"Highland","勇敢的心"),
					new Skin(Tryndamere,2,"King","国王"),
					new Skin(Tryndamere,3,"Viking","诸神的黄昏"),
					new Skin(Tryndamere,4,"Demonblade","恶魔之刃"),
					new Skin(Tryndamere,5,"Sultan","苏丹"),
				};
                Tryndamere.Spells = new List<Spell>() {
                    new Spell ("DarkChampion_Bloodlust","q"),
					new Spell ("48thSlave_Pacify","w"),
					new Spell ("DarkChampion_Slash","e"),
					new Spell ("DarkChampion_EndlessRage","r"),
					new Spell ("DarkChampion_Fury","t"),
                };
				Tryndamere.Tags = new List<string>() { "近战", "物理", "打野" };
				cList.Add(Tryndamere.EnName, Tryndamere);

				//崔斯特 卡牌大师
				Champion TwistedFate = new Champion();
				TwistedFate.EnName = "TwistedFate";
				TwistedFate.CnName = "崔斯特";
				TwistedFate.DefaultName = "卡牌大师";
				TwistedFate.Portrait = fo.GetAirChampionPortrait(TwistedFate);

				TwistedFate.ShortName = new List<string> { "卡牌", "TF" };
				TwistedFate.Skins = new List<Skin>() {
					new Skin(TwistedFate,0,"Classic","经典"),
					new Skin(TwistedFate,1,"PAX","蓝色忧郁"),
					new Skin(TwistedFate,2,"Jack of Hearts","红桃杰克"),
					new Skin(TwistedFate,3,"The Magnificent","魔幻卡牌"),
					new Skin(TwistedFate,4,"Tango","探戈灵魂"),
					new Skin(TwistedFate,5,"High Noon","西部牛仔"),
					new Skin(TwistedFate,6,"Musketeer","皇家火枪手"),
					new Skin(TwistedFate,7,"Underworld","地底世界"),
				};
                TwistedFate.Spells = new List<Spell>() {
                    new Spell ("Cardmaster_PowerCard","q"),
					new Spell ("Cardmaster_FatesGambit","w"),
					new Spell ("Cardmaster_RapidToss","e"),
					new Spell ("Destiny_temp","r"),
					new Spell ("Cardmaster_SealFate","t"),
                };
				TwistedFate.Tags = new List<string>() { "远程", "法术", "推进" };
				cList.Add(TwistedFate.EnName, TwistedFate);

				//图奇 瘟疫之源
				Champion Twitch = new Champion();
				Twitch.EnName = "Twitch";
				Twitch.CnName = "图奇";
				Twitch.DefaultName = "瘟疫之源";
				Twitch.Portrait = fo.GetAirChampionPortrait(Twitch);

				Twitch.ShortName = new List<string> { "老鼠" };
				Twitch.Skins = new List<Skin>() {
					new Skin(Twitch,0,"Classic","经典"),
					new Skin(Twitch,1,"Kingpin","首领"),
					new Skin(Twitch,2,"Whistler","北风冻原"),
					new Skin(Twitch,3,"Medieval","都铎王朝"),
					new Skin(Twitch,4,"Gangster","黑金诱惑"),
					new Skin(Twitch,5,"Vandal","横行霸道"),
				};
                Twitch.Spells = new List<Spell>() {
                    new Spell ("Twitch_Ambush","q"),
					new Spell ("Twitch_VenomCask","w"),
					new Spell ("Twitch_Expunge","e"),
					new Spell ("Twitch_SprayAndPray","r"),
					new Spell ("Twitch_DeadlyVenom","t"),
                };
				Twitch.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Twitch.EnName, Twitch);

				//乌迪尔 野兽之灵
				Champion Udyr = new Champion();
				Udyr.EnName = "Udyr";
				Udyr.CnName = "乌迪尔";
				Udyr.DefaultName = "野兽之灵";
				Udyr.Portrait = fo.GetAirChampionPortrait(Udyr);

				Udyr.ShortName = new List<string> { "无敌2", "无敌二" };
				Udyr.Skins = new List<Skin>() {
					new Skin(Udyr,0,"Classic","经典"),
					new Skin(Udyr,1,"Black Belt","武力全开"),
					new Skin(Udyr,2,"Primal","四神之力"),
				};
                Udyr.Spells = new List<Spell>() {
                    new Spell ("Udyr_TigerStance","q"),
					new Spell ("Udyr_TurtleStance","w"),
					new Spell ("Udyr_BearStance","e"),
					new Spell ("Udyr_PhoenixStance","r"),
					new Spell ("Udyr_MonkeysAgility","t"),
                };
				Udyr.Tags = new List<string>() { "近战", "物理", "打野", "坦克" };
				cList.Add(Udyr.EnName, Udyr);

				//厄加特 首领之傲
				Champion Urgot = new Champion();
				Urgot.EnName = "Urgot";
				Urgot.CnName = "厄加特";
				Urgot.DefaultName = "首领之傲";
				Urgot.Portrait = fo.GetAirChampionPortrait(Urgot);

				Urgot.ShortName = new List<string> { "螃蟹" };
				Urgot.Skins = new List<Skin>() {
					new Skin(Urgot,0,"Classic","经典"),
					new Skin(Urgot,1,"Giant Enemy Crabgot","深渊巨蟹"),
					new Skin(Urgot,2,"Butcher","电锯狂人"),
					new Skin(Urgot,3,"Battlecast","战地机甲"),
				};
                Urgot.Spells = new List<Spell>() {
                    new Spell ("UrgotAcidHunter","q"),
					new Spell ("UrgotTerrorCapacitor","w"),
					new Spell ("UrgotCorrosiveCharge","e"),
					new Spell ("UrgotPositionReverser","r"),
					new Spell ("Urgot_Passive","t"),
                };
				Urgot.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Urgot.EnName, Urgot);

				//韦鲁斯 惩戒之箭
				Champion Varus = new Champion();
				Varus.EnName = "Varus";
				Varus.CnName = "韦鲁斯";
				Varus.DefaultName = "惩戒之箭";
				Varus.Portrait = fo.GetAirChampionPortrait(Varus);

				Varus.ShortName = new List<string> { "男弓" };
				Varus.Skins = new List<Skin>() {
					new Skin(Varus,0,"Classic","经典"),
					new Skin(Varus,1,"Blight","夜魔水晶"),
                    new Skin(Varus,2,"Arclight","苍穹之光"),
				};
                Varus.Spells = new List<Spell>() {
                    new Spell ("VarusQ","q"),
					new Spell ("VarusW","w"),
					new Spell ("VarusE","e"),
					new Spell ("VarusR","r"),
					new Spell ("VarusPassive","t"),
                };
				Varus.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Varus.EnName, Varus);


				//薇恩 暗影猎手
				Champion Vayne = new Champion();
				Vayne.EnName = "Vayne";
				Vayne.CnName = "薇恩";
				Vayne.DefaultName = "暗影猎手";
				Vayne.Portrait = fo.GetAirChampionPortrait(Vayne);

				Vayne.ShortName = new List<string> { "vn", "VN" };
				Vayne.Skins = new List<Skin>() {
					new Skin(Vayne,0,"Classic","经典"),
					new Skin(Vayne,1,"Vindicator","摩登骇客"),
					new Skin(Vayne,2,"Aristocrat","猎天使魔女"),
					new Skin(Vayne,3,"Dragonslayer","巨龙追猎者"),
					new Skin(Vayne,4,"Heartseeker","觅心猎手"),
				};
                Vayne.Spells = new List<Spell>() {
                    new Spell ("Vayne_Tumble","q"),
					new Spell ("Vayne_SilveredBolts","w"),
					new Spell ("Vayne_Condemn","e"),
					new Spell ("Vayne_Inquisition","r"),
					new Spell ("Vayne_NightHunter","t"),
                };
				Vayne.Tags = new List<string>() { "远程", "物理" };
				cList.Add(Vayne.EnName, Vayne);

				//维嘉 邪恶小法师
				Champion Veigar = new Champion();
				Veigar.EnName = "Veigar";
				Veigar.CnName = "维嘉";
				Veigar.DefaultName = "邪恶小法师";
				Veigar.Portrait = fo.GetAirChampionPortrait(Veigar);

				Veigar.ShortName = new List<string> { "小法" };
				Veigar.Skins = new List<Skin>() {
					new Skin(Veigar,0,"Classic","经典"),
					new Skin(Veigar,1,"White Mage","白魔法师"),
					new Skin(Veigar,2,"Curling Veigar","冰壶选手"),
					new Skin(Veigar,3,"Greybeard","灰胡子魔法师"),
					new Skin(Veigar,4,"Leprechaun","绿野仙踪"),
					new Skin(Veigar,5,"Baron","魔导绅士"),
					new Skin(Veigar,6,"Superb Villain","穿着正装的恶魔"),
                    new Skin(Veigar,7,"","邪恶圣诞老人"),
				};
                Veigar.Spells = new List<Spell>() {
                    new Spell ("VeigarBalefulStrike","q"),
					new Spell ("VeigarDarkMatter","w"),
					new Spell ("VeigarEventHorizon","e"),
					new Spell ("VeigarPrimordialBurst","r"),
					new Spell ("Veigar_Entropy","t"),
                };
				Veigar.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Veigar.EnName, Veigar);

                Champion Vi = new Champion();
                Vi.EnName = "Vi";
                Vi.CnName = "蔚";
                Vi.DefaultName = "皮城执法者";
                Vi.Portrait = fo.GetAirChampionPortrait(Vi);
                Vi.ShortName = new List<string>() { "wei","喂","拳","拳头","拳女","城管"};
                Vi.Skins = new List<Skin>() {
                    new Skin(Vi,0,"Classic","经典"),
                    new Skin(Vi,1,"","霓虹杀拳"),
                };
                Vi.Spells = new List<Spell>() {
                    new Spell("ViQ","q"),
                    new Spell("ViW","w"),
                    new Spell("ViE","e"),
                    new Spell("ViR","r"),
                    new Spell("ViPassive","t"),
                };
                Vi.Tags = new List<string>() { "近战","物理","坦克","打野"};
                cList.Add(Vi.EnName, Vi);


				//维克托 机械先驱
				Champion Viktor = new Champion();
				Viktor.EnName = "Viktor";
				Viktor.CnName = "维克托";
				Viktor.DefaultName = "机械先驱";
				Viktor.Portrait = fo.GetAirChampionPortrait(Viktor);

				Viktor.ShortName = new List<string> { "三只手" };
				Viktor.Skins = new List<Skin>() {
					new Skin(Viktor,0,"Classic","经典"),
					new Skin(Viktor,1,"Full Machine","全金属狂潮"),
					new Skin(Viktor,2,"Prototype","初号机"),
				};
                Viktor.Spells = new List<Spell>() {
                    new Spell ("ViktorPowerTransfer","q"),
					new Spell ("ViktorGravitonField","w"),
					new Spell ("ViktorDeathRay","e"),
					new Spell ("ViktorChaosStorm","r"),
					new Spell ("ViktorEvolvingTechnology","t"),
                };
				Viktor.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Viktor.EnName, Viktor);


				//弗拉基米尔 猩红收割者
				Champion Vladimir = new Champion();
				Vladimir.EnName = "Vladimir";
				Vladimir.CnName = "弗拉基米尔";
				Vladimir.DefaultName = "猩红收割者";
				Vladimir.Portrait = fo.GetAirChampionPortrait(Vladimir);

				Vladimir.ShortName = new List<string> { "吸血鬼", "大姨妈" };
				Vladimir.Skins = new List<Skin>() {
					new Skin(Vladimir,0,"Classic","经典"),
					new Skin(Vladimir,1,"Count","弗拉基米尔伯爵"),
					new Skin(Vladimir,2,"Marquis","弗拉基米尔侯爵"),
					new Skin(Vladimir,3,"Nosferatu","诺斯费拉图"),
					new Skin(Vladimir,4,"Vandal","霹雳游侠"),
					new Skin(Vladimir,5,"Blood Lord","鲜血领主"),
				};
                Vladimir.Spells = new List<Spell>() {
                    new Spell ("Vladimir_Transfusion","q"),
					new Spell ("Vladimir_SanguinePool","w"),
					new Spell ("Vladimir_TidesofBlood","e"),
					new Spell ("Vladimir_Hemoplague","r"),
					new Spell ("Vladimir_BloodGorged","t"),
                };
				Vladimir.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Vladimir.EnName, Vladimir);


				//沃利贝尔 雷霆咆哮
				Champion Volibear = new Champion();
				Volibear.EnName = "Volibear";
				Volibear.CnName = "沃利贝尔";
				Volibear.DefaultName = "雷霆咆哮";
				Volibear.Portrait = fo.GetAirChampionPortrait(Volibear);

				Volibear.ShortName = new List<string> { "狗熊", "熊","白熊" };
				Volibear.Skins = new List<Skin>() {
					new Skin(Volibear,0,"Classic","经典"),
					new Skin(Volibear,1,"Tunder Lord","雷霆领主"),
					new Skin(Volibear,2,"Northern Strom","北地风暴"),
				};
                Volibear.Spells = new List<Spell>() {
                    new Spell ("VolibearQ","q"),
					new Spell ("VolibearW","w"),
					new Spell ("VolibearE","e"),
					new Spell ("VolibearR","r"),
					new Spell ("VolibearPassive","t"),
                };
				Volibear.Tags = new List<string>() { "近战", "物理", "辅助", "坦克" };
				cList.Add(Volibear.EnName, Volibear);

				//沃里克 嗜血猎手
				Champion Warwick = new Champion();
				Warwick.EnName = "Warwick";
				Warwick.CnName = "沃里克";
				Warwick.DefaultName = "嗜血猎手";
				Warwick.Portrait = fo.GetAirChampionPortrait(Warwick);

				Warwick.ShortName = new List<string> { "狼人" };
				Warwick.Skins = new List<Skin>() {
					new Skin(Warwick,0,"Classic","经典"),
					new Skin(Warwick,1,"Grey","暗影"),
					new Skin(Warwick,2,"Urf the Manate","披着海牛的狼"),
					new Skin(Warwick,3,"Big Bad","狼外婆"),
					new Skin(Warwick,4,"Tundra Hunter","冻原猎手"),
					new Skin(Warwick,5,"Feral","嗜血狂暴"),
					new Skin(Warwick,6,"Firefang","火牙狼人"),
					new Skin(Warwick,7,"Hyena","荒野豺狼"),
				};
				Warwick.Tags = new List<string>() { "近战", "物理", "打野" };
                Warwick.Spells = new List<Spell>() {
                    new Spell ("Wolfman_SeverArmor","q"),
					new Spell ("Wolfman_FrenziedStrikes","w"),
					new Spell ("Wolfman_BloodScent","e"),
					new Spell ("Wolfman_InfiniteDuress","r"),
					new Spell ("Warwick_InnerHunger","t"),
                };
				cList.Add(Warwick.EnName, Warwick);

				//泽拉斯 远古巫灵(棺材板)
				Champion Xerath = new Champion();
				Xerath.EnName = "Xerath";
				Xerath.CnName = "泽拉斯";
				Xerath.DefaultName = "远古巫灵";
				Xerath.Portrait = fo.GetAirChampionPortrait(Xerath);

				Xerath.ShortName = new List<string> { "棺材板" };
				Xerath.Skins = new List<Skin>() {
					new Skin(Xerath,0,"Classic","经典"),
					new Skin(Xerath,1,"Runeborn","符文生物"),
					new Skin(Xerath,2,"Battlecast","战地法师"),
					new Skin(Xerath,3,"Scorched Earth","枯萎之壤"),
				};
                Xerath.Spells = new List<Spell>() {
                    new Spell ("Xerath_Arcanopulse","q"),
					new Spell ("Xerath_LocusOfPower","w"),
					new Spell ("Xerath_MageChains","e"),
					new Spell ("Xerath_ArcaneBarrage","r"),
					new Spell ("Xerath_AscendedForm","t"),
                };
				Xerath.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Xerath.EnName, Xerath);

				//赵信 德邦总管
				Champion XinZhao = new Champion();
				XinZhao.EnName = "XinZhao";
				XinZhao.CnName = "赵信";
				XinZhao.DefaultName = "德邦总管";
				XinZhao.Portrait = fo.GetAirChampionPortrait(XinZhao);

				XinZhao.ShortName = new List<string> { "赵公公", "德邦" };
				XinZhao.Skins = new List<Skin>() {
					new Skin(XinZhao,0,"Classic","经典"),
					new Skin(XinZhao,1,"Commando","特战先锋"),
					new Skin(XinZhao,2,"Imperial","皇家守卫"),
					new Skin(XinZhao,3,"Viscero","绞肉机角斗士"),
					new Skin(XinZhao,4,"Winged Hussar","翼骑统领"),
                    new Skin(XinZhao,5,"","赵云 子龙"),
				};
                XinZhao.Spells = new List<Spell>() {
                    new Spell ("XinZhao_ThreeTalon","q"),
					new Spell ("XinZhao_BattleCry","w"),
					new Spell ("XinZhao_Charge","e"),
					new Spell ("XinZhao_CrescentSweep","r"),
					new Spell ("XinZhao_TirelessWarrior","t"),
                };
				XinZhao.Tags = new List<string>() { "近战", "物理", "打野" };
				cList.Add(XinZhao.EnName, XinZhao);

				//约里克 掘墓者
				Champion Yorick = new Champion();
				Yorick.EnName = "Yorick";
				Yorick.CnName = "约里克";
				Yorick.DefaultName = "掘墓者";
				Yorick.Portrait = fo.GetAirChampionPortrait(Yorick);

				Yorick.ShortName = new List<string> { "掘墓", "挖坟" };
				Yorick.Skins = new List<Skin>() {
					new Skin(Yorick,0,"Classic","经典"),
					new Skin(Yorick,1,"Undertaker","地狱送葬"),
					new Skin(Yorick,2,"Pentakill","五杀摇滚贝斯手"),
				};
                Yorick.Spells = new List<Spell>() {
                    new Spell ("YorickOmenOfWar","q"),
					new Spell ("YorickOmenOfPestilence","w"),
					new Spell ("YorickOmenOfFamine","e"),
					new Spell ("YorickOmenOfDeath","r"),
					new Spell ("YorickUnholyCovenant","t"),
                };
				Yorick.Tags = new List<string>() { "近战", "法术", "坦克" };
				cList.Add(Yorick.EnName, Yorick);

                //劫 影流之主
                Champion Zed = new Champion();
                Zed.EnName = "Zed";
                Zed.CnName = "劫";
                Zed.DefaultName = "影流之主";
                Zed.Portrait = fo.GetAirChampionPortrait(Zed);

                Zed.ShortName = new List<string> { };
                Zed.Skins = new List<Skin>() {
                    new Skin(Zed,0,"Classic","经典"),
                    new Skin(Zed,1,"Bladestorm","剑刃风暴"),
                };
                Zed.Spells = new List<Spell>() {
                    new Spell("shadowninja_Q","q"),
                    new Spell("shadowninja_w","w"),
                    new Spell("shadowninja_E","e"),
                    new Spell("shadowninja_R","r"),
                    new Spell("shadowninja_P","t"),
                };
                Zed.Tags = new List<string>() {"近战","物理" };
                cList.Add(Zed.EnName, Zed);

				//吉格斯 爆破鬼才
				Champion Ziggs = new Champion();
				Ziggs.EnName = "Ziggs";
				Ziggs.CnName = "吉格斯";
				Ziggs.DefaultName = "爆破鬼才";
				Ziggs.Portrait = fo.GetAirChampionPortrait(Ziggs);

				Ziggs.ShortName = new List<string> { "炸弹人", "爆破" };
				Ziggs.Skins = new List<Skin>() {
					new Skin(Ziggs,0,"Classic","经典"),
					new Skin(Ziggs,1,"Mad Scientist","科学狂人"),
					new Skin(Ziggs,2,"Major","少校"),
					new Skin(Ziggs,3,"Pool Party","泳池派对"),
                    new Skin(Ziggs,4,"","雪球也能爆炸!"),
				};
                Ziggs.Spells = new List<Spell>() {
                    new Spell ("ZiggsQ","q"),
					new Spell ("ZiggsW","w"),
					new Spell ("ZiggsE","e"),
					new Spell ("ZiggsR","r"),
					new Spell ("ZiggsPassiveReady","t"),
                };
				Ziggs.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Ziggs.EnName, Ziggs);

				//基兰 时光守护者
				Champion Zilean = new Champion();
				Zilean.EnName = "Zilean";
				Zilean.CnName = "基兰";
				Zilean.DefaultName = "时光守护者";
				Zilean.Portrait = fo.GetAirChampionPortrait(Zilean);

				Zilean.ShortName = new List<string> { "时光", "时光老头" };
				Zilean.Skins = new List<Skin>() {
					new Skin(Zilean,0,"Classic","经典"),
					new Skin(Zilean,1,"Old Saint","圣诞狂欢"),
					new Skin(Zilean,2,"Groovy","嘻哈精神"),
					new Skin(Zilean,3,"Shurima Desert","遗迹守护者"),
					new Skin(Zilean,4,"Time Machine","时间机器"),
				};
                Zilean.Spells = new List<Spell>() {
                    new Spell ("Chronokeeper_Chronoblast","q"),
					new Spell ("Chronokeeper_Recall","w"),
					new Spell ("Chronokeeper_Slow","e"),
					new Spell ("Chronokeeper_Timetwister","r"),
					new Spell ("Chronokeeper_Haste","t"),
                };
				Zilean.Tags = new List<string>() { "远程", "法术" };
				cList.Add(Zilean.EnName, Zilean);


				//婕拉 荆棘之兴
				Champion Zyra = new Champion();
				Zyra.EnName = "Zyra";
				Zyra.CnName = "婕拉";
				Zyra.DefaultName = "荆棘之兴";
				Zyra.Portrait = fo.GetAirChampionPortrait(Zyra);

				Zyra.ShortName = new List<string> { "荆棘", "花女" };
				Zyra.Skins = new List<Skin>() {
					new Skin(Zyra,0,"Classic","经典"),
					new Skin(Zyra,1,"Wildfire","野火之藤"),
				};
				Zyra.Tags = new List<string>() { "远程", "法术", "辅助", "推进" };
                Zyra.Spells = new List<Spell>() {
                    new Spell ("ZyraQ","q"),
					new Spell ("ZyraW","w"),
					new Spell ("ZyraE","e"),
					new Spell ("ZyraR","r"),
					new Spell ("ZyraP","t"),
                };
				cList.Add(Zyra.EnName, Zyra);


				return cList;
			}

		   public Champion GetChampionById(string id)
		   {
			   Dictionary<string, Champion> championList = getChampionList();
			   Champion champion = new Champion();
			   champion = championList[id];
			   return champion;
		   }

		   public Champion GetChampionByKid(string keyId)
		   {
			   Dictionary<string, Champion> championList = getChampionList();
			   Champion champion = new Champion();
			   foreach (KeyValuePair<string, Champion> pair in championList)
			   {
				   if (keyId == pair.Value.DefaultName)
				   {
					   champion = pair.Value;
				   }
			   }

			   return champion;
		   }



		   public static Dictionary<string, Champion> GetChampionList()
		   {
			   Dictionary<string, Champion> championList = getChampionList();
			   return championList;
		   }

		   public List<Champion> GetNoKeyChampionList()
		   {
			   List<Champion> list = new List<Champion>();
			   Dictionary<string, Champion> championList = getChampionList();
			   foreach (KeyValuePair<string, Champion> pair in championList)
			   {
				   list.Add(pair.Value);
			   }
			   return list;
		   }

		   public List<Champion> GetChampionsByTag(List<string> tags)
		   {
			   Dictionary<string, Champion> cList = getChampionList();
			   List<Champion> list = new List<Champion>();
			   list.Clear();
			   foreach (KeyValuePair<string, Champion> pair in cList)
			   {
				   for (int i = 0; i < pair.Value.Tags.Count; i++)
				   {
					   for (int j = 0; j < tags.Count; j++)
					   {
						   if (pair.Value.Tags.Contains(tags[j]))
						   {
							   if (!list.Contains(pair.Value))
							   {
								   list.Add(pair.Value);
							   }
						   }

					   }

				   }
			   }
			   foreach (KeyValuePair<string, Champion> pair in cList)
			   {
				   for (int i = 0; i < pair.Value.Tags.Count; i++)
				   {
					   for (int j = 0; j < tags.Count; j++)
					   {
						   if (!pair.Value.Tags.Contains(tags[j]))
						   {
							   if (list.Contains(pair.Value))
							   {
								   list.Remove(pair.Value);
							   }
						   }
					   }
				   }
			   }

			   return list;
		   }


		   public List<Champion> GetChampionsByKeyWord(string keyword)
		   {
			   Dictionary<string, Champion> cList = getChampionList();
			   List<Champion> list = new List<Champion>();
			   list.Clear();
			   foreach (KeyValuePair<string, Champion> pair in cList)
			   {
				   if (pair.Value.CnName.Contains(keyword))
				   {
					   if (!list.Contains(pair.Value))
					   {
						   list.Add(pair.Value);
					   }
				   }
				   if (pair.Value.EnName.ToLower().Contains(keyword.ToLower()))
				   {
					   if (!list.Contains(pair.Value))
					   {
						   list.Add(pair.Value);
					   }
				   }
				   if (pair.Value.DefaultName.Contains(keyword))
				   {
					   if (!list.Contains(pair.Value))
					   {
						   list.Add(pair.Value);
					   }
				   }
				   if (pair.Value.ShortName != null && pair.Value.ShortName.Count > 0)
				   {
					   if (pair.Value.ShortName.Contains<string>(keyword.ToLower()))
					   {
						   if (!list.Contains(pair.Value))
						   {
							   list.Add(pair.Value);
						   }
					   }
				   }
			   }
			   return list;
		   }

	}


}

