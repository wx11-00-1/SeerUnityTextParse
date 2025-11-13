using System;

namespace core.config.JackPotShop
{
	// Token: 0x02001FD8 RID: 8152
	public class IBulechipShopItem
	{
		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x0600F5AF RID: 62895 RVA: 0x003FB2CA File Offset: 0x003F94CA
		// (set) Token: 0x0600F5B0 RID: 62896 RVA: 0x003FB2D2 File Offset: 0x003F94D2
		public string productName { get; set; }

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x0600F5B1 RID: 62897 RVA: 0x003FB2DB File Offset: 0x003F94DB
		// (set) Token: 0x0600F5B2 RID: 62898 RVA: 0x003FB2E3 File Offset: 0x003F94E3
		public int[] productID { get; set; }

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600F5B3 RID: 62899 RVA: 0x003FB2EC File Offset: 0x003F94EC
		// (set) Token: 0x0600F5B4 RID: 62900 RVA: 0x003FB2F4 File Offset: 0x003F94F4
		public int batch { get; set; }

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x0600F5B5 RID: 62901 RVA: 0x003FB2FD File Offset: 0x003F94FD
		// (set) Token: 0x0600F5B6 RID: 62902 RVA: 0x003FB305 File Offset: 0x003F9505
		public int Endtime { get; set; }

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x0600F5B7 RID: 62903 RVA: 0x003FB30E File Offset: 0x003F950E
		// (set) Token: 0x0600F5B8 RID: 62904 RVA: 0x003FB316 File Offset: 0x003F9516
		public int exchangeId { get; set; }

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600F5B9 RID: 62905 RVA: 0x003FB31F File Offset: 0x003F951F
		// (set) Token: 0x0600F5BA RID: 62906 RVA: 0x003FB327 File Offset: 0x003F9527
		public int forever { get; set; }

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x0600F5BB RID: 62907 RVA: 0x003FB330 File Offset: 0x003F9530
		// (set) Token: 0x0600F5BC RID: 62908 RVA: 0x003FB338 File Offset: 0x003F9538
		public int ID { get; set; }

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x0600F5BD RID: 62909 RVA: 0x003FB341 File Offset: 0x003F9541
		// (set) Token: 0x0600F5BE RID: 62910 RVA: 0x003FB349 File Offset: 0x003F9549
		public int Opentime { get; set; }

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x0600F5BF RID: 62911 RVA: 0x003FB352 File Offset: 0x003F9552
		// (set) Token: 0x0600F5C0 RID: 62912 RVA: 0x003FB35A File Offset: 0x003F955A
		public int productPrice { get; set; }

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x0600F5C1 RID: 62913 RVA: 0x003FB363 File Offset: 0x003F9563
		// (set) Token: 0x0600F5C2 RID: 62914 RVA: 0x003FB36B File Offset: 0x003F956B
		public int shopkind { get; set; }

		// Token: 0x0600F5C3 RID: 62915 RVA: 0x003FB374 File Offset: 0x003F9574
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.batch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.forever = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.productID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.productID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.productName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.productPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.shopkind = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
