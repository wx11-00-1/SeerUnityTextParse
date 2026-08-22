using System;
using System.Collections.Generic;
using common;
using core.config.effectbuff;


namespace core.config
{
	// Token: 0x02001E9F RID: 7839
	public class FieldEffectXMLInfo : ConfigManagerSingleton<FieldEffectXMLInfo>
	{
		// Token: 0x0600EA12 RID: 59922 RVA: 0x003E65E5 File Offset: 0x003E47E5
		

		// Token: 0x0600EA13 RID: 59923 RVA: 0x003E660D File Offset: 0x003E480D
		

		// Token: 0x0600EA14 RID: 59924 RVA: 0x003E661C File Offset: 0x003E481C
		

		// Token: 0x0600EA15 RID: 59925 RVA: 0x003E6660 File Offset: 0x003E4860
		public IBuffItem getBuffXml(int id)
		{
			IBuffItem result;
			if (this.s_XmlInfoDict.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0600EA16 RID: 59926 RVA: 0x003E6680 File Offset: 0x003E4880
		public Dictionary<int, IBuffItem> GetFieldEffects()
		{
			return this.s_XmlInfoDict;
		}

		// Token: 0x0600EA17 RID: 59927 RVA: 0x003E6688 File Offset: 0x003E4888
		public int GetFieldEffectYinJiId(int id)
		{
			if (id == 1)
			{
				return 105;
			}
			if (id == 2)
			{
				return 106;
			}
			return -1;
		}

		// Token: 0x0400ED35 RID: 60725
		private List<IBuffItem> s_FieldXmlInfo = new List<IBuffItem>();

		// Token: 0x0400ED36 RID: 60726
		private List<IBuffItem> s_ImprintXmlInfo = new List<IBuffItem>();

		// Token: 0x0400ED37 RID: 60727
		private Dictionary<int, IBuffItem> s_XmlInfoDict;
	}
}
