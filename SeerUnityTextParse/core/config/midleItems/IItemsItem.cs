using System;

namespace core.config.midleItems
{
	// Token: 0x02001FC6 RID: 8134
	public class IItemsItem
	{
		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x0600F532 RID: 62770 RVA: 0x003FA968 File Offset: 0x003F8B68
		// (set) Token: 0x0600F533 RID: 62771 RVA: 0x003FA970 File Offset: 0x003F8B70
		public string Name { get; set; }

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x0600F534 RID: 62772 RVA: 0x003FA979 File Offset: 0x003F8B79
		// (set) Token: 0x0600F535 RID: 62773 RVA: 0x003FA981 File Offset: 0x003F8B81
		public int catID { get; set; }

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x0600F536 RID: 62774 RVA: 0x003FA98A File Offset: 0x003F8B8A
		// (set) Token: 0x0600F537 RID: 62775 RVA: 0x003FA992 File Offset: 0x003F8B92
		public int ID { get; set; }

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x0600F538 RID: 62776 RVA: 0x003FA99B File Offset: 0x003F8B9B
		// (set) Token: 0x0600F539 RID: 62777 RVA: 0x003FA9A3 File Offset: 0x003F8BA3
		public int Max { get; set; }

		// Token: 0x0600F53A RID: 62778 RVA: 0x003FA9AC File Offset: 0x003F8BAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
