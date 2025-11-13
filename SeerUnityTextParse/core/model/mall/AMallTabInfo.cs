using System;
using System.Collections.Generic;
//using Game.Scripts.GameLogic.core.manager;

namespace core.model.mall
{
	// Token: 0x02001AF6 RID: 6902
	public abstract class AMallTabInfo
	{
		// Token: 0x0600CED8 RID: 52952 RVA: 0x003C1606 File Offset: 0x003BF806
		//public AMallTabInfo(MallManager.MallTab mallTab)
		//{
			//this.MallTab = mallTab;
		//}

		// Token: 0x0600CED9 RID: 52953 RVA: 0x003C1620 File Offset: 0x003BF820
		public void AddItem(int id, DefaultMallSubTabInfo newSubTab)
		{
			//newSubTab.tabType = this.MallTab;
			this.items.Add(id, newSubTab);
		}

		// Token: 0x0400E4C7 RID: 58567
		//public MallManager.MallTab MallTab;

		// Token: 0x0400E4C8 RID: 58568
		public Dictionary<int, AMallSubTabInfo> items = new Dictionary<int, AMallSubTabInfo>();
	}
}
