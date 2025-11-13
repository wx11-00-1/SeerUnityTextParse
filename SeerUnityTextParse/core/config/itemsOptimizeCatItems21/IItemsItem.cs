using System;

namespace core.config.itemsOptimizeCatItems21
{
	// Token: 0x02001FFD RID: 8189
	public class IItemsItem
	{
		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x0600F7A6 RID: 63398 RVA: 0x003FD108 File Offset: 0x003FB308
		// (set) Token: 0x0600F7A7 RID: 63399 RVA: 0x003FD110 File Offset: 0x003FB310
		public string Name { get; set; }

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x0600F7A8 RID: 63400 RVA: 0x003FD119 File Offset: 0x003FB319
		// (set) Token: 0x0600F7A9 RID: 63401 RVA: 0x003FD121 File Offset: 0x003FB321
		public int catID { get; set; }

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x0600F7AA RID: 63402 RVA: 0x003FD12A File Offset: 0x003FB32A
		// (set) Token: 0x0600F7AB RID: 63403 RVA: 0x003FD132 File Offset: 0x003FB332
		public int ID { get; set; }

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x0600F7AC RID: 63404 RVA: 0x003FD13B File Offset: 0x003FB33B
		// (set) Token: 0x0600F7AD RID: 63405 RVA: 0x003FD143 File Offset: 0x003FB343
		public int Max { get; set; }

		// Token: 0x0600F7AE RID: 63406 RVA: 0x003FD14C File Offset: 0x003FB34C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
