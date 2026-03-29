using System;

namespace core.config.new_starmap
{
	// Token: 0x02002526 RID: 9510
	public class IItemItem : IConfigItem
	{
		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x060126CA RID: 75466 RVA: 0x004B8EA4 File Offset: 0x004B70A4
		// (set) Token: 0x060126CB RID: 75467 RVA: 0x004B8EAC File Offset: 0x004B70AC
		public string intro { get; set; }

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x060126CC RID: 75468 RVA: 0x004B8EB5 File Offset: 0x004B70B5
		// (set) Token: 0x060126CD RID: 75469 RVA: 0x004B8EBD File Offset: 0x004B70BD
		public string name { get; set; }

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x060126CE RID: 75470 RVA: 0x004B8EC6 File Offset: 0x004B70C6
		// (set) Token: 0x060126CF RID: 75471 RVA: 0x004B8ECE File Offset: 0x004B70CE
		public string StarContrl { get; set; }

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x060126D0 RID: 75472 RVA: 0x004B8ED7 File Offset: 0x004B70D7
		// (set) Token: 0x060126D1 RID: 75473 RVA: 0x004B8EDF File Offset: 0x004B70DF
		public string submap { get; set; }

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x060126D2 RID: 75474 RVA: 0x004B8EE8 File Offset: 0x004B70E8
		// (set) Token: 0x060126D3 RID: 75475 RVA: 0x004B8EF0 File Offset: 0x004B70F0
		public string TipContrl { get; set; }

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x060126D4 RID: 75476 RVA: 0x004B8EF9 File Offset: 0x004B70F9
		// (set) Token: 0x060126D5 RID: 75477 RVA: 0x004B8F01 File Offset: 0x004B7101
		public int anima { get; set; }

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x060126D6 RID: 75478 RVA: 0x004B8F0A File Offset: 0x004B710A
		// (set) Token: 0x060126D7 RID: 75479 RVA: 0x004B8F12 File Offset: 0x004B7112
		public int Gotomap { get; set; }

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x060126D8 RID: 75480 RVA: 0x004B8F1B File Offset: 0x004B711B
		// (set) Token: 0x060126D9 RID: 75481 RVA: 0x004B8F23 File Offset: 0x004B7123
		public int id { get; set; }

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x060126DA RID: 75482 RVA: 0x004B8F2C File Offset: 0x004B712C
		// (set) Token: 0x060126DB RID: 75483 RVA: 0x004B8F34 File Offset: 0x004B7134
		public int isopen { get; set; }

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x060126DC RID: 75484 RVA: 0x004B8F3D File Offset: 0x004B713D
		// (set) Token: 0x060126DD RID: 75485 RVA: 0x004B8F45 File Offset: 0x004B7145
		public int StarShow { get; set; }

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x060126DE RID: 75486 RVA: 0x004B8F4E File Offset: 0x004B714E
		// (set) Token: 0x060126DF RID: 75487 RVA: 0x004B8F56 File Offset: 0x004B7156
		public int TipShow { get; set; }

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x060126E0 RID: 75488 RVA: 0x004B8F5F File Offset: 0x004B715F
		// (set) Token: 0x060126E1 RID: 75489 RVA: 0x004B8F67 File Offset: 0x004B7167
		public int TipType { get; set; }

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x060126E2 RID: 75490 RVA: 0x004B8F70 File Offset: 0x004B7170
		// (set) Token: 0x060126E3 RID: 75491 RVA: 0x004B8F78 File Offset: 0x004B7178
		public int type { get; set; }

		// Token: 0x060126E4 RID: 75492 RVA: 0x004B8F84 File Offset: 0x004B7184
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Gotomap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.StarContrl = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.StarShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TipContrl = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.TipShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TipType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.anima = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.submap = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
