using System;

namespace core.config
{
	// Token: 0x02001D36 RID: 7478
	public class IDrinkcheckpointInfo : IConfigItem
	{
		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x0600DA74 RID: 55924 RVA: 0x003D1C0C File Offset: 0x003CFE0C
		// (set) Token: 0x0600DA75 RID: 55925 RVA: 0x003D1C14 File Offset: 0x003CFE14
		public string checkpoint { get; set; }

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x0600DA76 RID: 55926 RVA: 0x003D1C1D File Offset: 0x003CFE1D
		// (set) Token: 0x0600DA77 RID: 55927 RVA: 0x003D1C25 File Offset: 0x003CFE25
		public string gift { get; set; }

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x0600DA78 RID: 55928 RVA: 0x003D1C2E File Offset: 0x003CFE2E
		// (set) Token: 0x0600DA79 RID: 55929 RVA: 0x003D1C36 File Offset: 0x003CFE36
		public string introduce { get; set; }

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x0600DA7A RID: 55930 RVA: 0x003D1C3F File Offset: 0x003CFE3F
		// (set) Token: 0x0600DA7B RID: 55931 RVA: 0x003D1C47 File Offset: 0x003CFE47
		public string name { get; set; }

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x0600DA7C RID: 55932 RVA: 0x003D1C50 File Offset: 0x003CFE50
		// (set) Token: 0x0600DA7D RID: 55933 RVA: 0x003D1C58 File Offset: 0x003CFE58
		public int id { get; set; }

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x0600DA7E RID: 55934 RVA: 0x003D1C61 File Offset: 0x003CFE61
		// (set) Token: 0x0600DA7F RID: 55935 RVA: 0x003D1C69 File Offset: 0x003CFE69
		public int type { get; set; }

		// Token: 0x0600DA80 RID: 55936 RVA: 0x003D1C74 File Offset: 0x003CFE74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.checkpoint = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.gift = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.introduce = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
