using System;

namespace core.config
{
	// Token: 0x02001DBC RID: 7612
	public class IPeakAssemblySaleInfo : IConfigItem
	{
		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x0600DFF4 RID: 57332 RVA: 0x003D8B78 File Offset: 0x003D6D78
		// (set) Token: 0x0600DFF5 RID: 57333 RVA: 0x003D8B80 File Offset: 0x003D6D80
		public int ExtraMovesID { get; set; }

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x0600DFF6 RID: 57334 RVA: 0x003D8B89 File Offset: 0x003D6D89
		// (set) Token: 0x0600DFF7 RID: 57335 RVA: 0x003D8B91 File Offset: 0x003D6D91
		public int id { get; set; }

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x0600DFF8 RID: 57336 RVA: 0x003D8B9A File Offset: 0x003D6D9A
		// (set) Token: 0x0600DFF9 RID: 57337 RVA: 0x003D8BA2 File Offset: 0x003D6DA2
		public int IsSell { get; set; }

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x0600DFFA RID: 57338 RVA: 0x003D8BAB File Offset: 0x003D6DAB
		// (set) Token: 0x0600DFFB RID: 57339 RVA: 0x003D8BB3 File Offset: 0x003D6DB3
		public int MintmarkID { get; set; }

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x0600DFFC RID: 57340 RVA: 0x003D8BBC File Offset: 0x003D6DBC
		// (set) Token: 0x0600DFFD RID: 57341 RVA: 0x003D8BC4 File Offset: 0x003D6DC4
		public int MonsterID { get; set; }

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x0600DFFE RID: 57342 RVA: 0x003D8BCD File Offset: 0x003D6DCD
		// (set) Token: 0x0600DFFF RID: 57343 RVA: 0x003D8BD5 File Offset: 0x003D6DD5
		public int Month { get; set; }

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x0600E000 RID: 57344 RVA: 0x003D8BDE File Offset: 0x003D6DDE
		// (set) Token: 0x0600E001 RID: 57345 RVA: 0x003D8BE6 File Offset: 0x003D6DE6
		public int NewSeID { get; set; }

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x0600E002 RID: 57346 RVA: 0x003D8BEF File Offset: 0x003D6DEF
		// (set) Token: 0x0600E003 RID: 57347 RVA: 0x003D8BF7 File Offset: 0x003D6DF7
		public int NewStatLog1 { get; set; }

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x0600E004 RID: 57348 RVA: 0x003D8C00 File Offset: 0x003D6E00
		// (set) Token: 0x0600E005 RID: 57349 RVA: 0x003D8C08 File Offset: 0x003D6E08
		public int NewStatLog2 { get; set; }

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x0600E006 RID: 57350 RVA: 0x003D8C11 File Offset: 0x003D6E11
		// (set) Token: 0x0600E007 RID: 57351 RVA: 0x003D8C19 File Offset: 0x003D6E19
		public int NewStatLog3 { get; set; }

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x0600E008 RID: 57352 RVA: 0x003D8C22 File Offset: 0x003D6E22
		// (set) Token: 0x0600E009 RID: 57353 RVA: 0x003D8C2A File Offset: 0x003D6E2A
		public int SkinID { get; set; }

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x0600E00A RID: 57354 RVA: 0x003D8C33 File Offset: 0x003D6E33
		// (set) Token: 0x0600E00B RID: 57355 RVA: 0x003D8C3B File Offset: 0x003D6E3B
		public int Year { get; set; }

		// Token: 0x0600E00C RID: 57356 RVA: 0x003D8C44 File Offset: 0x003D6E44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExtraMovesID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.IsSell = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Month = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewSeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewStatLog1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewStatLog2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewStatLog3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Year = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
