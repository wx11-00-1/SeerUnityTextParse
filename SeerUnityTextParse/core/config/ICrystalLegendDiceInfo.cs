using System;

namespace core.config
{
	// Token: 0x02001D0E RID: 7438
	public class ICrystalLegendDiceInfo : IConfigItem
	{
		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x0600D90A RID: 55562 RVA: 0x003D00DC File Offset: 0x003CE2DC
		// (set) Token: 0x0600D90B RID: 55563 RVA: 0x003D00E4 File Offset: 0x003CE2E4
		public string name { get; set; }

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x0600D90C RID: 55564 RVA: 0x003D00ED File Offset: 0x003CE2ED
		// (set) Token: 0x0600D90D RID: 55565 RVA: 0x003D00F5 File Offset: 0x003CE2F5
		public string surface1 { get; set; }

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x0600D90E RID: 55566 RVA: 0x003D00FE File Offset: 0x003CE2FE
		// (set) Token: 0x0600D90F RID: 55567 RVA: 0x003D0106 File Offset: 0x003CE306
		public string surface2 { get; set; }

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x0600D910 RID: 55568 RVA: 0x003D010F File Offset: 0x003CE30F
		// (set) Token: 0x0600D911 RID: 55569 RVA: 0x003D0117 File Offset: 0x003CE317
		public string surface3 { get; set; }

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x0600D912 RID: 55570 RVA: 0x003D0120 File Offset: 0x003CE320
		// (set) Token: 0x0600D913 RID: 55571 RVA: 0x003D0128 File Offset: 0x003CE328
		public string surface4 { get; set; }

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x0600D914 RID: 55572 RVA: 0x003D0131 File Offset: 0x003CE331
		// (set) Token: 0x0600D915 RID: 55573 RVA: 0x003D0139 File Offset: 0x003CE339
		public string surface5 { get; set; }

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x0600D916 RID: 55574 RVA: 0x003D0142 File Offset: 0x003CE342
		// (set) Token: 0x0600D917 RID: 55575 RVA: 0x003D014A File Offset: 0x003CE34A
		public string surface6 { get; set; }

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x0600D918 RID: 55576 RVA: 0x003D0153 File Offset: 0x003CE353
		// (set) Token: 0x0600D919 RID: 55577 RVA: 0x003D015B File Offset: 0x003CE35B
		public int belongDiceID { get; set; }

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x0600D91A RID: 55578 RVA: 0x003D0164 File Offset: 0x003CE364
		// (set) Token: 0x0600D91B RID: 55579 RVA: 0x003D016C File Offset: 0x003CE36C
		public int id { get; set; }

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x0600D91C RID: 55580 RVA: 0x003D0175 File Offset: 0x003CE375
		// (set) Token: 0x0600D91D RID: 55581 RVA: 0x003D017D File Offset: 0x003CE37D
		public int price { get; set; }

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x0600D91E RID: 55582 RVA: 0x003D0186 File Offset: 0x003CE386
		// (set) Token: 0x0600D91F RID: 55583 RVA: 0x003D018E File Offset: 0x003CE38E
		public int strengthenType { get; set; }

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x0600D920 RID: 55584 RVA: 0x003D0197 File Offset: 0x003CE397
		// (set) Token: 0x0600D921 RID: 55585 RVA: 0x003D019F File Offset: 0x003CE39F
		public int type { get; set; }

		// Token: 0x0600D922 RID: 55586 RVA: 0x003D01A8 File Offset: 0x003CE3A8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.belongDiceID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.strengthenType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.surface1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.surface2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.surface3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.surface4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.surface5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.surface6 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
