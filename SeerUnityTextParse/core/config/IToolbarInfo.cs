using System;

namespace core.config
{
	// Token: 0x020023EB RID: 9195
	public class IToolbarInfo : IConfigItem
	{
		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06011B12 RID: 72466 RVA: 0x004A21E4 File Offset: 0x004A03E4
		// (set) Token: 0x06011B13 RID: 72467 RVA: 0x004A21EC File Offset: 0x004A03EC
		public string chs { get; set; }

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06011B14 RID: 72468 RVA: 0x004A21F5 File Offset: 0x004A03F5
		// (set) Token: 0x06011B15 RID: 72469 RVA: 0x004A21FD File Offset: 0x004A03FD
		public string key { get; set; }

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06011B16 RID: 72470 RVA: 0x004A2206 File Offset: 0x004A0406
		// (set) Token: 0x06011B17 RID: 72471 RVA: 0x004A220E File Offset: 0x004A040E
		public string limitFlag { get; set; }

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06011B18 RID: 72472 RVA: 0x004A2217 File Offset: 0x004A0417
		// (set) Token: 0x06011B19 RID: 72473 RVA: 0x004A221F File Offset: 0x004A041F
		public string reddot { get; set; }

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06011B1A RID: 72474 RVA: 0x004A2228 File Offset: 0x004A0428
		// (set) Token: 0x06011B1B RID: 72475 RVA: 0x004A2230 File Offset: 0x004A0430
		public string res { get; set; }

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06011B1C RID: 72476 RVA: 0x004A2239 File Offset: 0x004A0439
		// (set) Token: 0x06011B1D RID: 72477 RVA: 0x004A2241 File Offset: 0x004A0441
		public string response { get; set; }

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06011B1E RID: 72478 RVA: 0x004A224A File Offset: 0x004A044A
		// (set) Token: 0x06011B1F RID: 72479 RVA: 0x004A2252 File Offset: 0x004A0452
		public string stat { get; set; }

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06011B20 RID: 72480 RVA: 0x004A225B File Offset: 0x004A045B
		// (set) Token: 0x06011B21 RID: 72481 RVA: 0x004A2263 File Offset: 0x004A0463
		public string type { get; set; }

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06011B22 RID: 72482 RVA: 0x004A226C File Offset: 0x004A046C
		// (set) Token: 0x06011B23 RID: 72483 RVA: 0x004A2274 File Offset: 0x004A0474
		public int id { get; set; }

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06011B24 RID: 72484 RVA: 0x004A227D File Offset: 0x004A047D
		// (set) Token: 0x06011B25 RID: 72485 RVA: 0x004A2285 File Offset: 0x004A0485
		public int pos { get; set; }

		// Token: 0x06011B26 RID: 72486 RVA: 0x004A2290 File Offset: 0x004A0490
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.chs = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.key = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.limitFlag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reddot = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.res = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.response = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stat = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
