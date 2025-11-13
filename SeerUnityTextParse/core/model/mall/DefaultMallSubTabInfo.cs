using System;
//using Game.Scripts.GameLogic.core.manager;

namespace core.model.mall
{
	// Token: 0x02001AF5 RID: 6901
	public class DefaultMallSubTabInfo : AMallSubTabInfo
	{
		// Token: 0x0600CED6 RID: 52950 RVA: 0x003C15ED File Offset: 0x003BF7ED
		//public DefaultMallSubTabInfo(MallManager.MallTab tabType, int subTabType, string name) : base(tabType, subTabType)
		//{
			//this.name = name;
		//}

		// Token: 0x0600CED7 RID: 52951 RVA: 0x003C15FE File Offset: 0x003BF7FE
		public override string GetName()
		{
			return this.name;
		}

		// Token: 0x0400E4C6 RID: 58566
		public string name;
	}
}
