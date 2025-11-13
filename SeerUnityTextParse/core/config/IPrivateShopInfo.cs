using System;

namespace core.config
{
	// Token: 0x02001DC8 RID: 7624
	public class IPrivateShopInfo : IConfigItem
	{
		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x0600E068 RID: 57448 RVA: 0x003D93B0 File Offset: 0x003D75B0
		// (set) Token: 0x0600E069 RID: 57449 RVA: 0x003D93B8 File Offset: 0x003D75B8
		public string content { get; set; }

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x0600E06A RID: 57450 RVA: 0x003D93C1 File Offset: 0x003D75C1
		// (set) Token: 0x0600E06B RID: 57451 RVA: 0x003D93C9 File Offset: 0x003D75C9
		public string title { get; set; }

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x0600E06C RID: 57452 RVA: 0x003D93D2 File Offset: 0x003D75D2
		// (set) Token: 0x0600E06D RID: 57453 RVA: 0x003D93DA File Offset: 0x003D75DA
		public int bytepos { get; set; }

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x0600E06E RID: 57454 RVA: 0x003D93E3 File Offset: 0x003D75E3
		// (set) Token: 0x0600E06F RID: 57455 RVA: 0x003D93EB File Offset: 0x003D75EB
		public int costNum { get; set; }

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x0600E070 RID: 57456 RVA: 0x003D93F4 File Offset: 0x003D75F4
		// (set) Token: 0x0600E071 RID: 57457 RVA: 0x003D93FC File Offset: 0x003D75FC
		public int costType { get; set; }

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x0600E072 RID: 57458 RVA: 0x003D9405 File Offset: 0x003D7605
		// (set) Token: 0x0600E073 RID: 57459 RVA: 0x003D940D File Offset: 0x003D760D
		public int id { get; set; }

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x0600E074 RID: 57460 RVA: 0x003D9416 File Offset: 0x003D7616
		// (set) Token: 0x0600E075 RID: 57461 RVA: 0x003D941E File Offset: 0x003D761E
		public int limitNum { get; set; }

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x0600E076 RID: 57462 RVA: 0x003D9427 File Offset: 0x003D7627
		// (set) Token: 0x0600E077 RID: 57463 RVA: 0x003D942F File Offset: 0x003D762F
		public int limitType { get; set; }

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x0600E078 RID: 57464 RVA: 0x003D9438 File Offset: 0x003D7638
		// (set) Token: 0x0600E079 RID: 57465 RVA: 0x003D9440 File Offset: 0x003D7640
		public int originPrice { get; set; }

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x0600E07A RID: 57466 RVA: 0x003D9449 File Offset: 0x003D7649
		// (set) Token: 0x0600E07B RID: 57467 RVA: 0x003D9451 File Offset: 0x003D7651
		public int productID { get; set; }

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x0600E07C RID: 57468 RVA: 0x003D945A File Offset: 0x003D765A
		// (set) Token: 0x0600E07D RID: 57469 RVA: 0x003D9462 File Offset: 0x003D7662
		public int type { get; set; }

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x0600E07E RID: 57470 RVA: 0x003D946B File Offset: 0x003D766B
		// (set) Token: 0x0600E07F RID: 57471 RVA: 0x003D9473 File Offset: 0x003D7673
		public int userinfo { get; set; }

		// Token: 0x0600E080 RID: 57472 RVA: 0x003D947C File Offset: 0x003D767C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bytepos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.content = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.costNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.costType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limitNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limitType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.originPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
