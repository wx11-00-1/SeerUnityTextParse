using System;
using System.Collections.Generic;
using common;
using core.config.aimat;
using core.model;

namespace core.config
{
	// Token: 0x02001C7F RID: 7295
	public class AimatXMLInfo : ConfigManagerSingleton<AimatXMLInfo>
	{

		// Token: 0x0600D292 RID: 53906 RVA: 0x003C85BC File Offset: 0x003C67BC
		public IItemItem GetAimat(int id)
		{
			IItemItem result;
			if (this.s_AimatHashMap.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0600D293 RID: 53907 RVA: 0x003C85DC File Offset: 0x003C67DC
		public IItemItem GetAimatByClothID(List<PeopleItemInfo> clothIDs)
		{
			foreach (KeyValuePair<int, IItemItem> keyValuePair in this.s_AimatHashMap)
			{
				if (keyValuePair.Value.cloths > 0)
				{
					for (int i = 0; i < clothIDs.Count; i++)
					{
						if (keyValuePair.Value.cloths == clothIDs[i].id)
						{
							return keyValuePair.Value;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0400E4DD RID: 58589
		private Dictionary<int, IItemItem> s_AimatHashMap;
	}
}
