using System;

namespace core.config
{
	// Token: 0x02002909 RID: 10505
	public class IPvpCostModeCostInfo : IConfigItem
	{
		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x06015217 RID: 86551 RVA: 0x005A371C File Offset: 0x005A191C
		// (set) Token: 0x06015218 RID: 86552 RVA: 0x005A3724 File Offset: 0x005A1924
		public string name { get; set; }

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x06015219 RID: 86553 RVA: 0x005A372D File Offset: 0x005A192D
		// (set) Token: 0x0601521A RID: 86554 RVA: 0x005A3735 File Offset: 0x005A1935
		public string pet { get; set; }

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x0601521B RID: 86555 RVA: 0x005A373E File Offset: 0x005A193E
		// (set) Token: 0x0601521C RID: 86556 RVA: 0x005A3746 File Offset: 0x005A1946
		public string subkey { get; set; }

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x0601521D RID: 86557 RVA: 0x005A374F File Offset: 0x005A194F
		// (set) Token: 0x0601521E RID: 86558 RVA: 0x005A3757 File Offset: 0x005A1957
		public int cost { get; set; }

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x0601521F RID: 86559 RVA: 0x005A3760 File Offset: 0x005A1960
		// (set) Token: 0x06015220 RID: 86560 RVA: 0x005A3768 File Offset: 0x005A1968
		public int id { get; set; }

		// Token: 0x06015221 RID: 86561 RVA: 0x005A3774 File Offset: 0x005A1974
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.subkey = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
