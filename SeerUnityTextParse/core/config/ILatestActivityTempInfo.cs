using System;

namespace core.config
{
	// Token: 0x02002285 RID: 8837
	public class ILatestActivityTempInfo : IConfigItem
	{
		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06010B44 RID: 68420 RVA: 0x0048E9F4 File Offset: 0x0048CBF4
		// (set) Token: 0x06010B45 RID: 68421 RVA: 0x0048E9FC File Offset: 0x0048CBFC
		public string @goto { get; set; }

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06010B46 RID: 68422 RVA: 0x0048EA05 File Offset: 0x0048CC05
		// (set) Token: 0x06010B47 RID: 68423 RVA: 0x0048EA0D File Offset: 0x0048CC0D
		public string showEnd { get; set; }

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06010B48 RID: 68424 RVA: 0x0048EA16 File Offset: 0x0048CC16
		// (set) Token: 0x06010B49 RID: 68425 RVA: 0x0048EA1E File Offset: 0x0048CC1E
		public string showStart { get; set; }

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x06010B4A RID: 68426 RVA: 0x0048EA27 File Offset: 0x0048CC27
		// (set) Token: 0x06010B4B RID: 68427 RVA: 0x0048EA2F File Offset: 0x0048CC2F
		public int id { get; set; }

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06010B4C RID: 68428 RVA: 0x0048EA38 File Offset: 0x0048CC38
		// (set) Token: 0x06010B4D RID: 68429 RVA: 0x0048EA40 File Offset: 0x0048CC40
		public int page { get; set; }

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06010B4E RID: 68430 RVA: 0x0048EA49 File Offset: 0x0048CC49
		// (set) Token: 0x06010B4F RID: 68431 RVA: 0x0048EA51 File Offset: 0x0048CC51
		public int pic { get; set; }

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06010B50 RID: 68432 RVA: 0x0048EA5A File Offset: 0x0048CC5A
		// (set) Token: 0x06010B51 RID: 68433 RVA: 0x0048EA62 File Offset: 0x0048CC62
		public int tag { get; set; }

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06010B52 RID: 68434 RVA: 0x0048EA6B File Offset: 0x0048CC6B
		// (set) Token: 0x06010B53 RID: 68435 RVA: 0x0048EA73 File Offset: 0x0048CC73
		public int type { get; set; }

		// Token: 0x06010B54 RID: 68436 RVA: 0x0048EA7C File Offset: 0x0048CC7C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.@goto = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.page = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showEnd = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showStart = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
