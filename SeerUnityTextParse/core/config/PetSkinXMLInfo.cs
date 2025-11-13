using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.pet_skin;
using core.model;

//using module.handbook;

namespace core.config
{
	// Token: 0x02001EB7 RID: 7863
	public class PetSkinXMLInfo : ConfigManagerSingleton<PetSkinXMLInfo>
	{
		// Token: 0x0600EB0E RID: 60174 RVA: 0x003EBD53 File Offset: 0x003E9F53
		

		// Token: 0x0600EB0F RID: 60175 RVA: 0x003EBD6B File Offset: 0x003E9F6B
		

		// Token: 0x0600EB10 RID: 60176 RVA: 0x003EBD7C File Offset: 0x003E9F7C
		

		// Token: 0x0600EB11 RID: 60177 RVA: 0x003EBDC0 File Offset: 0x003E9FC0
		public List<PetSkinInfo> getSkinInfosByPetId(int petId)
		{
			List<PetSkinInfo> list = new List<PetSkinInfo>();
			List<PetSkinInfo> list2;
			if (this.s_DataMapByPetId.TryGetValue(petId, out list2))
			{
				for (int i = 0; i < list2.Count; i++)
				{
					list.Add(list2[i]);
				}
			}
			return list;
		}

		// Token: 0x0600EB12 RID: 60178 RVA: 0x003EBE04 File Offset: 0x003EA004
		//public static HandbookSkinType GetHandbookSkinType(PetSkinInfo info)
		//{
		//	if (info.type == 0)
		//	{
		//		return HandbookSkinType.经典;
		//	}
		//	if (info.type == 2)
		//	{
		//		return HandbookSkinType.史诗;
		//	}
		//	if (info.type == 3)
		//	{
		//		return HandbookSkinType.传说;
		//	}
		//	if (PetSkinXMLInfo.TypeArr4Limit.Contains(info.type))
		//	{
		//		return HandbookSkinType.限定;
		//	}
		//	if (info.type == 14)
		//	{
		//		return HandbookSkinType.神话;
		//	}
		//	return HandbookSkinType.所有;
		//}

		// Token: 0x0600EB13 RID: 60179 RVA: 0x003EBE54 File Offset: 0x003EA054
		public PetSkinInfo getSkinInfo(int id)
		{
			PetSkinInfo result;
			if (!this.s_DataMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB14 RID: 60180 RVA: 0x003EBE74 File Offset: 0x003EA074
		public string getTypeCn(int type)
		{
			if (type < 0 || type >= this.typeMapCn.Count)
			{
				return "经典";
			}
			return this.typeMapCn[type];
		}

		// Token: 0x0600EB15 RID: 60181 RVA: 0x003EBE9C File Offset: 0x003EA09C
		public int getSkinPetId(int skinId, int petId = 0)
		{
			if (petId == 0)
			{
				PetSkinInfo skinInfo = this.getSkinInfo(skinId);
				if (skinInfo != null)
				{
					return skinInfo.skinPetId;
				}
			}
			if (skinId != 0)
			{
				PetSkinInfo skinInfo2 = this.getSkinInfo(skinId);
				if (skinInfo2 != null && skinInfo2.monId == petId)
				{
					petId = skinInfo2.skinPetId;
				}
			}
			return petId;
		}

		// Token: 0x0600EB16 RID: 60182 RVA: 0x003EBEDE File Offset: 0x003EA0DE
		public List<PetSkinInfo> getAllSkin()
		{
			return this.s_DataMap.Values.ToList<PetSkinInfo>();
		}

		// Token: 0x0600EB17 RID: 60183 RVA: 0x003EBEF0 File Offset: 0x003EA0F0
		public PetSkinInfo getPetDefaultSkin(int petId)
		{
			return new PetSkinInfo(null)
			{
				monId = petId,
				name = ResetableSingleTon<PetXMLInfo>.Ins.getName(petId),
				skinPetId = petId,
				type = 9999
			};
		}

		// Token: 0x0400EEC9 RID: 61129
		private Dictionary<int, PetSkinInfo> s_DataMap;

		// Token: 0x0400EECA RID: 61130
		private Dictionary<int, List<PetSkinInfo>> s_DataMapByPetId = new Dictionary<int, List<PetSkinInfo>>(521);

		// Token: 0x0400EECB RID: 61131
		private static int[] TypeArr4Limit = new int[]
		{
			4,
			5,
			6,
			7,
			8,
			9,
			11,
			12,
			13,
			15,
			16,
			17,
			18
		};

		// Token: 0x0400EECC RID: 61132
		private List<string> typeMapCn = new List<string>
		{
			"默认",
			"英雄",
			"史诗",
			"传说",
			"周年限定",
			"万圣限定",
			"中秋节限定",
			"春节限定",
			"圣诞节限定",
			"青春校园",
			string.Empty,
			"周年限定",
			"周年限定",
			"异元时空",
			"神话",
			"七夕限定",
			"限定"
		};
	}
}
