using System;

namespace core.config
{
	// Token: 0x02001DE4 RID: 7652
	public class IPvpShopInfo : IConfigItem
	{
		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x0600E184 RID: 57732 RVA: 0x003DAA20 File Offset: 0x003D8C20
		// (set) Token: 0x0600E185 RID: 57733 RVA: 0x003DAA28 File Offset: 0x003D8C28
		public string commodity { get; set; }

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x0600E186 RID: 57734 RVA: 0x003DAA31 File Offset: 0x003D8C31
		// (set) Token: 0x0600E187 RID: 57735 RVA: 0x003DAA39 File Offset: 0x003D8C39
		public string petinfo { get; set; }

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x0600E188 RID: 57736 RVA: 0x003DAA42 File Offset: 0x003D8C42
		// (set) Token: 0x0600E189 RID: 57737 RVA: 0x003DAA4A File Offset: 0x003D8C4A
		public int bagLimit { get; set; }

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x0600E18A RID: 57738 RVA: 0x003DAA53 File Offset: 0x003D8C53
		// (set) Token: 0x0600E18B RID: 57739 RVA: 0x003DAA5B File Offset: 0x003D8C5B
		public int consumeitemid { get; set; }

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x0600E18C RID: 57740 RVA: 0x003DAA64 File Offset: 0x003D8C64
		// (set) Token: 0x0600E18D RID: 57741 RVA: 0x003DAA6C File Offset: 0x003D8C6C
		public int discount { get; set; }

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x0600E18E RID: 57742 RVA: 0x003DAA75 File Offset: 0x003D8C75
		// (set) Token: 0x0600E18F RID: 57743 RVA: 0x003DAA7D File Offset: 0x003D8C7D
		public int id { get; set; }

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x0600E190 RID: 57744 RVA: 0x003DAA86 File Offset: 0x003D8C86
		// (set) Token: 0x0600E191 RID: 57745 RVA: 0x003DAA8E File Offset: 0x003D8C8E
		public int limit { get; set; }

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x0600E192 RID: 57746 RVA: 0x003DAA97 File Offset: 0x003D8C97
		// (set) Token: 0x0600E193 RID: 57747 RVA: 0x003DAA9F File Offset: 0x003D8C9F
		public int price { get; set; }

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x0600E194 RID: 57748 RVA: 0x003DAAA8 File Offset: 0x003D8CA8
		// (set) Token: 0x0600E195 RID: 57749 RVA: 0x003DAAB0 File Offset: 0x003D8CB0
		public int producttype { get; set; }

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x0600E196 RID: 57750 RVA: 0x003DAAB9 File Offset: 0x003D8CB9
		// (set) Token: 0x0600E197 RID: 57751 RVA: 0x003DAAC1 File Offset: 0x003D8CC1
		public int quantity { get; set; }

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x0600E198 RID: 57752 RVA: 0x003DAACA File Offset: 0x003D8CCA
		// (set) Token: 0x0600E199 RID: 57753 RVA: 0x003DAAD2 File Offset: 0x003D8CD2
		public int sort { get; set; }

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x0600E19A RID: 57754 RVA: 0x003DAADB File Offset: 0x003D8CDB
		// (set) Token: 0x0600E19B RID: 57755 RVA: 0x003DAAE3 File Offset: 0x003D8CE3
		public int suit { get; set; }

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x0600E19C RID: 57756 RVA: 0x003DAAEC File Offset: 0x003D8CEC
		// (set) Token: 0x0600E19D RID: 57757 RVA: 0x003DAAF4 File Offset: 0x003D8CF4
		public int type { get; set; }

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x0600E19E RID: 57758 RVA: 0x003DAAFD File Offset: 0x003D8CFD
		// (set) Token: 0x0600E19F RID: 57759 RVA: 0x003DAB05 File Offset: 0x003D8D05
		public int userinfo { get; set; }

		// Token: 0x0600E1A0 RID: 57760 RVA: 0x003DAB10 File Offset: 0x003D8D10
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
