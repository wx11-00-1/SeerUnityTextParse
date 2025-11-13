using System;

namespace core.config
{
	// Token: 0x02001DDC RID: 7644
	public class IPvpBanExpertInfo : IConfigItem
	{
		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x0600E136 RID: 57654 RVA: 0x003DA490 File Offset: 0x003D8690
		// (set) Token: 0x0600E137 RID: 57655 RVA: 0x003DA498 File Offset: 0x003D8698
		public string name { get; set; }

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x0600E138 RID: 57656 RVA: 0x003DA4A1 File Offset: 0x003D86A1
		// (set) Token: 0x0600E139 RID: 57657 RVA: 0x003DA4A9 File Offset: 0x003D86A9
		public string reward { get; set; }

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0600E13A RID: 57658 RVA: 0x003DA4B2 File Offset: 0x003D86B2
		// (set) Token: 0x0600E13B RID: 57659 RVA: 0x003DA4BA File Offset: 0x003D86BA
		public int id { get; set; }

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600E13C RID: 57660 RVA: 0x003DA4C3 File Offset: 0x003D86C3
		// (set) Token: 0x0600E13D RID: 57661 RVA: 0x003DA4CB File Offset: 0x003D86CB
		public int quantity { get; set; }

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x0600E13E RID: 57662 RVA: 0x003DA4D4 File Offset: 0x003D86D4
		// (set) Token: 0x0600E13F RID: 57663 RVA: 0x003DA4DC File Offset: 0x003D86DC
		public int seasonopen { get; set; }

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x0600E140 RID: 57664 RVA: 0x003DA4E5 File Offset: 0x003D86E5
		// (set) Token: 0x0600E141 RID: 57665 RVA: 0x003DA4ED File Offset: 0x003D86ED
		public int subkey_month { get; set; }

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x0600E142 RID: 57666 RVA: 0x003DA4F6 File Offset: 0x003D86F6
		// (set) Token: 0x0600E143 RID: 57667 RVA: 0x003DA4FE File Offset: 0x003D86FE
		public int subkey_total { get; set; }

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x0600E144 RID: 57668 RVA: 0x003DA507 File Offset: 0x003D8707
		// (set) Token: 0x0600E145 RID: 57669 RVA: 0x003DA50F File Offset: 0x003D870F
		public int type { get; set; }

		// Token: 0x0600E146 RID: 57670 RVA: 0x003DA518 File Offset: 0x003D8718
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.seasonopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subkey_month = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subkey_total = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
