using System;

namespace core.config
{
	// Token: 0x02001DE6 RID: 7654
	public class IPvpShopBisaifuInfo : IConfigItem
	{
		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x0600E1A6 RID: 57766 RVA: 0x003DAC64 File Offset: 0x003D8E64
		// (set) Token: 0x0600E1A7 RID: 57767 RVA: 0x003DAC6C File Offset: 0x003D8E6C
		public string commodity { get; set; }

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x0600E1A8 RID: 57768 RVA: 0x003DAC75 File Offset: 0x003D8E75
		// (set) Token: 0x0600E1A9 RID: 57769 RVA: 0x003DAC7D File Offset: 0x003D8E7D
		public string petinfo { get; set; }

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x0600E1AA RID: 57770 RVA: 0x003DAC86 File Offset: 0x003D8E86
		// (set) Token: 0x0600E1AB RID: 57771 RVA: 0x003DAC8E File Offset: 0x003D8E8E
		public int bagLimit { get; set; }

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x0600E1AC RID: 57772 RVA: 0x003DAC97 File Offset: 0x003D8E97
		// (set) Token: 0x0600E1AD RID: 57773 RVA: 0x003DAC9F File Offset: 0x003D8E9F
		public int consumeitemid { get; set; }

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x0600E1AE RID: 57774 RVA: 0x003DACA8 File Offset: 0x003D8EA8
		// (set) Token: 0x0600E1AF RID: 57775 RVA: 0x003DACB0 File Offset: 0x003D8EB0
		public int discount { get; set; }

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x0600E1B0 RID: 57776 RVA: 0x003DACB9 File Offset: 0x003D8EB9
		// (set) Token: 0x0600E1B1 RID: 57777 RVA: 0x003DACC1 File Offset: 0x003D8EC1
		public int id { get; set; }

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x0600E1B2 RID: 57778 RVA: 0x003DACCA File Offset: 0x003D8ECA
		// (set) Token: 0x0600E1B3 RID: 57779 RVA: 0x003DACD2 File Offset: 0x003D8ED2
		public int limit { get; set; }

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x0600E1B4 RID: 57780 RVA: 0x003DACDB File Offset: 0x003D8EDB
		// (set) Token: 0x0600E1B5 RID: 57781 RVA: 0x003DACE3 File Offset: 0x003D8EE3
		public int price { get; set; }

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x0600E1B6 RID: 57782 RVA: 0x003DACEC File Offset: 0x003D8EEC
		// (set) Token: 0x0600E1B7 RID: 57783 RVA: 0x003DACF4 File Offset: 0x003D8EF4
		public int producttype { get; set; }

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x0600E1B8 RID: 57784 RVA: 0x003DACFD File Offset: 0x003D8EFD
		// (set) Token: 0x0600E1B9 RID: 57785 RVA: 0x003DAD05 File Offset: 0x003D8F05
		public int quantity { get; set; }

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x0600E1BA RID: 57786 RVA: 0x003DAD0E File Offset: 0x003D8F0E
		// (set) Token: 0x0600E1BB RID: 57787 RVA: 0x003DAD16 File Offset: 0x003D8F16
		public int sort { get; set; }

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x0600E1BC RID: 57788 RVA: 0x003DAD1F File Offset: 0x003D8F1F
		// (set) Token: 0x0600E1BD RID: 57789 RVA: 0x003DAD27 File Offset: 0x003D8F27
		public int suit { get; set; }

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x0600E1BE RID: 57790 RVA: 0x003DAD30 File Offset: 0x003D8F30
		// (set) Token: 0x0600E1BF RID: 57791 RVA: 0x003DAD38 File Offset: 0x003D8F38
		public int type { get; set; }

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x0600E1C0 RID: 57792 RVA: 0x003DAD41 File Offset: 0x003D8F41
		// (set) Token: 0x0600E1C1 RID: 57793 RVA: 0x003DAD49 File Offset: 0x003D8F49
		public int userinfo { get; set; }

		// Token: 0x0600E1C2 RID: 57794 RVA: 0x003DAD54 File Offset: 0x003D8F54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bagLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.discount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.producttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.suit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
