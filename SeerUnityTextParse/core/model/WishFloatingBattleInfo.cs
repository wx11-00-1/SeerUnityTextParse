using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x0200198D RID: 6541
	public class WishFloatingBattleInfo
	{
		// Token: 0x0600CD28 RID: 52520 RVA: 0x003B8F1F File Offset: 0x003B711F
		public static int GetMaxWishTimes()
		{
			return 10;
		}

		// Token: 0x0600CD29 RID: 52521 RVA: 0x003B8F24 File Offset: 0x003B7124
		public static Dictionary<int, int> GetWishGetTimes()
		{
			if (WishFloatingBattleInfo._wishGetTimes == null)
			{
				WishFloatingBattleInfo._wishGetTimes = new Dictionary<int, int>
				{
					{
						1,
						5
					},
					{
						2,
						15
					},
					{
						3,
						30
					},
					{
						5,
						60
					},
					{
						7,
						90
					},
					{
						10,
						120
					}
				};
			}
			return WishFloatingBattleInfo._wishGetTimes;
		}

		// Token: 0x0400E4A6 RID: 58534
		private static Dictionary<int, int> _wishGetTimes;
	}
}
