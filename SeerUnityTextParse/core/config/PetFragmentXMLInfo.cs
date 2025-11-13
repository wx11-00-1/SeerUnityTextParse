using System;
using System.Collections.Generic;
using common;
using core.config.Fragment;


namespace core.config
{
	// Token: 0x02001EB5 RID: 7861
	public class PetFragmentXMLInfo : ConfigManagerSingleton<PetFragmentXMLInfo>
	{
		// Token: 0x0600EAFF RID: 60159 RVA: 0x003EBA0D File Offset: 0x003E9C0D
		

		// Token: 0x0600EB00 RID: 60160 RVA: 0x003EBA1F File Offset: 0x003E9C1F
		

		// Token: 0x0600EB01 RID: 60161 RVA: 0x003EBA30 File Offset: 0x003E9C30
		

		// Token: 0x0600EB02 RID: 60162 RVA: 0x003EBA74 File Offset: 0x003E9C74
		public IFragmentItem getItemByPetID(int petID)
		{
			foreach (KeyValuePair<int, IFragmentItem> keyValuePair in this.s_Configs)
			{
				if (keyValuePair.Value.MonsterID == petID)
				{
					return keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x0600EB03 RID: 60163 RVA: 0x003EBADC File Offset: 0x003E9CDC
		public IFragmentItem getItemByID(int id)
		{
			IFragmentItem result;
			if (!this.s_Configs.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB04 RID: 60164 RVA: 0x003EBAFC File Offset: 0x003E9CFC
		public List<IFragmentItem> GetShowArrInfos(int show)
		{
			List<IFragmentItem> list = new List<IFragmentItem>();
			foreach (IFragmentItem fragmentItem in this.s_Configs.Values)
			{
				if (fragmentItem.show == show)
				{
					list.Add(fragmentItem);
				}
			}
			return list;
		}

		// Token: 0x0600EB05 RID: 60165 RVA: 0x003EBB64 File Offset: 0x003E9D64
		public string transformRarityNumToCn(int rarity)
		{
			string result;
			switch (rarity)
			{
			case 1:
				result = "B";
				break;
			case 2:
				result = "A";
				break;
			case 3:
				result = "S";
				break;
			case 4:
				result = "SS";
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x0400EEC6 RID: 61126
		private Dictionary<int, IFragmentItem> s_Configs;
	}
}
