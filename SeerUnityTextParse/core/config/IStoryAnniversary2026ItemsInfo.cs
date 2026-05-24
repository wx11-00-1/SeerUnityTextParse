using System;

namespace core.config
{
	// Token: 0x020026BF RID: 9919
	public class IStoryAnniversary2026ItemsInfo : IConfigItem
	{
		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x06013502 RID: 79106 RVA: 0x0052374C File Offset: 0x0052194C
		// (set) Token: 0x06013503 RID: 79107 RVA: 0x00523754 File Offset: 0x00521954
		public string desc { get; set; }

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x06013504 RID: 79108 RVA: 0x0052375D File Offset: 0x0052195D
		// (set) Token: 0x06013505 RID: 79109 RVA: 0x00523765 File Offset: 0x00521965
		public string image { get; set; }

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x06013506 RID: 79110 RVA: 0x0052376E File Offset: 0x0052196E
		// (set) Token: 0x06013507 RID: 79111 RVA: 0x00523776 File Offset: 0x00521976
		public string name { get; set; }

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x06013508 RID: 79112 RVA: 0x0052377F File Offset: 0x0052197F
		// (set) Token: 0x06013509 RID: 79113 RVA: 0x00523787 File Offset: 0x00521987
		public int donate { get; set; }

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x0601350A RID: 79114 RVA: 0x00523790 File Offset: 0x00521990
		// (set) Token: 0x0601350B RID: 79115 RVA: 0x00523798 File Offset: 0x00521998
		public int id { get; set; }

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x0601350C RID: 79116 RVA: 0x005237A1 File Offset: 0x005219A1
		// (set) Token: 0x0601350D RID: 79117 RVA: 0x005237A9 File Offset: 0x005219A9
		public int sort { get; set; }

		// Token: 0x0601350E RID: 79118 RVA: 0x005237B4 File Offset: 0x005219B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.donate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
