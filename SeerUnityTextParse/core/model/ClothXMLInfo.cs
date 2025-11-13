using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x02001913 RID: 6419
	public class ClothXMLInfo
	{
		// Token: 0x0600CA0C RID: 51724 RVA: 0x003AE438 File Offset: 0x003AC638
		public static ClothData getItemInfo(int id)
		{
			if (!ClothXMLInfo.s_Dict.ContainsKey(id))
			{
				ClothXMLInfo.s_Dict[id] = new ClothData(id);
			}
			return ClothXMLInfo.s_Dict[id];
		}

		// Token: 0x0400DEAD RID: 57005
		public static readonly int DEFAULT_HEAD = 100001;

		// Token: 0x0400DEAE RID: 57006
		public static readonly int DEFAULT_WAIST = 100002;

		// Token: 0x0400DEAF RID: 57007
		public static readonly int DEFAULT_FOOT = 100003;

		// Token: 0x0400DEB0 RID: 57008
		private static Dictionary<int, ClothData> s_Dict = new Dictionary<int, ClothData>();
	}
}
