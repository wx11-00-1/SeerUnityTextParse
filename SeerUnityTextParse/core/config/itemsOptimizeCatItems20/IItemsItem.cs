using System;

namespace core.config.itemsOptimizeCatItems20
{
	// Token: 0x02001FFF RID: 8191
	public class IItemsItem
	{
		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x0600F7B6 RID: 63414 RVA: 0x003FD220 File Offset: 0x003FB420
		// (set) Token: 0x0600F7B7 RID: 63415 RVA: 0x003FD228 File Offset: 0x003FB428
		public string Name { get; set; }

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x0600F7B8 RID: 63416 RVA: 0x003FD231 File Offset: 0x003FB431
		// (set) Token: 0x0600F7B9 RID: 63417 RVA: 0x003FD239 File Offset: 0x003FB439
		public int catID { get; set; }

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x0600F7BA RID: 63418 RVA: 0x003FD242 File Offset: 0x003FB442
		// (set) Token: 0x0600F7BB RID: 63419 RVA: 0x003FD24A File Offset: 0x003FB44A
		public int ID { get; set; }

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x0600F7BC RID: 63420 RVA: 0x003FD253 File Offset: 0x003FB453
		// (set) Token: 0x0600F7BD RID: 63421 RVA: 0x003FD25B File Offset: 0x003FB45B
		public int Max { get; set; }

		// Token: 0x0600F7BE RID: 63422 RVA: 0x003FD264 File Offset: 0x003FB464
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
