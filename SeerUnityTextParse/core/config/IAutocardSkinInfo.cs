using System;

namespace core.config
{
	// Token: 0x02002143 RID: 8515
	public class IAutocardSkinInfo : IConfigItem
	{
		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x0600FD28 RID: 64808 RVA: 0x0047DB44 File Offset: 0x0047BD44
		// (set) Token: 0x0600FD29 RID: 64809 RVA: 0x0047DB4C File Offset: 0x0047BD4C
		public string name { get; set; }

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x0600FD2A RID: 64810 RVA: 0x0047DB55 File Offset: 0x0047BD55
		// (set) Token: 0x0600FD2B RID: 64811 RVA: 0x0047DB5D File Offset: 0x0047BD5D
		public string skinName { get; set; }

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x0600FD2C RID: 64812 RVA: 0x0047DB66 File Offset: 0x0047BD66
		// (set) Token: 0x0600FD2D RID: 64813 RVA: 0x0047DB6E File Offset: 0x0047BD6E
		public int contentId { get; set; }

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x0600FD2E RID: 64814 RVA: 0x0047DB77 File Offset: 0x0047BD77
		// (set) Token: 0x0600FD2F RID: 64815 RVA: 0x0047DB7F File Offset: 0x0047BD7F
		public int id { get; set; }

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x0600FD30 RID: 64816 RVA: 0x0047DB88 File Offset: 0x0047BD88
		// (set) Token: 0x0600FD31 RID: 64817 RVA: 0x0047DB90 File Offset: 0x0047BD90
		public int series { get; set; }

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x0600FD32 RID: 64818 RVA: 0x0047DB99 File Offset: 0x0047BD99
		// (set) Token: 0x0600FD33 RID: 64819 RVA: 0x0047DBA1 File Offset: 0x0047BDA1
		public int type { get; set; }

		// Token: 0x0600FD34 RID: 64820 RVA: 0x0047DBAC File Offset: 0x0047BDAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.contentId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.series = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skinName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
