using System;

namespace core.config.itemsOptimizeCatItems8
{
	// Token: 0x02001FE7 RID: 8167
	public class IItemsItem
	{
		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x0600F615 RID: 62997 RVA: 0x003FB9B4 File Offset: 0x003F9BB4
		// (set) Token: 0x0600F616 RID: 62998 RVA: 0x003FB9BC File Offset: 0x003F9BBC
		public string Name { get; set; }

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600F617 RID: 62999 RVA: 0x003FB9C5 File Offset: 0x003F9BC5
		// (set) Token: 0x0600F618 RID: 63000 RVA: 0x003FB9CD File Offset: 0x003F9BCD
		public int catID { get; set; }

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x0600F619 RID: 63001 RVA: 0x003FB9D6 File Offset: 0x003F9BD6
		// (set) Token: 0x0600F61A RID: 63002 RVA: 0x003FB9DE File Offset: 0x003F9BDE
		public int ID { get; set; }

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x0600F61B RID: 63003 RVA: 0x003FB9E7 File Offset: 0x003F9BE7
		// (set) Token: 0x0600F61C RID: 63004 RVA: 0x003FB9EF File Offset: 0x003F9BEF
		public int Max { get; set; }

		// Token: 0x0600F61D RID: 63005 RVA: 0x003FB9F8 File Offset: 0x003F9BF8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
