using System;

namespace core.config
{
	// Token: 0x02002895 RID: 10389
	public class IDuelChatInfo : IConfigItem
	{
		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06014C44 RID: 85060 RVA: 0x005B3AF8 File Offset: 0x005B1CF8
		// (set) Token: 0x06014C45 RID: 85061 RVA: 0x005B3B00 File Offset: 0x005B1D00
		public string describe { get; set; }

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06014C46 RID: 85062 RVA: 0x005B3B09 File Offset: 0x005B1D09
		// (set) Token: 0x06014C47 RID: 85063 RVA: 0x005B3B11 File Offset: 0x005B1D11
		public int chattype { get; set; }

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06014C48 RID: 85064 RVA: 0x005B3B1A File Offset: 0x005B1D1A
		// (set) Token: 0x06014C49 RID: 85065 RVA: 0x005B3B22 File Offset: 0x005B1D22
		public int endtime { get; set; }

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06014C4A RID: 85066 RVA: 0x005B3B2B File Offset: 0x005B1D2B
		// (set) Token: 0x06014C4B RID: 85067 RVA: 0x005B3B33 File Offset: 0x005B1D33
		public int head { get; set; }

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06014C4C RID: 85068 RVA: 0x005B3B3C File Offset: 0x005B1D3C
		// (set) Token: 0x06014C4D RID: 85069 RVA: 0x005B3B44 File Offset: 0x005B1D44
		public int id { get; set; }

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06014C4E RID: 85070 RVA: 0x005B3B4D File Offset: 0x005B1D4D
		// (set) Token: 0x06014C4F RID: 85071 RVA: 0x005B3B55 File Offset: 0x005B1D55
		public int LevelId { get; set; }

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06014C50 RID: 85072 RVA: 0x005B3B5E File Offset: 0x005B1D5E
		// (set) Token: 0x06014C51 RID: 85073 RVA: 0x005B3B66 File Offset: 0x005B1D66
		public int starttime { get; set; }

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x06014C52 RID: 85074 RVA: 0x005B3B6F File Offset: 0x005B1D6F
		// (set) Token: 0x06014C53 RID: 85075 RVA: 0x005B3B77 File Offset: 0x005B1D77
		public int texttype { get; set; }

		// Token: 0x06014C54 RID: 85076 RVA: 0x005B3B80 File Offset: 0x005B1D80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.LevelId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.chattype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.head = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.texttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
