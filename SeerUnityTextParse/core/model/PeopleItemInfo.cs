using System;

namespace core.model
{
	// Token: 0x0200194E RID: 6478
	public class PeopleItemInfo
	{
		// Token: 0x0600CBDF RID: 52191 RVA: 0x003B3091 File Offset: 0x003B1291
		public PeopleItemInfo(int id, int level = 1)
		{
			this.id = id;
			this.level = level;
		}

		// Token: 0x0400E178 RID: 57720
		public int id;

		// Token: 0x0400E179 RID: 57721
		public int level;
	}
}
