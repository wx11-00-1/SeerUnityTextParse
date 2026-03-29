using System;

namespace core.config
{
	// Token: 0x0200213B RID: 8507
	public class IAutoCardRecomInfo : IConfigItem
	{
		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x0600FCBC RID: 64700 RVA: 0x0047D3B8 File Offset: 0x0047B5B8
		// (set) Token: 0x0600FCBD RID: 64701 RVA: 0x0047D3C0 File Offset: 0x0047B5C0
		public string MaCardID { get; set; }

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x0600FCBE RID: 64702 RVA: 0x0047D3C9 File Offset: 0x0047B5C9
		// (set) Token: 0x0600FCBF RID: 64703 RVA: 0x0047D3D1 File Offset: 0x0047B5D1
		public string petCardId { get; set; }

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x0600FCC0 RID: 64704 RVA: 0x0047D3DA File Offset: 0x0047B5DA
		// (set) Token: 0x0600FCC1 RID: 64705 RVA: 0x0047D3E2 File Offset: 0x0047B5E2
		public string title { get; set; }

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x0600FCC2 RID: 64706 RVA: 0x0047D3EB File Offset: 0x0047B5EB
		// (set) Token: 0x0600FCC3 RID: 64707 RVA: 0x0047D3F3 File Offset: 0x0047B5F3
		public int classId { get; set; }

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600FCC4 RID: 64708 RVA: 0x0047D3FC File Offset: 0x0047B5FC
		// (set) Token: 0x0600FCC5 RID: 64709 RVA: 0x0047D404 File Offset: 0x0047B604
		public int id { get; set; }

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x0600FCC6 RID: 64710 RVA: 0x0047D40D File Offset: 0x0047B60D
		// (set) Token: 0x0600FCC7 RID: 64711 RVA: 0x0047D415 File Offset: 0x0047B615
		public int petBG { get; set; }

		// Token: 0x0600FCC8 RID: 64712 RVA: 0x0047D420 File Offset: 0x0047B620
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.MaCardID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.classId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petBG = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petCardId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
