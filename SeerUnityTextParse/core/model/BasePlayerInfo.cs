using System;

namespace core.model
{
	// Token: 0x0200191E RID: 6430
	public class BasePlayerInfo
	{
		// Token: 0x0600CA3D RID: 51773 RVA: 0x003AF798 File Offset: 0x003AD998
		public BasePlayerInfo(ByteArray by)
		{
			this.id = (int)by.ReadUnsignedInt();
			this.nickName = by.ReadUTFByte(16);
			this.onlineID = (int)by.ReadUnsignedInt();
			this.lastOfflineTime = (int)by.ReadUnsignedInt();
			this.vip = KTool.getBit((int)by.ReadUnsignedInt(), 0);
			this.vipLv = (int)by.ReadUnsignedInt();
			this.head = (int)by.ReadUnsignedInt();
			this.head = ((this.head == 0) ? 1 : this.head);
			this.head_frame = (int)by.ReadUnsignedInt();
			this.itemSend = (int)by.ReadUnsignedByte();
			this.receiveItem = (int)by.ReadUnsignedInt();
		}

		// Token: 0x0600CA3E RID: 51774 RVA: 0x003AF842 File Offset: 0x003ADA42
		public BasePlayerInfo()
		{
		}

		// Token: 0x0400DF15 RID: 57109
		public int id;

		// Token: 0x0400DF16 RID: 57110
		public string nickName;

		// Token: 0x0400DF17 RID: 57111
		public int onlineID;

		// Token: 0x0400DF18 RID: 57112
		public int lastOfflineTime;

		// Token: 0x0400DF19 RID: 57113
		public int vip;

		// Token: 0x0400DF1A RID: 57114
		public int vipLv;

		// Token: 0x0400DF1B RID: 57115
		public int head;

		// Token: 0x0400DF1C RID: 57116
		public int head_frame;

		// Token: 0x0400DF1D RID: 57117
		public int itemSend;

		// Token: 0x0400DF1E RID: 57118
		public int receiveItem;
	}
}
