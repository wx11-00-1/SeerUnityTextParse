using System;

namespace core.config
{
	// Token: 0x02001D76 RID: 7542
	public class ILightAndAarkDeitiesInfo : IConfigItem
	{
		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x0600DCF8 RID: 56568 RVA: 0x003D4FCC File Offset: 0x003D31CC
		// (set) Token: 0x0600DCF9 RID: 56569 RVA: 0x003D4FD4 File Offset: 0x003D31D4
		public string commodity { get; set; }

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x0600DCFA RID: 56570 RVA: 0x003D4FDD File Offset: 0x003D31DD
		// (set) Token: 0x0600DCFB RID: 56571 RVA: 0x003D4FE5 File Offset: 0x003D31E5
		public string petinfo { get; set; }

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x0600DCFC RID: 56572 RVA: 0x003D4FEE File Offset: 0x003D31EE
		// (set) Token: 0x0600DCFD RID: 56573 RVA: 0x003D4FF6 File Offset: 0x003D31F6
		public int id { get; set; }

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x0600DCFE RID: 56574 RVA: 0x003D4FFF File Offset: 0x003D31FF
		// (set) Token: 0x0600DCFF RID: 56575 RVA: 0x003D5007 File Offset: 0x003D3207
		public int price { get; set; }

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x0600DD00 RID: 56576 RVA: 0x003D5010 File Offset: 0x003D3210
		// (set) Token: 0x0600DD01 RID: 56577 RVA: 0x003D5018 File Offset: 0x003D3218
		public int productID { get; set; }

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x0600DD02 RID: 56578 RVA: 0x003D5021 File Offset: 0x003D3221
		// (set) Token: 0x0600DD03 RID: 56579 RVA: 0x003D5029 File Offset: 0x003D3229
		public int tab { get; set; }

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x0600DD04 RID: 56580 RVA: 0x003D5032 File Offset: 0x003D3232
		// (set) Token: 0x0600DD05 RID: 56581 RVA: 0x003D503A File Offset: 0x003D323A
		public int type { get; set; }

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x0600DD06 RID: 56582 RVA: 0x003D5043 File Offset: 0x003D3243
		// (set) Token: 0x0600DD07 RID: 56583 RVA: 0x003D504B File Offset: 0x003D324B
		public int unique { get; set; }

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x0600DD08 RID: 56584 RVA: 0x003D5054 File Offset: 0x003D3254
		// (set) Token: 0x0600DD09 RID: 56585 RVA: 0x003D505C File Offset: 0x003D325C
		public int userInfoBitPos { get; set; }

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x0600DD0A RID: 56586 RVA: 0x003D5065 File Offset: 0x003D3265
		// (set) Token: 0x0600DD0B RID: 56587 RVA: 0x003D506D File Offset: 0x003D326D
		public int userInfoId { get; set; }

		// Token: 0x0600DD0C RID: 56588 RVA: 0x003D5078 File Offset: 0x003D3278
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tab = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unique = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userInfoBitPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
