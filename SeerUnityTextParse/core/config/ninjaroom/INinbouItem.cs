using System;

namespace core.config.ninjaroom
{
	// Token: 0x02002511 RID: 9489
	public class INinbouItem : IConfigItem
	{
		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x060125EC RID: 75244 RVA: 0x004B7A60 File Offset: 0x004B5C60
		// (set) Token: 0x060125ED RID: 75245 RVA: 0x004B7A68 File Offset: 0x004B5C68
		public string NewStatLog { get; set; }

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x060125EE RID: 75246 RVA: 0x004B7A71 File Offset: 0x004B5C71
		// (set) Token: 0x060125EF RID: 75247 RVA: 0x004B7A79 File Offset: 0x004B5C79
		public string rewardcnt { get; set; }

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x060125F0 RID: 75248 RVA: 0x004B7A82 File Offset: 0x004B5C82
		// (set) Token: 0x060125F1 RID: 75249 RVA: 0x004B7A8A File Offset: 0x004B5C8A
		public string rewardid { get; set; }

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x060125F2 RID: 75250 RVA: 0x004B7A93 File Offset: 0x004B5C93
		// (set) Token: 0x060125F3 RID: 75251 RVA: 0x004B7A9B File Offset: 0x004B5C9B
		public string rewardtype { get; set; }

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x060125F4 RID: 75252 RVA: 0x004B7AA4 File Offset: 0x004B5CA4
		// (set) Token: 0x060125F5 RID: 75253 RVA: 0x004B7AAC File Offset: 0x004B5CAC
		public int boss { get; set; }

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x060125F6 RID: 75254 RVA: 0x004B7AB5 File Offset: 0x004B5CB5
		// (set) Token: 0x060125F7 RID: 75255 RVA: 0x004B7ABD File Offset: 0x004B5CBD
		public int exp { get; set; }

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x060125F8 RID: 75256 RVA: 0x004B7AC6 File Offset: 0x004B5CC6
		// (set) Token: 0x060125F9 RID: 75257 RVA: 0x004B7ACE File Offset: 0x004B5CCE
		public int grade { get; set; }

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x060125FA RID: 75258 RVA: 0x004B7AD7 File Offset: 0x004B5CD7
		// (set) Token: 0x060125FB RID: 75259 RVA: 0x004B7ADF File Offset: 0x004B5CDF
		public int id { get; set; }

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x060125FC RID: 75260 RVA: 0x004B7AE8 File Offset: 0x004B5CE8
		// (set) Token: 0x060125FD RID: 75261 RVA: 0x004B7AF0 File Offset: 0x004B5CF0
		public int lv { get; set; }

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x060125FE RID: 75262 RVA: 0x004B7AF9 File Offset: 0x004B5CF9
		// (set) Token: 0x060125FF RID: 75263 RVA: 0x004B7B01 File Offset: 0x004B5D01
		public int output { get; set; }

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x06012600 RID: 75264 RVA: 0x004B7B0A File Offset: 0x004B5D0A
		// (set) Token: 0x06012601 RID: 75265 RVA: 0x004B7B12 File Offset: 0x004B5D12
		public int sebossid { get; set; }

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x06012602 RID: 75266 RVA: 0x004B7B1B File Offset: 0x004B5D1B
		// (set) Token: 0x06012603 RID: 75267 RVA: 0x004B7B23 File Offset: 0x004B5D23
		public int times { get; set; }

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x06012604 RID: 75268 RVA: 0x004B7B2C File Offset: 0x004B5D2C
		// (set) Token: 0x06012605 RID: 75269 RVA: 0x004B7B34 File Offset: 0x004B5D34
		public int type { get; set; }

		// Token: 0x06012606 RID: 75270 RVA: 0x004B7B40 File Offset: 0x004B5D40
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewStatLog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.boss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.grade = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.output = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sebossid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.times = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
