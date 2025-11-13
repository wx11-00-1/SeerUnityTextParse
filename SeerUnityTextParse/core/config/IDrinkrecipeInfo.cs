using System;

namespace core.config
{
	// Token: 0x02001D38 RID: 7480
	public class IDrinkrecipeInfo : IConfigItem
	{
		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x0600DA86 RID: 55942 RVA: 0x003D1D70 File Offset: 0x003CFF70
		// (set) Token: 0x0600DA87 RID: 55943 RVA: 0x003D1D78 File Offset: 0x003CFF78
		public string introduce { get; set; }

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x0600DA88 RID: 55944 RVA: 0x003D1D81 File Offset: 0x003CFF81
		// (set) Token: 0x0600DA89 RID: 55945 RVA: 0x003D1D89 File Offset: 0x003CFF89
		public string name { get; set; }

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x0600DA8A RID: 55946 RVA: 0x003D1D92 File Offset: 0x003CFF92
		// (set) Token: 0x0600DA8B RID: 55947 RVA: 0x003D1D9A File Offset: 0x003CFF9A
		public string tag { get; set; }

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x0600DA8C RID: 55948 RVA: 0x003D1DA3 File Offset: 0x003CFFA3
		// (set) Token: 0x0600DA8D RID: 55949 RVA: 0x003D1DAB File Offset: 0x003CFFAB
		public int id { get; set; }

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x0600DA8E RID: 55950 RVA: 0x003D1DB4 File Offset: 0x003CFFB4
		// (set) Token: 0x0600DA8F RID: 55951 RVA: 0x003D1DBC File Offset: 0x003CFFBC
		public int recipe1 { get; set; }

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x0600DA90 RID: 55952 RVA: 0x003D1DC5 File Offset: 0x003CFFC5
		// (set) Token: 0x0600DA91 RID: 55953 RVA: 0x003D1DCD File Offset: 0x003CFFCD
		public int recipe2 { get; set; }

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x0600DA92 RID: 55954 RVA: 0x003D1DD6 File Offset: 0x003CFFD6
		// (set) Token: 0x0600DA93 RID: 55955 RVA: 0x003D1DDE File Offset: 0x003CFFDE
		public int recipe3 { get; set; }

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x0600DA94 RID: 55956 RVA: 0x003D1DE7 File Offset: 0x003CFFE7
		// (set) Token: 0x0600DA95 RID: 55957 RVA: 0x003D1DEF File Offset: 0x003CFFEF
		public int time { get; set; }

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x0600DA96 RID: 55958 RVA: 0x003D1DF8 File Offset: 0x003CFFF8
		// (set) Token: 0x0600DA97 RID: 55959 RVA: 0x003D1E00 File Offset: 0x003D0000
		public int type { get; set; }

		// Token: 0x0600DA98 RID: 55960 RVA: 0x003D1E0C File Offset: 0x003D000C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.introduce = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.recipe1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.recipe2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.recipe3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
