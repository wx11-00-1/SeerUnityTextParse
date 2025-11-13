using System;

namespace core.config
{
	// Token: 0x02001E86 RID: 7814
	public class IVipsonstellationsuitInfo : IConfigItem
	{
		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x0600E89A RID: 59546 RVA: 0x003E3874 File Offset: 0x003E1A74
		// (set) Token: 0x0600E89B RID: 59547 RVA: 0x003E387C File Offset: 0x003E1A7C
		public string TagName { get; set; }

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x0600E89C RID: 59548 RVA: 0x003E3885 File Offset: 0x003E1A85
		// (set) Token: 0x0600E89D RID: 59549 RVA: 0x003E388D File Offset: 0x003E1A8D
		public int id { get; set; }

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x0600E89E RID: 59550 RVA: 0x003E3896 File Offset: 0x003E1A96
		// (set) Token: 0x0600E89F RID: 59551 RVA: 0x003E389E File Offset: 0x003E1A9E
		public int Suitid { get; set; }

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x0600E8A0 RID: 59552 RVA: 0x003E38A7 File Offset: 0x003E1AA7
		// (set) Token: 0x0600E8A1 RID: 59553 RVA: 0x003E38AF File Offset: 0x003E1AAF
		public int TagType { get; set; }

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x0600E8A2 RID: 59554 RVA: 0x003E38B8 File Offset: 0x003E1AB8
		// (set) Token: 0x0600E8A3 RID: 59555 RVA: 0x003E38C0 File Offset: 0x003E1AC0
		public int UserInfoId { get; set; }

		// Token: 0x0600E8A4 RID: 59556 RVA: 0x003E38CC File Offset: 0x003E1ACC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Suitid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TagName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.TagType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UserInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
