using System;

namespace core.model
{
	// Token: 0x02001926 RID: 6438
	public class DoodleInfo
	{
		// Token: 0x0600CAB3 RID: 51891 RVA: 0x003B05D8 File Offset: 0x003AE7D8
		public DoodleInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.userID = (int)data.ReadUnsignedInt();
				this.color = (int)data.ReadUnsignedInt();
				this.texture = (int)data.ReadUnsignedInt();
				this.coins = (int)data.ReadUnsignedInt();
			}
		}

		// Token: 0x0400DF6E RID: 57198
		public int userID;

		// Token: 0x0400DF6F RID: 57199
		public int id;

		// Token: 0x0400DF70 RID: 57200
		public int color;

		// Token: 0x0400DF71 RID: 57201
		public int texture;

		// Token: 0x0400DF72 RID: 57202
		public string URL;

		// Token: 0x0400DF73 RID: 57203
		public string preURL;

		// Token: 0x0400DF74 RID: 57204
		public int price;

		// Token: 0x0400DF75 RID: 57205
		public int coins;
	}
}
