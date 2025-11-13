using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using common;
using core.manager;
//using res;
//
//using UnityEngine.UI;
//using YooAsset;

namespace core.config
{
	// Token: 0x02001E9A RID: 7834
	public class ClientConfig
	{
		// Token: 0x0600E967 RID: 59751 RVA: 0x003E4BBA File Offset: 0x003E2DBA
		public static string GetScenePath(string name)
		{
			return "Assets/Game/Scenes/" + name + ".unity";
		}

		// Token: 0x0600E968 RID: 59752 RVA: 0x003E4BCC File Offset: 0x003E2DCC
		public static string GetPetAnimatorPath(string id)
		{
			//"Assets/Pets/" + id + ".prefab";
			//if (DeviceInfoManager.maxTextureSize <= DeviceInfoManager.MAX_TEXTURE_SIZE_LOW)
			//{
			//	string text = "Assets/Pets/" + id + "_small.prefab";
			//	if (ResManager.Instance.getPetAnimatePackage().CheckLocationValid(text))
			//	{
			//		return text;
			//	}
			//}
			return "Assets/Pets/" + id + ".prefab";
		}

		// Token: 0x0600E969 RID: 59753 RVA: 0x003E4C2B File Offset: 0x003E2E2B
		public static string getPetAttributeIcon(int args)
		{
			if (args >= ClientConfig.en_s.Length)
			{
				return string.Empty;
			}
			return "Assets/Art/Ui/common/common_" + ClientConfig.en_s[args] + ".png";
		}

		// Token: 0x0600E96A RID: 59754 RVA: 0x003E4C53 File Offset: 0x003E2E53
		public static string getPetAttributeIcon(string args)
		{
			if (!ClientConfig.en_s.Contains(args))
			{
				return string.Empty;
			}
			return "Assets/Art/Ui/common/common_" + args + ".png";
		}

		// Token: 0x0600E96B RID: 59755 RVA: 0x003E4C78 File Offset: 0x003E2E78
		public static string getCommonIcon(string name, string folder = "")
		{
			return string.Concat(new string[]
			{
				"Assets/Art/Ui/common",
				folder,
				"/",
				name,
				".png"
			});
		}

		// Token: 0x0600E96C RID: 59756 RVA: 0x003E4CA8 File Offset: 0x003E2EA8
		public static string getItemIcon(int id)
		{
			string text = ResetableSingleTon<ItemXMLInfo>.Ins.getIconURL(id, 1);
			if (string.IsNullOrEmpty(text))
			{
				text = string.Format("Assets/Art/Ui/assets/item/petItem/icon/{0}.png", id);
			}
			return text;
		}

		// Token: 0x0600E96D RID: 59757 RVA: 0x003E4CDC File Offset: 0x003E2EDC
		public static string getPetSkillIcon(string args)
		{
			return "Assets/Art/Ui/common/common_petSkill_tag" + args + ".png";
		}

		// Token: 0x0600E96E RID: 59758 RVA: 0x003E4CEE File Offset: 0x003E2EEE
		public static string getSorensenBossPath(int id)
		{
			return string.Format("Assets/Art/Ui/assets/boss/{0}.png", id);
		}

		// Token: 0x0600E96F RID: 59759 RVA: 0x003E4D00 File Offset: 0x003E2F00
		public static string getGemPath(int id)
		{
			return string.Format("Assets/Art/Ui/assets/countermark/gem/{0}.png", id);
		}

		// Token: 0x0600E970 RID: 59760 RVA: 0x003E4D12 File Offset: 0x003E2F12
		public static string getPetTagIcon(string args)
		{
			return "Assets/Art/Ui/common/pet_bag_tag" + args + ".png";
		}

		// Token: 0x0600E971 RID: 59761 RVA: 0x003E4D24 File Offset: 0x003E2F24
		public static string getBytesPath(string name)
		{
			return "Assets/Game/Configs/bytes/" + name + ".bytes";
		}

		// Token: 0x0600E972 RID: 59762 RVA: 0x003E4D36 File Offset: 0x003E2F36
		public static string getCustomConfigPath(string name, string extends)
		{
			return "Assets/Game/Configs/clientCustom/" + name + "." + extends;
		}

		// Token: 0x0600E973 RID: 59763 RVA: 0x003E4D49 File Offset: 0x003E2F49
		public static string getCommonSpritePath(string name)
		{
			return "Assets/Art/Ui/common/" + name + ".png";
		}

		// Token: 0x0600E974 RID: 59764 RVA: 0x003E4D5B File Offset: 0x003E2F5B
		public static string getCommonPrefabPath(string name)
		{
			return "Assets/Game/UI/common/" + name + ".prefab";
		}

		// Token: 0x0600E975 RID: 59765 RVA: 0x003E4D6D File Offset: 0x003E2F6D
		public static string getMapPrefabPath(string mapId)
		{
			return "Assets/Game/Prefabs/Maps/Map" + mapId + "Skin.prefab";
		}

		// Token: 0x0600E976 RID: 59766 RVA: 0x003E4D7F File Offset: 0x003E2F7F
		public static string getMarkPath(int id)
		{
			return string.Format("{0}assets/countermark/icon/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E977 RID: 59767 RVA: 0x003E4D96 File Offset: 0x003E2F96
		public static string getModulePrefabPath(string prefabName, string moduleName = null)
		{
			if (string.IsNullOrEmpty(moduleName))
			{
				moduleName = prefabName;
			}
			return string.Concat(new string[]
			{
				"Assets/Game/UI/",
				moduleName,
				"/",
				prefabName,
				".prefab"
			});
		}

		// Token: 0x0600E978 RID: 59768 RVA: 0x003E4DCE File Offset: 0x003E2FCE
		public static string getModulePath(string moduleName)
		{
			return "Assets/Game/UI/" + moduleName;
		}

		// Token: 0x0600E979 RID: 59769 RVA: 0x003E4DDB File Offset: 0x003E2FDB
		public static string getModuleAtlasPath(string moduleName, string atlasName = "images")
		{
			return string.Concat(new string[]
			{
				"Assets/Game/UI/",
				moduleName,
				"/",
				atlasName,
				".spriteatlas"
			});
		}

		// Token: 0x0600E97A RID: 59770 RVA: 0x003E4E08 File Offset: 0x003E3008
		public static string getModuleAtlasPath(int moduleId, string atlasName = "images")
		{
			IModuleInfo item = ResetableSingleTon<Module>.Ins.getItem(moduleId);
			return string.Concat(new string[]
			{
				"Assets/Game/UI/",
				item.moduleName,
				"/",
				atlasName,
				".spriteatlas"
			});
		}

		// Token: 0x0600E97B RID: 59771 RVA: 0x003E4E53 File Offset: 0x003E3053
		public static string getModuleDynamicPath(string moduleName, string res)
		{
			return "Assets/Game/UI/" + moduleName + "/dynamic/" + res;
		}

		// Token: 0x0600E97C RID: 59772 RVA: 0x003E4E68 File Offset: 0x003E3068
		public static string getModuleArtPath(string resName, string moduleName, string folderName = "images")
		{
			if (resName.IndexOf(".") == -1)
			{
				resName += ".png";
			}
			if (string.IsNullOrEmpty(folderName))
			{
				return "Assets/Art/Ui/modules/" + moduleName + "/" + resName;
			}
			return string.Concat(new string[]
			{
				"Assets/Art/Ui/modules/",
				moduleName,
				"/",
				folderName,
				"/",
				resName
			});
		}

		// Token: 0x0600E97D RID: 59773 RVA: 0x003E4ED9 File Offset: 0x003E30D9
		public static string getBackgroundArtPath(string resName)
		{
			if (resName.IndexOf(".") == -1)
			{
				resName += ".png";
			}
			return "Assets/Art/Ui/Background/" + resName;
		}

		// Token: 0x0600E97E RID: 59774 RVA: 0x003E4F01 File Offset: 0x003E3101
		public static string getBattleEffectIcon(int id, int level = 0)
		{
			if (level > 0)
			{
				return string.Format("{0}assets/battleEffect/abnormal/{1}_{2}.png", "Assets/Art/Ui/", id, level);
			}
			return string.Format("{0}assets/battleEffect/abnormal/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E97F RID: 59775 RVA: 0x003E4F38 File Offset: 0x003E3138
		public static string getBossEffectIcon(int id)
		{
			return string.Format("{0}assets/battleEffect/bossEffect/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E980 RID: 59776 RVA: 0x003E4F4F File Offset: 0x003E314F
		public static string getPetAdvBackPath(int taskId)
		{
			return string.Format("{0}assets/petAdvBack/{1}/", "Assets/Art/Ui/", taskId);
		}

		// Token: 0x0600E981 RID: 59777 RVA: 0x003E4F66 File Offset: 0x003E3166
		public static string getBuffIcon(int id, int iconIndex = -1)
		{
			if (iconIndex > 0)
			{
				return string.Format("{0}assets/battleEffect/signBuff/{1}_{2}.png", "Assets/Art/Ui/", id, iconIndex);
			}
			return string.Format("{0}assets/battleEffect/signBuff/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E982 RID: 59778 RVA: 0x003E4F9D File Offset: 0x003E319D
		public static string getCommonBuffIcon(int id)
		{
			return string.Format("{0}assets/battleEffect/buff/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E983 RID: 59779 RVA: 0x003E4FB4 File Offset: 0x003E31B4
		public static string getBuffHeadFrameIcon(int id, int iconIndex = -1)
		{
			if (iconIndex > 0)
			{
				return string.Format("{0}assets/battleEffect/headFrame/{1}_{2}.png", "Assets/Art/Ui/", id, iconIndex);
			}
			return string.Format("{0}assets/battleEffect/headFrame/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E984 RID: 59780 RVA: 0x003E4FEC File Offset: 0x003E31EC
		public static string getAbilityIcon(int id, bool up)
		{
			string arg = "up";
			if (!up)
			{
				arg = "down";
			}
			return string.Format("{0}assets/battleEffect/ability/{1}/{2}.png", "Assets/Art/Ui/", arg, id);
		}

		// Token: 0x0600E985 RID: 59781 RVA: 0x003E5020 File Offset: 0x003E3220
		public static string getAbilityNumIcon(int num, bool up)
		{
			string arg = "up";
			if (!up)
			{
				arg = "down";
			}
			return string.Format("{0}assets/battleEffect/ability/number/{1}_{2}.png", "Assets/Art/Ui/", arg, num);
		}

		// Token: 0x0600E986 RID: 59782 RVA: 0x003E5052 File Offset: 0x003E3252
		public static string getElvenKingSmall(int id)
		{
			return string.Format("{0}assets/elvenKingTrial/small/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E987 RID: 59783 RVA: 0x003E5069 File Offset: 0x003E3269
		public static string getElvenKingBig(int id)
		{
			return string.Format("{0}assets/elvenKingTrial/big/pveElvenKingTrialFight_pet_{1}.png", "Assets/Art/Ui/", id - 1);
		}

		// Token: 0x0600E988 RID: 59784 RVA: 0x003E5082 File Offset: 0x003E3282
		public static string getNpcHeadIcon(int id)
		{
			return string.Format("{0}assets/npc/head/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E989 RID: 59785 RVA: 0x003E5099 File Offset: 0x003E3299
		public static string getResPath(string value)
		{
			return "Assets/Art/Ui/" + value;
		}

		// Token: 0x0600E98A RID: 59786 RVA: 0x003E50A8 File Offset: 0x003E32A8
		public static string getPetHeadPath(int id, int ct = 0, int skinId = 0)
		{
			//int petId = id;
			//id = PetIdTransform.getPetId(id, ct, false);
			//id = ResetableSingleTon<PetXMLInfo>.Ins.getRealId(id);
			//if (skinId > 0)
			//{
			//	id = ResetableSingleTon<PetSkinXMLInfo>.Ins.getSkinPetId(skinId, petId);
			//}
			return string.Format("{0}assets/pet/head/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E98B RID: 59787 RVA: 0x003E50F5 File Offset: 0x003E32F5
		public static string getPeakjihadLevelPath(int id)
		{
			return string.Format("{0}assets/peakJihad/level/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E98C RID: 59788 RVA: 0x003E510C File Offset: 0x003E330C
		public static string getClothSwfDir(string id)
		{
			return "Assets/Art/Ui/assets/item/cloth/swf/" + id + "/";
		}

		// Token: 0x0600E98D RID: 59789 RVA: 0x003E511E File Offset: 0x003E331E
		public static string getClothSpinePath(string id)
		{
			return string.Concat(new string[]
			{
				"Assets/Game/SpineData/cloths/",
				id,
				"/",
				id,
				"_SkeletonData.asset"
			});
		}

		// Token: 0x0600E98E RID: 59790 RVA: 0x003E514B File Offset: 0x003E334B
		public static string getWildMonsterSpinePath(string id)
		{
			return string.Concat(new string[]
			{
				"Assets/Game/SpineData/wildMonster/",
				id,
				"/",
				id,
				"_SkeletonData.asset"
			});
		}

		// Token: 0x0600E98F RID: 59791 RVA: 0x003E5178 File Offset: 0x003E3378
		public static string GetPeakjihadMiniLevelPath(int id)
		{
			return string.Format("{0}assets/peakJihad/mini_level/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E990 RID: 59792 RVA: 0x003E518F File Offset: 0x003E338F
		public static string gethideSkillicon()
		{
			return "Assets/Art/Ui/common/common_fifth_skill_icon.png";
		}

		// Token: 0x0600E991 RID: 59793 RVA: 0x003E5196 File Offset: 0x003E3396
		public static string getClothSmallIcon(int id)
		{
			return string.Format("{0}assets/item/cloth/icon/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E992 RID: 59794 RVA: 0x003E51AD File Offset: 0x003E33AD
		public static string getclothicon(int id)
		{
			return string.Format("{0}assets/item/cloth/prev/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E993 RID: 59795 RVA: 0x003E51C4 File Offset: 0x003E33C4
		public static string getDoodleIcon(int id)
		{
			return string.Format("{0}assets/item/doodle/doodleIcon/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E994 RID: 59796 RVA: 0x003E51DB File Offset: 0x003E33DB
		public static string getDoodleIcon2(int id)
		{
			return string.Format("{0}assets/item/doodle/icon/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E995 RID: 59797 RVA: 0x003E51F2 File Offset: 0x003E33F2
		public static string getMountIcon(int id)
		{
			return string.Format("{0}assets/flypet/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E996 RID: 59798 RVA: 0x003E5209 File Offset: 0x003E3409
		public static string getMountAni(int id)
		{
			return "Assets/Art/Ui/assets/flyPetAni/" + id.ToString();
		}

		// Token: 0x0600E997 RID: 59799 RVA: 0x003E521C File Offset: 0x003E341C
		public static string getclothJson()
		{
			return "Assets/Art/Ui/assets/item/cloth/prev/config.json";
		}

		// Token: 0x0600E998 RID: 59800 RVA: 0x003E5223 File Offset: 0x003E3423
		public static string getpettypeticon(int id)
		{
			return string.Format("{0}assets/PetType/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E999 RID: 59801 RVA: 0x003E523A File Offset: 0x003E343A
		public static string getpettypeticon(string id)
		{
			return "Assets/Art/Ui/assets/PetType/" + id + ".png";
		}

		// Token: 0x0600E99A RID: 59802 RVA: 0x003E524C File Offset: 0x003E344C
		public static string getAchieveRankIcon(int id)
		{
			return string.Format("{0}assets/achieve/rank/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E99B RID: 59803 RVA: 0x003E5263 File Offset: 0x003E3463
		public static string getPetHalfIcon(int id)
		{
			return string.Format("{0}assets/pet/half/{1}.jpg", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E99C RID: 59804 RVA: 0x003E527A File Offset: 0x003E347A
		public static string getPetBodyPrefab(int id)
		{
			//id = PetIdTransform.getPetId(id, 0, false);
			id = ResetableSingleTon<PetXMLInfo>.Ins.getRealId(id);
			return string.Format("Assets/Game/Prefabs/Pet/body/{0}.prefab", id);
		}

		// Token: 0x0600E99D RID: 59805 RVA: 0x003E52A3 File Offset: 0x003E34A3
		public static string getHandBookSkin(int id)
		{
			return string.Format("{0}assets/pet/half/{1}.jpg", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E99E RID: 59806 RVA: 0x003E52BA File Offset: 0x003E34BA
		public static string getNpcTriggerPng(int id)
		{
			return string.Format("{0}assets/npc/trigger/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E99F RID: 59807 RVA: 0x003E52D1 File Offset: 0x003E34D1
		public static string GetPicAnswer(string name)
		{
			return "Assets/Art/Ui/assets/picAnswer/" + name + ".png";
		}

		// Token: 0x0600E9A0 RID: 59808 RVA: 0x003E52E3 File Offset: 0x003E34E3
		public static string npcModelFile(string str)
		{
			return "Assets/Art/Ui/assets/npc/model/" + str + "/";
		}

		// Token: 0x0600E9A1 RID: 59809 RVA: 0x003E52F5 File Offset: 0x003E34F5
		public static string wildMonsterModelFile(string str)
		{
			return "Assets/Art/Ui/assets/wildMonster/" + str;
		}

		// Token: 0x0600E9A2 RID: 59810 RVA: 0x003E5302 File Offset: 0x003E3502
		public static string npcModelPath(int npcId)
		{
			return string.Format("{0}assets/npc/model/{1}.png", "Assets/Art/Ui/", npcId);
		}

		// Token: 0x0600E9A3 RID: 59811 RVA: 0x003E5319 File Offset: 0x003E3519
		public static string npcJsonPath()
		{
			return "Assets/Art/Ui/assets/npc/model/config.json";
		}

		// Token: 0x0600E9A4 RID: 59812 RVA: 0x003E5320 File Offset: 0x003E3520
		public static string getUiIcon(string str)
		{
			return "Assets/Art/Ui/assets/uiIcon/" + str + ".png";
		}

		// Token: 0x0600E9A5 RID: 59813 RVA: 0x003E5332 File Offset: 0x003E3532
		public static string GetAvatarHead(int iconId)
		{
			return string.Format("{0}assets/avatar/head/{1}.png", "Assets/Art/Ui/", iconId);
		}

		// Token: 0x0600E9A6 RID: 59814 RVA: 0x003E5349 File Offset: 0x003E3549
		public static string GetEmojiIcon(int iconId)
		{
			return string.Format("{0}assets/expression/{1}.png", "Assets/Art/Ui/", iconId);
		}

		// Token: 0x0600E9A7 RID: 59815 RVA: 0x003E5360 File Offset: 0x003E3560
		public static string GetAvatarFrame(int iconId)
		{
			return string.Format("{0}assets/avatar/frame/{1}.png", "Assets/Art/Ui/", iconId);
		}

		// Token: 0x0600E9A8 RID: 59816 RVA: 0x003E5377 File Offset: 0x003E3577
		public static string GetItemUserIcon(int id)
		{
			return string.Format("{0}assets/item/userInfo/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9A9 RID: 59817 RVA: 0x003E538E File Offset: 0x003E358E
		public static string getSptPlanet(int galaxyId, int planetId)
		{
			return string.Format("{0}assets/sptPlanet/galaxy_{1}/planet_{2}.png", "Assets/Art/Ui/", galaxyId, planetId);
		}

		// Token: 0x0600E9AA RID: 59818 RVA: 0x003E53AB File Offset: 0x003E35AB
		public static string getAchievePointIcon(int point)
		{
			return string.Format("{0}assets/achieve/point/{1}.png", "Assets/Art/Ui/", point);
		}

		// Token: 0x0600E9AB RID: 59819 RVA: 0x003E53C2 File Offset: 0x003E35C2
		public static string getAchieveIcon(int proicon)
		{
			return string.Format("{0}assets/achieve/icon/{1}.png", "Assets/Art/Ui/", proicon);
		}

		// Token: 0x0600E9AC RID: 59820 RVA: 0x003E53D9 File Offset: 0x003E35D9
		public static string getAchieveTitleIcon(int SpeNameBonus)
		{
			return string.Format("{0}assets/achieve/title/{1}.png", "Assets/Art/Ui/", SpeNameBonus);
		}

		// Token: 0x0600E9AD RID: 59821 RVA: 0x003E53F0 File Offset: 0x003E35F0
		public static string getAchieveSPTIcon(int SpeNameBonus)
		{
			return string.Format("{0}assets/achieve/spt/{1}.png", "Assets/Art/Ui/", SpeNameBonus);
		}

		// Token: 0x0600E9AE RID: 59822 RVA: 0x003E5407 File Offset: 0x003E3607
		public static string getSuitBodyPng(int suitId)
		{
			return string.Format("{0}assets/item/cloth/suiticon/{1}.png", "Assets/Art/Ui/", suitId);
		}

		// Token: 0x0600E9AF RID: 59823 RVA: 0x003E541E File Offset: 0x003E361E
		public static string getPetIntroducePng(int petId)
		{
			return string.Format("{0}assets/pet/body/{1}.png", "Assets/Art/Ui/", petId);
		}

		// Token: 0x0600E9B0 RID: 59824 RVA: 0x003E5435 File Offset: 0x003E3635
		public static string getNoNoIcon(int id)
		{
			return string.Format("{0}assets/nono/nonoIcon/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9B1 RID: 59825 RVA: 0x003E544C File Offset: 0x003E364C
		public static string getFieldIcon(int id)
		{
			return string.Format("{0}assets/fieldEffect/icon/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9B2 RID: 59826 RVA: 0x003E5463 File Offset: 0x003E3663
		public static string getMainStoryRes(string name)
		{
			return "Assets/Art/Ui/assets/mainStoryLine/image/" + name + ".png";
		}

		// Token: 0x0600E9B3 RID: 59827 RVA: 0x003E5475 File Offset: 0x003E3675
		public static string getFurnitureIcon(int id)
		{
			return string.Format("{0}assets/fitment/icon/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9B4 RID: 59828 RVA: 0x003E548C File Offset: 0x003E368C
		public static string getFurnitureItem(int id)
		{
			return string.Format("{0}assets/fitment/item/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9B5 RID: 59829 RVA: 0x003E54A3 File Offset: 0x003E36A3
		public static string loadRoomBg(int id)
		{
			return string.Format("{0}assets/roomBg/map_{1}_bg_mc.jpg", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9B6 RID: 59830 RVA: 0x003E54BA File Offset: 0x003E36BA
		public static string getSmallCard(int id)
		{
			return string.Format("{0}assets/nameCard/smallCard/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9B7 RID: 59831 RVA: 0x003E54D1 File Offset: 0x003E36D1
		public static string getCardBg(int id)
		{
			return string.Format("{0}assets/nameCard/cardBg/{1}.jpg", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9B8 RID: 59832 RVA: 0x003E54E8 File Offset: 0x003E36E8
		public static string getTitleBg(int id)
		{
			if (id <= 0)
			{
				return "Assets/Art/Ui/common/common_empty.png";
			}
			return string.Format("{0}assets/titleBg/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9B9 RID: 59833 RVA: 0x003E5509 File Offset: 0x003E3709
		public static string getPveMusePath(int id)
		{
			//return SB.Empty + string.Format("{0}assets/pveMusePet/{1}.png", "Assets/Art/Ui/", id);
			return "";
		}

		// Token: 0x0600E9BA RID: 59834 RVA: 0x003E552F File Offset: 0x003E372F
		public static string getPveMuse_SpecialPath(string strName)
		{
			return SB.Empty + ("Assets/Art/Ui/assets/pveMusePet/museSpecialTraining/" + strName + ".png");
		}

		// Token: 0x0600E9BB RID: 59835 RVA: 0x003E5550 File Offset: 0x003E3750
		public static string getPveMuse_KingPath(string strName)
		{
			return SB.Empty + ("Assets/Art/Ui/assets/pveMusePet/museSpecialTraining/" + strName + ".png");
		}

		// Token: 0x0600E9BC RID: 59836 RVA: 0x003E5571 File Offset: 0x003E3771
		public static string getPveMuse_SuperEvoPath(int id)
		{
			return SB.Empty + string.Format("{0}assets/pveMusePet/museSuperEvo/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9BD RID: 59837 RVA: 0x003E5597 File Offset: 0x003E3797
		public static string getMapSound(string id)
		{
			return "Assets/Game/Audios/bgm/sound/" + id + ".mp3";
		}

		// Token: 0x0600E9BE RID: 59838 RVA: 0x003E55A9 File Offset: 0x003E37A9
		public static string getMallGiftPetSource(int id)
		{
			return string.Format("{0}assets/mall/petIcon/{1}.png", "Assets/Art/Ui/", id);
		}

		// Token: 0x0600E9BF RID: 59839 RVA: 0x003E55C0 File Offset: 0x003E37C0
		public static string getBGMRUL(string name)
		{
			return "Assets/Game/Audios/bgm/" + name;
		}

		// Token: 0x0600E9C0 RID: 59840 RVA: 0x003E55D0 File Offset: 0x003E37D0
		//public static void setSuitIconSize(int suitId, Image ima, int hashCode, int maxSize = 150)
		//{
		//	ClientConfig.<setSuitIconSize>d__101 <setSuitIconSize>d__;
		//	<setSuitIconSize>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<setSuitIconSize>d__.suitId = suitId;
		//	<setSuitIconSize>d__.ima = ima;
		//	<setSuitIconSize>d__.hashCode = hashCode;
		//	<setSuitIconSize>d__.maxSize = maxSize;
		//	<setSuitIconSize>d__.<>1__state = -1;
		//	<setSuitIconSize>d__.<>t__builder.Start<ClientConfig.<setSuitIconSize>d__101>(ref <setSuitIconSize>d__);
		//}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x0600E9C1 RID: 59841 RVA: 0x003E561F File Offset: 0x003E381F
		// (set) Token: 0x0600E9C2 RID: 59842 RVA: 0x003E5626 File Offset: 0x003E3826
		public static bool isH264Supported
		{
			get
			{
				return ClientConfig._isH264Supported;
			}
			set
			{
				ClientConfig._isH264Supported = value;
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x0600E9C3 RID: 59843 RVA: 0x003E562E File Offset: 0x003E382E
		// (set) Token: 0x0600E9C4 RID: 59844 RVA: 0x003E5635 File Offset: 0x003E3835
		public static bool isVP8Supported
		{
			get
			{
				return ClientConfig._isVP8Supported;
			}
			set
			{
				ClientConfig._isVP8Supported = value;
			}
		}

		// Token: 0x0600E9C5 RID: 59845 RVA: 0x003E563D File Offset: 0x003E383D
		public static string getVideoClipUrl(string name)
		{
			if (ClientConfig.isH264Supported)
			{
				return "Assets/Game/Videos/" + name + ".mp4";
			}
			return "Assets/Game/Videos/" + name + "_vp8.mp4";
		}

		// Token: 0x0600E9C6 RID: 59846 RVA: 0x003E5667 File Offset: 0x003E3867
		public static string getWebGLPetAnimateVideoClipUrl(string name)
		{
			//return AppConfig.cdn + "WebGL/Video/" + name + ".mp4";
			return "";
		}

		// Token: 0x0600E9C7 RID: 59847 RVA: 0x003E567E File Offset: 0x003E387E
		public static string getAdAstraPlanetUrl(int galaxyId, int planetId)
		{
			return string.Format("{0}assets/adAstra/galaxy_{1}/planet_{2}.png", "Assets/Art/Ui/", galaxyId, planetId);
		}

		// Token: 0x0600E9C8 RID: 59848 RVA: 0x003E569C File Offset: 0x003E389C
		public static string getAdAstraPlanetMapUrl(int galaxyId, int planetId)
		{
			string text = string.Format("{0}assets/adAstra/galaxy_{1}/map_{2}.jpg", "Assets/Art/Ui/", galaxyId, planetId);
			//if (YooAssets.CheckLocationValid(text))
			//{
			//	return text;
			//}
			return string.Format("{0}assets/adAstra/galaxy_{1}/map_{2}.jpg", "Assets/Art/Ui/", galaxyId, 1);
		}

		// Token: 0x0600E9C9 RID: 59849 RVA: 0x003E56EC File Offset: 0x003E38EC
		public static string getAdAstraPlanetTitleUrl(int galaxyId, int planetId)
		{
			string text = string.Format("{0}assets/adAstra/galaxy_{1}/planet_title_{2}.png", "Assets/Art/Ui/", galaxyId, planetId);
			//if (YooAssets.CheckLocationValid(text))
			//{
			//	return text;
			//}
			return string.Format("{0}assets/adAstra/galaxy_{1}/planet_title_{2}.png", "Assets/Art/Ui/", galaxyId, 1);
		}

		// Token: 0x0400ED20 RID: 60704
		public const string battleModule = "battle";

		// Token: 0x0400ED21 RID: 60705
		public const string battleResultPanelModule = "battleResultPanel";

		// Token: 0x0400ED22 RID: 60706
		private const string UI_RES_URL = "Assets/Art/Ui/";

		// Token: 0x0400ED23 RID: 60707
		private const string BYTES_ROOT_PATH = "Assets/Game/Configs/bytes/";

		// Token: 0x0400ED24 RID: 60708
		private const string CUSTOM_CONFIG_ROOT_PATH = "Assets/Game/Configs/clientCustom/";

		// Token: 0x0400ED25 RID: 60709
		private const string MODULE_ROOT_PATH = "Assets/Game/UI/";

		// Token: 0x0400ED26 RID: 60710
		private const string FIGHT_PET_PATH = "Assets/Art/Ui/assets/fightResource/pet/";

		// Token: 0x0400ED27 RID: 60711
		private const string SCENE_PATH = "Assets/Game/Scenes/";

		// Token: 0x0400ED28 RID: 60712
		private const string BGM_PATH = "Assets/Game/Audios/bgm/";

		// Token: 0x0400ED29 RID: 60713
		private static string[] en_s = new string[]
		{
			"atk",
			"def",
			"satk",
			"sdef",
			"speed",
			"hp"
		};

		// Token: 0x0400ED2A RID: 60714
		//private static Dictionary<string, Sprite> BattleEffectIconCache = new Dictionary<string, Sprite>();

		// Token: 0x0400ED2B RID: 60715
		//private static Dictionary<int, Sprite> BossEffectIconCache = new Dictionary<int, Sprite>();

		// Token: 0x0400ED2C RID: 60716
		private static bool _isH264Supported = true;

		// Token: 0x0400ED2D RID: 60717
		private static bool _isVP8Supported = true;
	}
}
