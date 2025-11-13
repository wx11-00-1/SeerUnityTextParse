using System;

namespace core.config.Attirerecycle
{
	// Token: 0x0200206F RID: 8303
	public class IAttirerecycleItem
	{
		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x0600FD8B RID: 64907 RVA: 0x004033ED File Offset: 0x004015ED
		// (set) Token: 0x0600FD8C RID: 64908 RVA: 0x004033F5 File Offset: 0x004015F5
		public string ItemName { get; set; }

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x0600FD8D RID: 64909 RVA: 0x004033FE File Offset: 0x004015FE
		// (set) Token: 0x0600FD8E RID: 64910 RVA: 0x00403406 File Offset: 0x00401606
		public int ID { get; set; }

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x0600FD8F RID: 64911 RVA: 0x0040340F File Offset: 0x0040160F
		// (set) Token: 0x0600FD90 RID: 64912 RVA: 0x00403417 File Offset: 0x00401617
		public int ItemID { get; set; }

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x0600FD91 RID: 64913 RVA: 0x00403420 File Offset: 0x00401620
		// (set) Token: 0x0600FD92 RID: 64914 RVA: 0x00403428 File Offset: 0x00401628
		public int OutputNum { get; set; }

		// Token: 0x0600FD93 RID: 64915 RVA: 0x00403431 File Offset: 0x00401631
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ItemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ItemName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.OutputNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
