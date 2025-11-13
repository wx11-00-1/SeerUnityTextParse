using System;

namespace core.config
{
	// Token: 0x02001E10 RID: 7696
	public class ISecurityCheckPersonInfo : IConfigItem
	{
		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x0600E364 RID: 58212 RVA: 0x003DD088 File Offset: 0x003DB288
		// (set) Token: 0x0600E365 RID: 58213 RVA: 0x003DD090 File Offset: 0x003DB290
		public string name { get; set; }

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x0600E366 RID: 58214 RVA: 0x003DD099 File Offset: 0x003DB299
		// (set) Token: 0x0600E367 RID: 58215 RVA: 0x003DD0A1 File Offset: 0x003DB2A1
		public string word { get; set; }

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x0600E368 RID: 58216 RVA: 0x003DD0AA File Offset: 0x003DB2AA
		// (set) Token: 0x0600E369 RID: 58217 RVA: 0x003DD0B2 File Offset: 0x003DB2B2
		public int id { get; set; }

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x0600E36A RID: 58218 RVA: 0x003DD0BB File Offset: 0x003DB2BB
		// (set) Token: 0x0600E36B RID: 58219 RVA: 0x003DD0C3 File Offset: 0x003DB2C3
		public int petid { get; set; }

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x0600E36C RID: 58220 RVA: 0x003DD0CC File Offset: 0x003DB2CC
		// (set) Token: 0x0600E36D RID: 58221 RVA: 0x003DD0D4 File Offset: 0x003DB2D4
		public int petnum { get; set; }

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x0600E36E RID: 58222 RVA: 0x003DD0DD File Offset: 0x003DB2DD
		// (set) Token: 0x0600E36F RID: 58223 RVA: 0x003DD0E5 File Offset: 0x003DB2E5
		public int wrongid { get; set; }

		// Token: 0x0600E370 RID: 58224 RVA: 0x003DD0F0 File Offset: 0x003DB2F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.word = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.wrongid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
