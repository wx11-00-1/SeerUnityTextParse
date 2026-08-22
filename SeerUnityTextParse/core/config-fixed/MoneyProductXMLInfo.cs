using System;
using System.Collections.Generic;
using common;
using core.config.product_money;


namespace core.config
{
	// Token: 0x02001EAD RID: 7853
	public class MoneyProductXMLInfo : ConfigManagerSingleton<MoneyProductXMLInfo>
	{
		// Token: 0x0600EAA3 RID: 60067 RVA: 0x003EA628 File Offset: 0x003E8828
		

		// Token: 0x0600EAA4 RID: 60068 RVA: 0x003EA63A File Offset: 0x003E883A
		

		// Token: 0x0600EAA5 RID: 60069 RVA: 0x003EA648 File Offset: 0x003E8848
		

		// Token: 0x0600EAA6 RID: 60070 RVA: 0x003EA68C File Offset: 0x003E888C
		public int[] getItemIDs(int proID)
		{
			IItemItem itemItem = null;
			foreach (IItemItem itemItem2 in this.s_Xmllist)
			{
				if (itemItem2.productID == proID)
				{
					itemItem = itemItem2;
					break;
				}
			}
			if (itemItem != null)
			{
				return itemItem.itemID;
			}
			return ResetableSingleTon<GoldProductXMLInfo>.Ins.getItemIDs(proID);
		}

		// Token: 0x0600EAA7 RID: 60071 RVA: 0x003EA6D8 File Offset: 0x003E88D8
		public string getNameByProID(int proID)
		{
			IItemItem itemItem;
			if (!this.s_ProductMap.TryGetValue(proID, out itemItem))
			{
				return ResetableSingleTon<GoldProductXMLInfo>.Ins.getNameByProID(proID);
			}
			return itemItem.name;
		}

		// Token: 0x0600EAA8 RID: 60072 RVA: 0x003EA708 File Offset: 0x003E8908
		public float getPriceByProID(int proID)
		{
			IItemItem itemItem = null;
			foreach (IItemItem itemItem2 in this.s_Xmllist)
			{
				if (itemItem2.productID == proID)
				{
					itemItem = itemItem2;
					break;
				}
			}
			if (itemItem != null)
			{
				return itemItem.price;
			}
			return (float)ResetableSingleTon<GoldProductXMLInfo>.Ins.getPriceByProID(proID);
		}

		// Token: 0x0600EAA9 RID: 60073 RVA: 0x003EA753 File Offset: 0x003E8953
		public bool containsPid(int proID)
		{
			return this.s_ProductMap.ContainsKey(proID);
		}

		// Token: 0x0600EAAA RID: 60074 RVA: 0x003EA764 File Offset: 0x003E8964
		public float getVipByProID(int proID)
		{
			IItemItem itemItem = null;
			foreach (IItemItem itemItem2 in this.s_Xmllist)
			{
				if (itemItem2.productID == proID)
				{
					itemItem = itemItem2;
					break;
				}
			}
			if (itemItem != null)
			{
				return (float)itemItem.vip;
			}
			return ResetableSingleTon<GoldProductXMLInfo>.Ins.getVipByProID(proID);
		}

		// Token: 0x0600EAAB RID: 60075 RVA: 0x003EA7B0 File Offset: 0x003E89B0
		public int getGoldByProID(int proID)
		{
			IItemItem itemItem = null;
			foreach (IItemItem itemItem2 in this.s_Xmllist)
			{
				if (itemItem2.productID == proID)
				{
					itemItem = itemItem2;
					break;
				}
			}
			if (itemItem != null)
			{
				return itemItem.gold;
			}
			return 0;
		}

		// Token: 0x0400EEAD RID: 61101
		private IItemItem[] s_Xmllist;

		// Token: 0x0400EEAE RID: 61102
		private Dictionary<int, IItemItem> s_ProductMap;
	}
}
