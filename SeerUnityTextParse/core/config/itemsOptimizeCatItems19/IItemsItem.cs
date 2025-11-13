using System;

namespace core.config.itemsOptimizeCatItems19
{
	// Token: 0x02002003 RID: 8195
	public class IItemsItem
	{
		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x0600F7E3 RID: 63459 RVA: 0x003FD4F4 File Offset: 0x003FB6F4
		// (set) Token: 0x0600F7E4 RID: 63460 RVA: 0x003FD4FC File Offset: 0x003FB6FC
		public string Name { get; set; }

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x0600F7E5 RID: 63461 RVA: 0x003FD505 File Offset: 0x003FB705
		// (set) Token: 0x0600F7E6 RID: 63462 RVA: 0x003FD50D File Offset: 0x003FB70D
		public int catID { get; set; }

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x0600F7E7 RID: 63463 RVA: 0x003FD516 File Offset: 0x003FB716
		// (set) Token: 0x0600F7E8 RID: 63464 RVA: 0x003FD51E File Offset: 0x003FB71E
		public int ID { get; set; }

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x0600F7E9 RID: 63465 RVA: 0x003FD527 File Offset: 0x003FB727
		// (set) Token: 0x0600F7EA RID: 63466 RVA: 0x003FD52F File Offset: 0x003FB72F
		public int Max { get; set; }

		// Token: 0x0600F7EB RID: 63467 RVA: 0x003FD538 File Offset: 0x003FB738
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
