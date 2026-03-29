using System;

namespace core.config.product_coins
{
	// Token: 0x020024BE RID: 9406
	public class IItemItem
	{
		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x0601234C RID: 74572 RVA: 0x004B43B0 File Offset: 0x004B25B0
		// (set) Token: 0x0601234D RID: 74573 RVA: 0x004B43B8 File Offset: 0x004B25B8
		public string itemID { get; set; }

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x0601234E RID: 74574 RVA: 0x004B43C1 File Offset: 0x004B25C1
		// (set) Token: 0x0601234F RID: 74575 RVA: 0x004B43C9 File Offset: 0x004B25C9
		public string name { get; set; }

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x06012350 RID: 74576 RVA: 0x004B43D2 File Offset: 0x004B25D2
		// (set) Token: 0x06012351 RID: 74577 RVA: 0x004B43DA File Offset: 0x004B25DA
		public int coins { get; set; }

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x06012352 RID: 74578 RVA: 0x004B43E3 File Offset: 0x004B25E3
		// (set) Token: 0x06012353 RID: 74579 RVA: 0x004B43EB File Offset: 0x004B25EB
		public int limit { get; set; }

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x06012354 RID: 74580 RVA: 0x004B43F4 File Offset: 0x004B25F4
		// (set) Token: 0x06012355 RID: 74581 RVA: 0x004B43FC File Offset: 0x004B25FC
		public int price { get; set; }

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x06012356 RID: 74582 RVA: 0x004B4405 File Offset: 0x004B2605
		// (set) Token: 0x06012357 RID: 74583 RVA: 0x004B440D File Offset: 0x004B260D
		public int productID { get; set; }

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x06012358 RID: 74584 RVA: 0x004B4416 File Offset: 0x004B2616
		// (set) Token: 0x06012359 RID: 74585 RVA: 0x004B441E File Offset: 0x004B261E
		public int productType { get; set; }

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x0601235A RID: 74586 RVA: 0x004B4427 File Offset: 0x004B2627
		// (set) Token: 0x0601235B RID: 74587 RVA: 0x004B442F File Offset: 0x004B262F
		public int times { get; set; }

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x0601235C RID: 74588 RVA: 0x004B4438 File Offset: 0x004B2638
		// (set) Token: 0x0601235D RID: 74589 RVA: 0x004B4440 File Offset: 0x004B2640
		public int type { get; set; }

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x0601235E RID: 74590 RVA: 0x004B4449 File Offset: 0x004B2649
		// (set) Token: 0x0601235F RID: 74591 RVA: 0x004B4451 File Offset: 0x004B2651
		public int vip { get; set; }

		// Token: 0x06012360 RID: 74592 RVA: 0x004B445C File Offset: 0x004B265C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.coins = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.times = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.vip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
