using System;

namespace core.config
{
	// Token: 0x02002295 RID: 8853
	public class ILimitUseItemInfoInfo : IConfigItem
	{
		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x06010BDA RID: 68570 RVA: 0x0048F510 File Offset: 0x0048D710
		// (set) Token: 0x06010BDB RID: 68571 RVA: 0x0048F518 File Offset: 0x0048D718
		public string LimitUseItemName { get; set; }

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06010BDC RID: 68572 RVA: 0x0048F521 File Offset: 0x0048D721
		// (set) Token: 0x06010BDD RID: 68573 RVA: 0x0048F529 File Offset: 0x0048D729
		public int id { get; set; }

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06010BDE RID: 68574 RVA: 0x0048F532 File Offset: 0x0048D732
		// (set) Token: 0x06010BDF RID: 68575 RVA: 0x0048F53A File Offset: 0x0048D73A
		public int LimitUseItemId { get; set; }

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06010BE0 RID: 68576 RVA: 0x0048F543 File Offset: 0x0048D743
		// (set) Token: 0x06010BE1 RID: 68577 RVA: 0x0048F54B File Offset: 0x0048D74B
		public int LimitUseItemMaxNum { get; set; }

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06010BE2 RID: 68578 RVA: 0x0048F554 File Offset: 0x0048D754
		// (set) Token: 0x06010BE3 RID: 68579 RVA: 0x0048F55C File Offset: 0x0048D75C
		public int LimitUseItemUserInfo { get; set; }

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x06010BE4 RID: 68580 RVA: 0x0048F565 File Offset: 0x0048D765
		// (set) Token: 0x06010BE5 RID: 68581 RVA: 0x0048F56D File Offset: 0x0048D76D
		public int LimitUseType { get; set; }

		// Token: 0x06010BE6 RID: 68582 RVA: 0x0048F578 File Offset: 0x0048D778
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.LimitUseItemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LimitUseItemMaxNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LimitUseItemName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.LimitUseItemUserInfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LimitUseType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
