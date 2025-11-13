using System;
using System.Collections.Generic;
using common;
using core.config.peakCrusade_levelRules;


namespace core.config
{
	// Token: 0x02001EB0 RID: 7856
	public class PeakJihadLevelRulesXMLInfo : ConfigManagerSingleton<PeakJihadLevelRulesXMLInfo>
	{
		// Token: 0x0600EABD RID: 60093 RVA: 0x003EAA06 File Offset: 0x003E8C06
		

		// Token: 0x0600EABE RID: 60094 RVA: 0x003EAA18 File Offset: 0x003E8C18
		

		// Token: 0x0600EABF RID: 60095 RVA: 0x003EAA28 File Offset: 0x003E8C28
		

		// Token: 0x0600EAC0 RID: 60096 RVA: 0x003EAA6C File Offset: 0x003E8C6C
		public int getLadderLvByStarlv(int lv)
		{
			IItemItem itemItem;
			if (lv <= 100 && this.s_ItemHash.TryGetValue(lv, out itemItem))
			{
				return itemItem.ladderLv;
			}
			return 0;
		}

		// Token: 0x0600EAC1 RID: 60097 RVA: 0x003EAA98 File Offset: 0x003E8C98
		public int getStarByStarlv(int lv)
		{
			IItemItem itemItem;
			if (lv <= 100 && this.s_ItemHash.TryGetValue(lv, out itemItem))
			{
				return itemItem.star;
			}
			return lv - 85;
		}

		// Token: 0x0600EAC2 RID: 60098 RVA: 0x003EAAC8 File Offset: 0x003E8CC8
		public string getTitleByStarlv(int lv)
		{
			IItemItem itemItem;
			if (lv <= 100 && this.s_ItemHash.TryGetValue(lv, out itemItem))
			{
				return itemItem.title;
			}
			return "宇宙圣皇";
		}

		// Token: 0x0600EAC3 RID: 60099 RVA: 0x003EAAF8 File Offset: 0x003E8CF8
		public int getDanNumberByStarlv(int lv)
		{
			IItemItem itemItem;
			if (lv <= 100 && this.s_ItemHash.TryGetValue(lv, out itemItem))
			{
				return itemItem.danNumber;
			}
			return 0;
		}

		// Token: 0x0600EAC4 RID: 60100 RVA: 0x003EAB24 File Offset: 0x003E8D24
		public string getTileNameByOutLevel(int outLv)
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<int, IItemItem> keyValuePair in this.s_ItemHash)
			{
				if (list.IndexOf(keyValuePair.Value.title) == -1)
				{
					list.Add(keyValuePair.Value.title);
				}
			}
			if (outLv < 1 || outLv > list.Count)
			{
				return string.Empty;
			}
			return list[outLv - 1];
		}

		// Token: 0x0400EEB1 RID: 61105
		private Dictionary<int, IItemItem> s_ItemHash;
	}
}
