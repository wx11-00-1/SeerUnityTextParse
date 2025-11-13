using System;
using System.Collections.Generic;
//using Game.Scripts.GameLogic.core.manager;

namespace core.model.mall
{
	// Token: 0x02001AF4 RID: 6900
	public abstract class AMallSubTabInfo
	{
		// Token: 0x0600CED0 RID: 52944 RVA: 0x003C1547 File Offset: 0x003BF747
		//protected AMallSubTabInfo(MallManager.MallTab tabType, int subTabType)
		//{
		//	this.tabType = tabType;
		//	this.subTabType = subTabType;
		//}

		// Token: 0x0600CED1 RID: 52945 RVA: 0x003C1568 File Offset: 0x003BF768
		//public virtual int GetHotRedId()
		//{
		//	if (this.tabType == MallManager.MallTab.ChaoZhiLiBao)
		//	{
		//		MallManager.GiftType giftType = (MallManager.GiftType)this.subTabType;
		//		if (giftType != MallManager.GiftType.Featured)
		//		{
		//		}
		//	}
		//	return 0;
		//}

		// Token: 0x0600CED2 RID: 52946
		public abstract string GetName();

		// Token: 0x0600CED3 RID: 52947 RVA: 0x003C158E File Offset: 0x003BF78E
		public void AddItem(AMallItemInfo item)
		{
			//item.tabType = this.tabType;
			item.subTabType = this.subTabType;
			this.items.Add(item);
		}

		// Token: 0x0600CED4 RID: 52948 RVA: 0x003C15B4 File Offset: 0x003BF7B4
		public void Clear()
		{
			this.items.Clear();
		}

		// Token: 0x0600CED5 RID: 52949 RVA: 0x003C15C1 File Offset: 0x003BF7C1
		public void Sort()
		{
			this.items.Sort(delegate(AMallItemInfo a, AMallItemInfo b)
			{
				if (a.IsSoldOut() && !b.IsSoldOut())
				{
					return 1;
				}
				if (!a.IsSoldOut() && b.IsSoldOut())
				{
					return -1;
				}
				if (a.GetSort() > b.GetSort())
				{
					return -1;
				}
				if (a.GetSort() < b.GetSort())
				{
					return 1;
				}
				if (a is SkinMallItemInfo && b is SkinMallItemInfo)
				{
					if (a.GetID() <= b.GetID())
					{
						return 1;
					}
					return -1;
				}
				else
				{
					if (a.GetID() >= b.GetID())
					{
						return 1;
					}
					return -1;
				}
			});
		}

		// Token: 0x0400E4C3 RID: 58563
		//public MallManager.MallTab tabType;

		// Token: 0x0400E4C4 RID: 58564
		public int subTabType;

		// Token: 0x0400E4C5 RID: 58565
		public List<AMallItemInfo> items = new List<AMallItemInfo>();
	}
}
