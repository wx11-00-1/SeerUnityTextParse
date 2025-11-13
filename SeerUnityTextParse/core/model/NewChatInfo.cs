using System;
using System.Linq;
//using core.webFile;

namespace core.model
{
	// Token: 0x02001946 RID: 6470
	[Serializable]
	public class NewChatInfo
	{
		// Token: 0x0600CBC9 RID: 52169 RVA: 0x003B278D File Offset: 0x003B098D
		public NewChatInfo()
		{
		}

		// Token: 0x0600CBCA RID: 52170 RVA: 0x003B2798 File Offset: 0x003B0998
		public NewChatInfo(ByteArray data)
		{
			//if (data == null)
			//{
			//	return;
			//}
			//this.type = (int)data.ReadUnsignedInt();
			//this.senderID = (int)data.ReadUnsignedInt();
			//this.toID = (int)data.ReadUnsignedInt();
			//this.toNickName = data.ReadUTFByte(16);
			//int num = (int)data.ReadUnsignedInt();
			//if (num > 4)
			//{
			//	if (data.ReadBytes(4).SequenceEqual(WebFileManager.magic))
			//	{
			//		this.isTurmaShare = true;
			//		this.suitId = data.ReadUnsignedInt();
			//		this.titleId = data.ReadUnsignedInt();
			//		this.petIds = new uint[12];
			//		for (int i = 0; i < 12; i++)
			//		{
			//			this.petIds[i] = data.ReadUnsignedInt();
			//		}
			//		this.shareKey = data.ReadUTFBytes(128);
			//		this.msg = "[阵容分享]";
			//		this.senderNicName = data.ReadUTFByte(16);
			//		this.head_id = (int)data.ReadUnsignedInt();
			//		this.head_id = ((this.head_id == 0) ? 1 : this.head_id);
			//		this.head_frame = (int)data.ReadUnsignedInt();
			//		this.vip_lv = (int)data.ReadUnsignedInt();
			//		return;
			//	}
			//	data.position -= 4;
			//}
			//this.msg = data.ReadUTFByte(num);
			//this.senderNicName = data.ReadUTFByte(16);
			//this.head_id = (int)data.ReadUnsignedInt();
			//this.head_id = ((this.head_id == 0) ? 1 : this.head_id);
			//this.head_frame = (int)data.ReadUnsignedInt();
			//this.vip_lv = (int)data.ReadUnsignedInt();
		}

		// Token: 0x0400E11E RID: 57630
		public int senderID;

		// Token: 0x0400E11F RID: 57631
		public string senderNicName;

		// Token: 0x0400E120 RID: 57632
		public int toID;

		// Token: 0x0400E121 RID: 57633
		public string msg;

		// Token: 0x0400E122 RID: 57634
		public bool isRead;

		// Token: 0x0400E123 RID: 57635
		public int type;

		// Token: 0x0400E124 RID: 57636
		public int head_id;

		// Token: 0x0400E125 RID: 57637
		public int head_frame;

		// Token: 0x0400E126 RID: 57638
		public int vip_lv;

		// Token: 0x0400E127 RID: 57639
		public string toNickName;

		// Token: 0x0400E128 RID: 57640
		public bool isTurmaShare;

		// Token: 0x0400E129 RID: 57641
		public uint[] petIds;

		// Token: 0x0400E12A RID: 57642
		public uint suitId;

		// Token: 0x0400E12B RID: 57643
		public uint titleId;

		// Token: 0x0400E12C RID: 57644
		public string shareKey;
	}
}
