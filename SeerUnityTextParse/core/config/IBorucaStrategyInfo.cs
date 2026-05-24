using System;

namespace core.config
{
	// Token: 0x02002497 RID: 9367
	public class IBorucaStrategyInfo : IConfigItem
	{
		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06011CD2 RID: 72914 RVA: 0x00505E04 File Offset: 0x00504004
		// (set) Token: 0x06011CD3 RID: 72915 RVA: 0x00505E0C File Offset: 0x0050400C
		public string role { get; set; }

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06011CD4 RID: 72916 RVA: 0x00505E15 File Offset: 0x00504015
		// (set) Token: 0x06011CD5 RID: 72917 RVA: 0x00505E1D File Offset: 0x0050401D
		public string situation { get; set; }

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06011CD6 RID: 72918 RVA: 0x00505E26 File Offset: 0x00504026
		// (set) Token: 0x06011CD7 RID: 72919 RVA: 0x00505E2E File Offset: 0x0050402E
		public string title { get; set; }

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06011CD8 RID: 72920 RVA: 0x00505E37 File Offset: 0x00504037
		// (set) Token: 0x06011CD9 RID: 72921 RVA: 0x00505E3F File Offset: 0x0050403F
		public int id { get; set; }

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06011CDA RID: 72922 RVA: 0x00505E48 File Offset: 0x00504048
		// (set) Token: 0x06011CDB RID: 72923 RVA: 0x00505E50 File Offset: 0x00504050
		public int place { get; set; }

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06011CDC RID: 72924 RVA: 0x00505E59 File Offset: 0x00504059
		// (set) Token: 0x06011CDD RID: 72925 RVA: 0x00505E61 File Offset: 0x00504061
		public int sotryid { get; set; }

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06011CDE RID: 72926 RVA: 0x00505E6A File Offset: 0x0050406A
		// (set) Token: 0x06011CDF RID: 72927 RVA: 0x00505E72 File Offset: 0x00504072
		public int time { get; set; }

		// Token: 0x06011CE0 RID: 72928 RVA: 0x00505E7C File Offset: 0x0050407C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.place = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.role = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.situation = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sotryid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
