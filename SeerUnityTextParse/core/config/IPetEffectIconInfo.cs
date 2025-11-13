using System;

namespace core.config
{
	// Token: 0x02001DBE RID: 7614
	public class IPetEffectIconInfo : IConfigItem
	{
		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x0600E012 RID: 57362 RVA: 0x003D8D70 File Offset: 0x003D6F70
		// (set) Token: 0x0600E013 RID: 57363 RVA: 0x003D8D78 File Offset: 0x003D6F78
		public string Desc { get; set; }

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x0600E014 RID: 57364 RVA: 0x003D8D81 File Offset: 0x003D6F81
		// (set) Token: 0x0600E015 RID: 57365 RVA: 0x003D8D89 File Offset: 0x003D6F89
		public int affectedBoss { get; set; }

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x0600E016 RID: 57366 RVA: 0x003D8D92 File Offset: 0x003D6F92
		// (set) Token: 0x0600E017 RID: 57367 RVA: 0x003D8D9A File Offset: 0x003D6F9A
		public int effecticonid { get; set; }

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x0600E018 RID: 57368 RVA: 0x003D8DA3 File Offset: 0x003D6FA3
		// (set) Token: 0x0600E019 RID: 57369 RVA: 0x003D8DAB File Offset: 0x003D6FAB
		public int id { get; set; }

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x0600E01A RID: 57370 RVA: 0x003D8DB4 File Offset: 0x003D6FB4
		// (set) Token: 0x0600E01B RID: 57371 RVA: 0x003D8DBC File Offset: 0x003D6FBC
		public int isAdv { get; set; }

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x0600E01C RID: 57372 RVA: 0x003D8DC5 File Offset: 0x003D6FC5
		// (set) Token: 0x0600E01D RID: 57373 RVA: 0x003D8DCD File Offset: 0x003D6FCD
		public int petid { get; set; }

		// Token: 0x0600E01E RID: 57374 RVA: 0x003D8DD8 File Offset: 0x003D6FD8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.affectedBoss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.effecticonid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isAdv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
