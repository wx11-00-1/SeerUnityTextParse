using System;

namespace core.config
{
	// Token: 0x02002117 RID: 8471
	public class IAdAstraShopInfo : IConfigItem
	{
		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x0600FB52 RID: 64338 RVA: 0x0047B8AC File Offset: 0x00479AAC
		// (set) Token: 0x0600FB53 RID: 64339 RVA: 0x0047B8B4 File Offset: 0x00479AB4
		public string content { get; set; }

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x0600FB54 RID: 64340 RVA: 0x0047B8BD File Offset: 0x00479ABD
		// (set) Token: 0x0600FB55 RID: 64341 RVA: 0x0047B8C5 File Offset: 0x00479AC5
		public string desc { get; set; }

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600FB56 RID: 64342 RVA: 0x0047B8CE File Offset: 0x00479ACE
		// (set) Token: 0x0600FB57 RID: 64343 RVA: 0x0047B8D6 File Offset: 0x00479AD6
		public int costID { get; set; }

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x0600FB58 RID: 64344 RVA: 0x0047B8DF File Offset: 0x00479ADF
		// (set) Token: 0x0600FB59 RID: 64345 RVA: 0x0047B8E7 File Offset: 0x00479AE7
		public int costNum { get; set; }

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x0600FB5A RID: 64346 RVA: 0x0047B8F0 File Offset: 0x00479AF0
		// (set) Token: 0x0600FB5B RID: 64347 RVA: 0x0047B8F8 File Offset: 0x00479AF8
		public int id { get; set; }

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x0600FB5C RID: 64348 RVA: 0x0047B901 File Offset: 0x00479B01
		// (set) Token: 0x0600FB5D RID: 64349 RVA: 0x0047B909 File Offset: 0x00479B09
		public int limitNum { get; set; }

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x0600FB5E RID: 64350 RVA: 0x0047B912 File Offset: 0x00479B12
		// (set) Token: 0x0600FB5F RID: 64351 RVA: 0x0047B91A File Offset: 0x00479B1A
		public int limitType { get; set; }

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x0600FB60 RID: 64352 RVA: 0x0047B923 File Offset: 0x00479B23
		// (set) Token: 0x0600FB61 RID: 64353 RVA: 0x0047B92B File Offset: 0x00479B2B
		public int type { get; set; }

		// Token: 0x0600FB62 RID: 64354 RVA: 0x0047B934 File Offset: 0x00479B34
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.content = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.costID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.costNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limitNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limitType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
