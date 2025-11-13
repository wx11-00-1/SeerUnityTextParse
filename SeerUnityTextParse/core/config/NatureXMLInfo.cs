using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.nature;


namespace core.config
{
	// Token: 0x02001EAE RID: 7854
	public class NatureXMLInfo : ConfigManagerSingleton<NatureXMLInfo>
	{
		// Token: 0x0600EAAD RID: 60077 RVA: 0x003EA7F8 File Offset: 0x003E89F8
		

		// Token: 0x0600EAAE RID: 60078 RVA: 0x003EA80A File Offset: 0x003E8A0A
		

		// Token: 0x0600EAAF RID: 60079 RVA: 0x003EA818 File Offset: 0x003E8A18
		

		// Token: 0x0600EAB0 RID: 60080 RVA: 0x003EA85B File Offset: 0x003E8A5B
		public Dictionary<int, IItemItem> getData()
		{
			return this.s_DataMap;
		}

		// Token: 0x0600EAB1 RID: 60081 RVA: 0x003EA864 File Offset: 0x003E8A64
		public string getName(int nature)
		{
			IItemItem itemItem;
			if (!this.s_DataMap.TryGetValue(nature, out itemItem) || itemItem.name == null)
			{
				return string.Empty;
			}
			return itemItem.name;
		}

		// Token: 0x0600EAB2 RID: 60082 RVA: 0x003EA898 File Offset: 0x003E8A98
		public string getDes(int nature)
		{
			IItemItem itemItem;
			if (!this.s_DataMap.TryGetValue(nature, out itemItem) || itemItem.des == null)
			{
				return string.Empty;
			}
			return itemItem.des;
		}

		// Token: 0x0600EAB3 RID: 60083 RVA: 0x003EA8CC File Offset: 0x003E8ACC
		public string getDes2(int nature)
		{
			IItemItem itemItem;
			if (!this.s_DataMap.TryGetValue(nature, out itemItem) || itemItem.des2 == null)
			{
				return string.Empty;
			}
			return itemItem.des2;
		}

		// Token: 0x0600EAB4 RID: 60084 RVA: 0x003EA900 File Offset: 0x003E8B00
		public int getIDByName(string strName)
		{
			KeyValuePair<int, IItemItem> keyValuePair = this.s_DataMap.FirstOrDefault((KeyValuePair<int, IItemItem> nature) => nature.Value.name == strName);
			if (keyValuePair.Value == null)
			{
				return 0;
			}
			return keyValuePair.Value.id;
		}

		// Token: 0x0400EEAF RID: 61103
		private Dictionary<int, IItemItem> s_DataMap;
	}
}
