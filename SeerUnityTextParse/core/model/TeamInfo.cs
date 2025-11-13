using System;

namespace core.model
{
	// Token: 0x02001980 RID: 6528
	public class TeamInfo
	{
		// Token: 0x0600CCD7 RID: 52439 RVA: 0x003B6598 File Offset: 0x003B4798
		public TeamInfo(ByteArray data = null)
		{
			if (data == null)
			{
				return;
			}
			this.id = (int)data.ReadUnsignedInt();
			this.priv = (int)data.ReadUnsignedInt();
			this.superCore = (data.ReadUnsignedInt() > 0U);
			this.isShow = (data.ReadUnsignedInt() > 0U);
			this.allContribution = (int)data.ReadUnsignedInt();
			this.canExContribution = (int)data.ReadUnsignedInt();
		}

		// Token: 0x0400E33D RID: 58173
		public int id;

		// Token: 0x0400E33E RID: 58174
		public int level;

		// Token: 0x0400E33F RID: 58175
		public int priv;

		// Token: 0x0400E340 RID: 58176
		public bool superCore;

		// Token: 0x0400E341 RID: 58177
		public int coreCount;

		// Token: 0x0400E342 RID: 58178
		public bool isShow;

		// Token: 0x0400E343 RID: 58179
		public int logoBg;

		// Token: 0x0400E344 RID: 58180
		public int logoIcon;

		// Token: 0x0400E345 RID: 58181
		public int logoColor;

		// Token: 0x0400E346 RID: 58182
		public int txtColor;

		// Token: 0x0400E347 RID: 58183
		public string logoWord;

		// Token: 0x0400E348 RID: 58184
		public int allContribution;

		// Token: 0x0400E349 RID: 58185
		public int canExContribution;
	}
}
