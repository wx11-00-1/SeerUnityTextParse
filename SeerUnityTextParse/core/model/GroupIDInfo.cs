using System;

namespace core.model
{
	// Token: 0x0200193A RID: 6458
	public class GroupIDInfo
	{
		// Token: 0x0600CB92 RID: 52114 RVA: 0x003B21C8 File Offset: 0x003B03C8
		public GroupIDInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.svrID = (int)data.ReadUnsignedShort();
				this.seqID = (int)data.ReadUnsignedInt();
				this.time = (int)data.ReadUnsignedInt();
			}
		}

		// Token: 0x0400E00E RID: 57358
		public int svrID;

		// Token: 0x0400E00F RID: 57359
		public int seqID;

		// Token: 0x0400E010 RID: 57360
		public int time;
	}
}
