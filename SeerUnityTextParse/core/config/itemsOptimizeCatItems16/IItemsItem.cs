using System;

namespace core.config.itemsOptimizeCatItems16
{
	// Token: 0x02002009 RID: 8201
	public class IItemsItem
	{
		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x0600F860 RID: 63584 RVA: 0x003FDC1C File Offset: 0x003FBE1C
		// (set) Token: 0x0600F861 RID: 63585 RVA: 0x003FDC24 File Offset: 0x003FBE24
		public string Name { get; set; }

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x0600F862 RID: 63586 RVA: 0x003FDC2D File Offset: 0x003FBE2D
		// (set) Token: 0x0600F863 RID: 63587 RVA: 0x003FDC35 File Offset: 0x003FBE35
		public int catID { get; set; }

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600F864 RID: 63588 RVA: 0x003FDC3E File Offset: 0x003FBE3E
		// (set) Token: 0x0600F865 RID: 63589 RVA: 0x003FDC46 File Offset: 0x003FBE46
		public int ID { get; set; }

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x0600F866 RID: 63590 RVA: 0x003FDC4F File Offset: 0x003FBE4F
		// (set) Token: 0x0600F867 RID: 63591 RVA: 0x003FDC57 File Offset: 0x003FBE57
		public int Max { get; set; }

		// Token: 0x0600F868 RID: 63592 RVA: 0x003FDC60 File Offset: 0x003FBE60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
