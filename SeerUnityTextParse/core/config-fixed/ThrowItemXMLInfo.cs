using System;
using System.Collections.Generic;
using common;
using core.config.throw_item;
using core.manager;


namespace core.config
{
	// Token: 0x02001EC1 RID: 7873
	public class ThrowItemXMLInfo : ConfigManagerSingleton<ThrowItemXMLInfo>
	{
		// Token: 0x0600EBA6 RID: 60326 RVA: 0x003EE752 File Offset: 0x003EC952
		

		// Token: 0x0600EBA7 RID: 60327 RVA: 0x003EE75F File Offset: 0x003EC95F
		

		// Token: 0x0600EBA8 RID: 60328 RVA: 0x003EE770 File Offset: 0x003EC970
		

		// Token: 0x0600EBA9 RID: 60329 RVA: 0x003EE7B4 File Offset: 0x003EC9B4
		public IItemItem GetThrowItem(int id)
		{
			IItemItem result;
			if (this.s_ThrowItemHashMap.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0600EBAA RID: 60330 RVA: 0x003EE7D4 File Offset: 0x003EC9D4
		//public List<int> GetThrowItemList()
		//{
		//	this.m_ThrowItemList.Clear();
		//	foreach (KeyValuePair<int, IItemItem> keyValuePair in this.s_ThrowItemHashMap)
		//	{
		//		if (ResetableSingleTon<ItemManager>.Ins.getNumByID(keyValuePair.Key) > 0)
		//		{
		//			this.m_ThrowItemList.Add(keyValuePair.Key);
		//		}
		//	}
		//	return this.m_ThrowItemList;
		//}

		// Token: 0x0400EEF7 RID: 61175
		private readonly Dictionary<int, IItemItem> s_ThrowItemHashMap = new Dictionary<int, IItemItem>();

		// Token: 0x0400EEF8 RID: 61176
		private List<int> m_ThrowItemList = new List<int>();
	}
}
