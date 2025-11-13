using System;

namespace core.config
{
	// Token: 0x02001E72 RID: 7794
	public class ISuitsaleInfo : IConfigItem
	{
		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x0600E7DE RID: 59358 RVA: 0x003E2930 File Offset: 0x003E0B30
		// (set) Token: 0x0600E7DF RID: 59359 RVA: 0x003E2938 File Offset: 0x003E0B38
		public int id { get; set; }

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x0600E7E0 RID: 59360 RVA: 0x003E2941 File Offset: 0x003E0B41
		// (set) Token: 0x0600E7E1 RID: 59361 RVA: 0x003E2949 File Offset: 0x003E0B49
		public int itemid { get; set; }

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x0600E7E2 RID: 59362 RVA: 0x003E2952 File Offset: 0x003E0B52
		// (set) Token: 0x0600E7E3 RID: 59363 RVA: 0x003E295A File Offset: 0x003E0B5A
		public int normalprice { get; set; }

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x0600E7E4 RID: 59364 RVA: 0x003E2963 File Offset: 0x003E0B63
		// (set) Token: 0x0600E7E5 RID: 59365 RVA: 0x003E296B File Offset: 0x003E0B6B
		public int specialprice { get; set; }

		// Token: 0x0600E7E6 RID: 59366 RVA: 0x003E2974 File Offset: 0x003E0B74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.normalprice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.specialprice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
