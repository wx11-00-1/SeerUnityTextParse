using System;

namespace core.config
{
	// Token: 0x02001D24 RID: 7460
	public class IDailytaskGiftInfo : IConfigItem
	{
		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x0600D9D8 RID: 55768 RVA: 0x003D1050 File Offset: 0x003CF250
		// (set) Token: 0x0600D9D9 RID: 55769 RVA: 0x003D1058 File Offset: 0x003CF258
		public string name { get; set; }

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x0600D9DA RID: 55770 RVA: 0x003D1061 File Offset: 0x003CF261
		// (set) Token: 0x0600D9DB RID: 55771 RVA: 0x003D1069 File Offset: 0x003CF269
		public string rewardinfo { get; set; }

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x0600D9DC RID: 55772 RVA: 0x003D1072 File Offset: 0x003CF272
		// (set) Token: 0x0600D9DD RID: 55773 RVA: 0x003D107A File Offset: 0x003CF27A
		public int activity { get; set; }

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x0600D9DE RID: 55774 RVA: 0x003D1083 File Offset: 0x003CF283
		// (set) Token: 0x0600D9DF RID: 55775 RVA: 0x003D108B File Offset: 0x003CF28B
		public int diamond { get; set; }

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x0600D9E0 RID: 55776 RVA: 0x003D1094 File Offset: 0x003CF294
		// (set) Token: 0x0600D9E1 RID: 55777 RVA: 0x003D109C File Offset: 0x003CF29C
		public int icon { get; set; }

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x0600D9E2 RID: 55778 RVA: 0x003D10A5 File Offset: 0x003CF2A5
		// (set) Token: 0x0600D9E3 RID: 55779 RVA: 0x003D10AD File Offset: 0x003CF2AD
		public int id { get; set; }

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x0600D9E4 RID: 55780 RVA: 0x003D10B6 File Offset: 0x003CF2B6
		// (set) Token: 0x0600D9E5 RID: 55781 RVA: 0x003D10BE File Offset: 0x003CF2BE
		public int NewStatLog { get; set; }

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x0600D9E6 RID: 55782 RVA: 0x003D10C7 File Offset: 0x003CF2C7
		// (set) Token: 0x0600D9E7 RID: 55783 RVA: 0x003D10CF File Offset: 0x003CF2CF
		public int type { get; set; }

		// Token: 0x0600D9E8 RID: 55784 RVA: 0x003D10D8 File Offset: 0x003CF2D8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewStatLog = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.activity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.diamond = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
