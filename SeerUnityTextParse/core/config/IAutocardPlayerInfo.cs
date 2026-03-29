using System;

namespace core.config
{
	// Token: 0x02002139 RID: 8505
	public class IAutocardPlayerInfo : IConfigItem
	{
		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x0600FCA2 RID: 64674 RVA: 0x0047D1D0 File Offset: 0x0047B3D0
		// (set) Token: 0x0600FCA3 RID: 64675 RVA: 0x0047D1D8 File Offset: 0x0047B3D8
		public string action1 { get; set; }

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x0600FCA4 RID: 64676 RVA: 0x0047D1E1 File Offset: 0x0047B3E1
		// (set) Token: 0x0600FCA5 RID: 64677 RVA: 0x0047D1E9 File Offset: 0x0047B3E9
		public string action2 { get; set; }

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x0600FCA6 RID: 64678 RVA: 0x0047D1F2 File Offset: 0x0047B3F2
		// (set) Token: 0x0600FCA7 RID: 64679 RVA: 0x0047D1FA File Offset: 0x0047B3FA
		public string action3 { get; set; }

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x0600FCA8 RID: 64680 RVA: 0x0047D203 File Offset: 0x0047B403
		// (set) Token: 0x0600FCA9 RID: 64681 RVA: 0x0047D20B File Offset: 0x0047B40B
		public string des { get; set; }

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x0600FCAA RID: 64682 RVA: 0x0047D214 File Offset: 0x0047B414
		// (set) Token: 0x0600FCAB RID: 64683 RVA: 0x0047D21C File Offset: 0x0047B41C
		public string name { get; set; }

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x0600FCAC RID: 64684 RVA: 0x0047D225 File Offset: 0x0047B425
		// (set) Token: 0x0600FCAD RID: 64685 RVA: 0x0047D22D File Offset: 0x0047B42D
		public string resource { get; set; }

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x0600FCAE RID: 64686 RVA: 0x0047D236 File Offset: 0x0047B436
		// (set) Token: 0x0600FCAF RID: 64687 RVA: 0x0047D23E File Offset: 0x0047B43E
		public int id { get; set; }

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x0600FCB0 RID: 64688 RVA: 0x0047D247 File Offset: 0x0047B447
		// (set) Token: 0x0600FCB1 RID: 64689 RVA: 0x0047D24F File Offset: 0x0047B44F
		public int jumpinfo { get; set; }

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600FCB2 RID: 64690 RVA: 0x0047D258 File Offset: 0x0047B458
		// (set) Token: 0x0600FCB3 RID: 64691 RVA: 0x0047D260 File Offset: 0x0047B460
		public int moveSpeed { get; set; }

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x0600FCB4 RID: 64692 RVA: 0x0047D269 File Offset: 0x0047B469
		// (set) Token: 0x0600FCB5 RID: 64693 RVA: 0x0047D271 File Offset: 0x0047B471
		public int rarity { get; set; }

		// Token: 0x0600FCB6 RID: 64694 RVA: 0x0047D27C File Offset: 0x0047B47C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.action1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.action2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.action3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jumpinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.moveSpeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.resource = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
