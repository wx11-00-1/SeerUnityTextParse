using System;

namespace core.config.TeamTaskMonsters
{
	// Token: 0x0200248B RID: 9355
	public class ITypeItem
	{
		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x0601217A RID: 74106 RVA: 0x004B20BC File Offset: 0x004B02BC
		// (set) Token: 0x0601217B RID: 74107 RVA: 0x004B20C4 File Offset: 0x004B02C4
		public string MonstersID { get; set; }

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x0601217C RID: 74108 RVA: 0x004B20CD File Offset: 0x004B02CD
		// (set) Token: 0x0601217D RID: 74109 RVA: 0x004B20D5 File Offset: 0x004B02D5
		public string Time { get; set; }

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x0601217E RID: 74110 RVA: 0x004B20DE File Offset: 0x004B02DE
		// (set) Token: 0x0601217F RID: 74111 RVA: 0x004B20E6 File Offset: 0x004B02E6
		public int BonusID { get; set; }

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x06012180 RID: 74112 RVA: 0x004B20EF File Offset: 0x004B02EF
		// (set) Token: 0x06012181 RID: 74113 RVA: 0x004B20F7 File Offset: 0x004B02F7
		public int ID { get; set; }

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x06012182 RID: 74114 RVA: 0x004B2100 File Offset: 0x004B0300
		// (set) Token: 0x06012183 RID: 74115 RVA: 0x004B2108 File Offset: 0x004B0308
		public int NeedLv { get; set; }

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06012184 RID: 74116 RVA: 0x004B2111 File Offset: 0x004B0311
		// (set) Token: 0x06012185 RID: 74117 RVA: 0x004B2119 File Offset: 0x004B0319
		public int NeedMonstersNum { get; set; }

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06012186 RID: 74118 RVA: 0x004B2122 File Offset: 0x004B0322
		// (set) Token: 0x06012187 RID: 74119 RVA: 0x004B212A File Offset: 0x004B032A
		public int Rate { get; set; }

		// Token: 0x06012188 RID: 74120 RVA: 0x004B2134 File Offset: 0x004B0334
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BonusID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonstersID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.NeedLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NeedMonstersNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Time = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
