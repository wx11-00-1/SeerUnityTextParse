using System;

namespace core.config.itemsOptimizeCatItems9
{
	// Token: 0x02001FE5 RID: 8165
	public class IItemsItem
	{
		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x0600F605 RID: 62981 RVA: 0x003FB89C File Offset: 0x003F9A9C
		// (set) Token: 0x0600F606 RID: 62982 RVA: 0x003FB8A4 File Offset: 0x003F9AA4
		public string Name { get; set; }

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x0600F607 RID: 62983 RVA: 0x003FB8AD File Offset: 0x003F9AAD
		// (set) Token: 0x0600F608 RID: 62984 RVA: 0x003FB8B5 File Offset: 0x003F9AB5
		public int catID { get; set; }

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x0600F609 RID: 62985 RVA: 0x003FB8BE File Offset: 0x003F9ABE
		// (set) Token: 0x0600F60A RID: 62986 RVA: 0x003FB8C6 File Offset: 0x003F9AC6
		public int ID { get; set; }

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x0600F60B RID: 62987 RVA: 0x003FB8CF File Offset: 0x003F9ACF
		// (set) Token: 0x0600F60C RID: 62988 RVA: 0x003FB8D7 File Offset: 0x003F9AD7
		public int Max { get; set; }

		// Token: 0x0600F60D RID: 62989 RVA: 0x003FB8E0 File Offset: 0x003F9AE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
