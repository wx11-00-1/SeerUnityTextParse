using System;

namespace core.config
{
	// Token: 0x0200258F RID: 9615
	public class IAutocardSessionStoreInfo : IConfigItem
	{
		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06012ABD RID: 76477 RVA: 0x00547D58 File Offset: 0x00545F58
		// (set) Token: 0x06012ABE RID: 76478 RVA: 0x00547D60 File Offset: 0x00545F60
		public string commodity { get; set; }

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06012ABF RID: 76479 RVA: 0x00547D69 File Offset: 0x00545F69
		// (set) Token: 0x06012AC0 RID: 76480 RVA: 0x00547D71 File Offset: 0x00545F71
		public int consumeitemid { get; set; }

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06012AC1 RID: 76481 RVA: 0x00547D7A File Offset: 0x00545F7A
		// (set) Token: 0x06012AC2 RID: 76482 RVA: 0x00547D82 File Offset: 0x00545F82
		public int discount { get; set; }

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06012AC3 RID: 76483 RVA: 0x00547D8B File Offset: 0x00545F8B
		// (set) Token: 0x06012AC4 RID: 76484 RVA: 0x00547D93 File Offset: 0x00545F93
		public int id { get; set; }

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06012AC5 RID: 76485 RVA: 0x00547D9C File Offset: 0x00545F9C
		// (set) Token: 0x06012AC6 RID: 76486 RVA: 0x00547DA4 File Offset: 0x00545FA4
		public int limit { get; set; }

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06012AC7 RID: 76487 RVA: 0x00547DAD File Offset: 0x00545FAD
		// (set) Token: 0x06012AC8 RID: 76488 RVA: 0x00547DB5 File Offset: 0x00545FB5
		public int price { get; set; }

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06012AC9 RID: 76489 RVA: 0x00547DBE File Offset: 0x00545FBE
		// (set) Token: 0x06012ACA RID: 76490 RVA: 0x00547DC6 File Offset: 0x00545FC6
		public int producttype { get; set; }

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06012ACB RID: 76491 RVA: 0x00547DCF File Offset: 0x00545FCF
		// (set) Token: 0x06012ACC RID: 76492 RVA: 0x00547DD7 File Offset: 0x00545FD7
		public int quantity { get; set; }

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06012ACD RID: 76493 RVA: 0x00547DE0 File Offset: 0x00545FE0
		// (set) Token: 0x06012ACE RID: 76494 RVA: 0x00547DE8 File Offset: 0x00545FE8
		public int sort { get; set; }

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06012ACF RID: 76495 RVA: 0x00547DF1 File Offset: 0x00545FF1
		// (set) Token: 0x06012AD0 RID: 76496 RVA: 0x00547DF9 File Offset: 0x00545FF9
		public int stat { get; set; }

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06012AD1 RID: 76497 RVA: 0x00547E02 File Offset: 0x00546002
		// (set) Token: 0x06012AD2 RID: 76498 RVA: 0x00547E0A File Offset: 0x0054600A
		public int type { get; set; }

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06012AD3 RID: 76499 RVA: 0x00547E13 File Offset: 0x00546013
		// (set) Token: 0x06012AD4 RID: 76500 RVA: 0x00547E1B File Offset: 0x0054601B
		public int userinfo { get; set; }

		// Token: 0x06012AD5 RID: 76501 RVA: 0x00547E24 File Offset: 0x00546024
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.discount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.producttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
