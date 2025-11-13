using System;

namespace core.config.itemsOptimizeCatItems22
{
	// Token: 0x02001FFB RID: 8187
	public class IItemsItem
	{
		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x0600F796 RID: 63382 RVA: 0x003FCFF0 File Offset: 0x003FB1F0
		// (set) Token: 0x0600F797 RID: 63383 RVA: 0x003FCFF8 File Offset: 0x003FB1F8
		public string Name { get; set; }

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x0600F798 RID: 63384 RVA: 0x003FD001 File Offset: 0x003FB201
		// (set) Token: 0x0600F799 RID: 63385 RVA: 0x003FD009 File Offset: 0x003FB209
		public int catID { get; set; }

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x0600F79A RID: 63386 RVA: 0x003FD012 File Offset: 0x003FB212
		// (set) Token: 0x0600F79B RID: 63387 RVA: 0x003FD01A File Offset: 0x003FB21A
		public int ID { get; set; }

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x0600F79C RID: 63388 RVA: 0x003FD023 File Offset: 0x003FB223
		// (set) Token: 0x0600F79D RID: 63389 RVA: 0x003FD02B File Offset: 0x003FB22B
		public int Max { get; set; }

		// Token: 0x0600F79E RID: 63390 RVA: 0x003FD034 File Offset: 0x003FB234
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
