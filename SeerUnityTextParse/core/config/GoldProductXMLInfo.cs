using System;
using System.Collections.Generic;
using common;
using core.config.product_diamond;


namespace core.config
{
	// Token: 0x02001EA1 RID: 7841
	public class GoldProductXMLInfo : ConfigManagerSingleton<GoldProductXMLInfo>
	{
		// Token: 0x0600EA25 RID: 59941 RVA: 0x003E6921 File Offset: 0x003E4B21
		

		// Token: 0x0600EA26 RID: 59942 RVA: 0x003E6933 File Offset: 0x003E4B33
		

		// Token: 0x0600EA27 RID: 59943 RVA: 0x003E6944 File Offset: 0x003E4B44
		

		// Token: 0x0600EA28 RID: 59944 RVA: 0x003E6988 File Offset: 0x003E4B88
		public int[] getItemIDs(int proID)
		{
			int num;
			if (this.s_ProductMap != null && this.s_ProductMap.TryGetValue(proID, out num))
			{
				return ResetableSingleTon<IRootInterface>.Ins.root.item[num].itemID;
			}
			return null;
		}

		// Token: 0x0600EA29 RID: 59945 RVA: 0x003E69C8 File Offset: 0x003E4BC8
		public string getIcon(int proID)
		{
			int num;
			if (this.s_ProductMap != null && this.s_ProductMap.TryGetValue(proID, out num))
			{
				return ResetableSingleTon<IRootInterface>.Ins.root.item[num].icon;
			}
			return string.Empty;
		}

		// Token: 0x0600EA2A RID: 59946 RVA: 0x003E6A0C File Offset: 0x003E4C0C
		public string getNameByProID(int proID)
		{
			int num;
			if (this.s_ProductMap != null && this.s_ProductMap.TryGetValue(proID, out num))
			{
				return ResetableSingleTon<IRootInterface>.Ins.root.item[num].name;
			}
			return string.Empty;
		}

		// Token: 0x0600EA2B RID: 59947 RVA: 0x003E6A4D File Offset: 0x003E4C4D
		public bool containsPid(int proID)
		{
			return this.s_ProductMap != null && this.s_ProductMap.ContainsKey(proID);
		}

		// Token: 0x0600EA2C RID: 59948 RVA: 0x003E6A68 File Offset: 0x003E4C68
		public int getPriceByProID(int proID)
		{
			int num;
			if (this.s_ProductMap != null && this.s_ProductMap.TryGetValue(proID, out num))
			{
				return ResetableSingleTon<IRootInterface>.Ins.root.item[num].price;
			}
			return 0;
		}

		// Token: 0x0600EA2D RID: 59949 RVA: 0x003E6AA8 File Offset: 0x003E4CA8
		public float getVipByProID(int proID)
		{
			int num;
			if (this.s_ProductMap != null && this.s_ProductMap.TryGetValue(proID, out num))
			{
				return ResetableSingleTon<IRootInterface>.Ins.root.item[num].vip;
			}
			return 0f;
		}

		// Token: 0x0600EA2E RID: 59950 RVA: 0x003E6AEC File Offset: 0x003E4CEC
		public int getIProIdBytemId(int itemId)
		{
			if (this.s_ProductMap == null)
			{
				return -1;
			}
			foreach (int num in this.s_ProductMap.Values)
			{
				IItemItem itemItem = ResetableSingleTon<IRootInterface>.Ins.root.item[num];
				if (itemItem.itemID[0] == itemId)
				{
					return itemItem.productID;
				}
			}
			return -1;
		}

		// Token: 0x0400ED3C RID: 60732
		private Dictionary<int, int> s_ProductMap;
	}
}
