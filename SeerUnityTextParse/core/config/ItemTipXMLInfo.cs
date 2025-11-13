using System;
using System.Collections.Generic;
using common;
using core.config.itemsTip;
//using core.constant;
using core.manager;


namespace core.config
{
	// Token: 0x02001EA4 RID: 7844
	public class ItemTipXMLInfo : ConfigManagerSingleton<ItemTipXMLInfo>
	{
		// Token: 0x0600EA4A RID: 59978 RVA: 0x003E704E File Offset: 0x003E524E
		

		// Token: 0x0600EA4B RID: 59979 RVA: 0x003E706C File Offset: 0x003E526C

		// Token: 0x0600EA4C RID: 59980 RVA: 0x003E7088 File Offset: 0x003E5288
		

		// Token: 0x0600EA4D RID: 59981 RVA: 0x003E70CC File Offset: 0x003E52CC
		public string getItemDes(int id)
		{
			IItemItem itemItem;
			string text = this.s_Map.TryGetValue(id, out itemItem) ? itemItem.des : string.Empty;
			if (!string.IsNullOrEmpty(text))
			{
				text = text.Replace("{ACTORID}", ResetableSingleTon<MainManager>.Ins.actorID.ToString());
			}
			return text;
		}

		// Token: 0x0600EA4E RID: 59982 RVA: 0x003E711C File Offset: 0x003E531C
		public string getItemDesc(int id)
		{
			//if (ResetableSingleTon<ItemXMLInfo>.Ins.getCatID(id) != ItemCatID.TYPE_23)
			//{
			//	string text = this.getItemDes(id);
			//	if (text == string.Empty)
			//	{
			//		text = "漫长宇宙航行中收获的珍贵收藏品，记录着我们一路航行来的记忆";
			//	}
			//	return text;
			//}
			//string result;
			//if (this.s_BoxDesMap.TryGetValue(id, out result))
			//{
			//	return result;
			//}
			return string.Empty;
		}

		// Token: 0x0400ED4E RID: 60750
		private byte[] s_ConfigBytes;

		// Token: 0x0400ED4F RID: 60751
		private Dictionary<int, IItemItem> s_Map;

		// Token: 0x0400ED50 RID: 60752
		private Dictionary<int, string> s_BoxDesMap;
	}
}
