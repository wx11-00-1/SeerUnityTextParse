using System;
using System.Collections.Generic;
using common;
using core.config.mintmark_lottery;


namespace core.config
{
	// Token: 0x02001EA9 RID: 7849
	public class MintmarkLotteryXMLInfo : ConfigManagerSingleton<MintmarkLotteryXMLInfo>
	{
		// Token: 0x0600EA95 RID: 60053 RVA: 0x003E87D1 File Offset: 0x003E69D1
		

		// Token: 0x0600EA96 RID: 60054 RVA: 0x003E87F4 File Offset: 0x003E69F4
		

		// Token: 0x0600EA97 RID: 60055 RVA: 0x003E8804 File Offset: 0x003E6A04
		

		// Token: 0x0600EA98 RID: 60056 RVA: 0x003E8848 File Offset: 0x003E6A48
		public IMintMarkItem[] getMenuListByLevel(int level)
		{
			IMintMarkItem[] result;
			if (!this.s_MenuList.TryGetValue(level, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EA99 RID: 60057 RVA: 0x003E8868 File Offset: 0x003E6A68
		public IMintMarkItem getMenuItemById(int id)
		{
			IMintMarkItem result;
			if (!this.s_MenuConfig.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EA9A RID: 60058 RVA: 0x003E8888 File Offset: 0x003E6A88
		public IMintMarkItem getShopItemById(int id)
		{
			IMintMarkItem result;
			if (!this.s_ShopConfig.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EA9B RID: 60059 RVA: 0x003E88A8 File Offset: 0x003E6AA8
		public List<IMintMarkItem> getShopItemsByPuton(int puton)
		{
			List<IMintMarkItem> list = new List<IMintMarkItem>();
			foreach (IMintMarkItem mintMarkItem in this.s_ShopConfig.Values)
			{
				if (mintMarkItem.puton == puton)
				{
					list.Add(mintMarkItem);
				}
			}
			return list;
		}

		// Token: 0x0400ED6B RID: 60779
		private Dictionary<int, IMintMarkItem> s_MenuConfig = new Dictionary<int, IMintMarkItem>(353);

		// Token: 0x0400ED6C RID: 60780
		private Dictionary<int, IMintMarkItem> s_ShopConfig;

		// Token: 0x0400ED6D RID: 60781
		private Dictionary<int, IMintMarkItem[]> s_MenuList;
	}
}
