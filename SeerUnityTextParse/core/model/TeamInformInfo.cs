using System;

namespace core.model
{
	// Token: 0x02001981 RID: 6529
	internal class TeamInformInfo
	{
		// Token: 0x0600CCD8 RID: 52440 RVA: 0x003B6600 File Offset: 0x003B4800
		public TeamInformInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.type = (int)data.ReadUnsignedInt();
				this.userID = (int)data.ReadUnsignedInt();
				this.nick = data.ReadUTFByte(16);
				this.data1 = (int)data.ReadUnsignedInt();
				this.data2 = (int)data.ReadUnsignedInt();
			}
		}

		// Token: 0x0400E34A RID: 58186
		public int type;

		// Token: 0x0400E34B RID: 58187
		public int userID;

		// Token: 0x0400E34C RID: 58188
		public string nick;

		// Token: 0x0400E34D RID: 58189
		public int data1;

		// Token: 0x0400E34E RID: 58190
		public int data2;
	}
}
