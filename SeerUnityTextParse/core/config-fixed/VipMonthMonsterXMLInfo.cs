using System;
using System.Collections.Generic;
using common;
using core.config.vip_month_monster;


namespace core.config
{
	// Token: 0x02001EC3 RID: 7875
	public class VipMonthMonsterXMLInfo : ConfigManagerSingleton<VipMonthMonsterXMLInfo>
	{
		// Token: 0x0600EBB4 RID: 60340 RVA: 0x003EEADB File Offset: 0x003ECCDB
		

		// Token: 0x0600EBB5 RID: 60341 RVA: 0x003EEAED File Offset: 0x003ECCED
		

		// Token: 0x0600EBB6 RID: 60342 RVA: 0x003EEAFC File Offset: 0x003ECCFC
		

		// Token: 0x0600EBB7 RID: 60343 RVA: 0x003EEB40 File Offset: 0x003ECD40
		public int[] getMonsterIds(int idx)
		{
			IItemItem itemItem;
			if (this.s_ItemHash != null && this.s_ItemHash.TryGetValue(idx, out itemItem))
			{
				return itemItem.MonstersID;
			}
			return null;
		}

		// Token: 0x0600EBB8 RID: 60344 RVA: 0x003EEB70 File Offset: 0x003ECD70
		public int[] getPetForever(int idx)
		{
			IItemItem itemItem;
			if (this.s_ItemHash != null && this.s_ItemHash.TryGetValue(idx, out itemItem))
			{
				return itemItem.GotFlagInfo;
			}
			return null;
		}

		// Token: 0x0600EBB9 RID: 60345 RVA: 0x003EEBA0 File Offset: 0x003ECDA0
		public int getMonthNum(int idx)
		{
			IItemItem itemItem;
			if (!this.s_ItemHash.TryGetValue(idx, out itemItem))
			{
				return 0;
			}
			return itemItem.CurMonth;
		}

		// Token: 0x0600EBBA RID: 60346 RVA: 0x003EEBC8 File Offset: 0x003ECDC8
		public int getCurrentYear(int idx)
		{
			IItemItem itemItem;
			if (!this.s_ItemHash.TryGetValue(idx, out itemItem))
			{
				return 0;
			}
			return itemItem.CurYear;
		}

		// Token: 0x0600EBBB RID: 60347 RVA: 0x003EEBF0 File Offset: 0x003ECDF0
		public IItemItem getItem(int idx)
		{
			IItemItem result;
			if (!this.s_ItemHash.TryGetValue(idx, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0400EEFA RID: 61178
		private Dictionary<int, IItemItem> s_ItemHash;
	}
}
