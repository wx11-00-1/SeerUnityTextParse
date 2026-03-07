using System;

namespace core.config
{
	// Token: 0x02001EF7 RID: 7927
	public class IBagTowerEquipSynthesisInfo : IConfigItem
	{
		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x0600EA78 RID: 60024 RVA: 0x0042BF84 File Offset: 0x0042A184
		// (set) Token: 0x0600EA79 RID: 60025 RVA: 0x0042BF8C File Offset: 0x0042A18C
		public string image { get; set; }

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x0600EA7A RID: 60026 RVA: 0x0042BF95 File Offset: 0x0042A195
		// (set) Token: 0x0600EA7B RID: 60027 RVA: 0x0042BF9D File Offset: 0x0042A19D
		public string name { get; set; }

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x0600EA7C RID: 60028 RVA: 0x0042BFA6 File Offset: 0x0042A1A6
		// (set) Token: 0x0600EA7D RID: 60029 RVA: 0x0042BFAE File Offset: 0x0042A1AE
		public int atkgrowth { get; set; }

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x0600EA7E RID: 60030 RVA: 0x0042BFB7 File Offset: 0x0042A1B7
		// (set) Token: 0x0600EA7F RID: 60031 RVA: 0x0042BFBF File Offset: 0x0042A1BF
		public int defaddgrowth { get; set; }

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x0600EA80 RID: 60032 RVA: 0x0042BFC8 File Offset: 0x0042A1C8
		// (set) Token: 0x0600EA81 RID: 60033 RVA: 0x0042BFD0 File Offset: 0x0042A1D0
		public int geteffect { get; set; }

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x0600EA82 RID: 60034 RVA: 0x0042BFD9 File Offset: 0x0042A1D9
		// (set) Token: 0x0600EA83 RID: 60035 RVA: 0x0042BFE1 File Offset: 0x0042A1E1
		public int goldaddgrowth { get; set; }

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x0600EA84 RID: 60036 RVA: 0x0042BFEA File Offset: 0x0042A1EA
		// (set) Token: 0x0600EA85 RID: 60037 RVA: 0x0042BFF2 File Offset: 0x0042A1F2
		public int hpadlimitgrowth { get; set; }

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x0600EA86 RID: 60038 RVA: 0x0042BFFB File Offset: 0x0042A1FB
		// (set) Token: 0x0600EA87 RID: 60039 RVA: 0x0042C003 File Offset: 0x0042A203
		public int hprecovergrowth { get; set; }

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x0600EA88 RID: 60040 RVA: 0x0042C00C File Offset: 0x0042A20C
		// (set) Token: 0x0600EA89 RID: 60041 RVA: 0x0042C014 File Offset: 0x0042A214
		public int id { get; set; }

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x0600EA8A RID: 60042 RVA: 0x0042C01D File Offset: 0x0042A21D
		// (set) Token: 0x0600EA8B RID: 60043 RVA: 0x0042C025 File Offset: 0x0042A225
		public int synthesislv { get; set; }

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x0600EA8C RID: 60044 RVA: 0x0042C02E File Offset: 0x0042A22E
		// (set) Token: 0x0600EA8D RID: 60045 RVA: 0x0042C036 File Offset: 0x0042A236
		public int type { get; set; }

		// Token: 0x0600EA8E RID: 60046 RVA: 0x0042C040 File Offset: 0x0042A240
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.atkgrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.defaddgrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.geteffect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.goldaddgrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hpadlimitgrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hprecovergrowth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.synthesislv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
