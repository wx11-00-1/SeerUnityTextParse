using System;

namespace core.config
{
	// Token: 0x02001E26 RID: 7718
	public class ISkillEffectInfo : IConfigItem
	{
		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x0600E47C RID: 58492 RVA: 0x003DE710 File Offset: 0x003DC910
		// (set) Token: 0x0600E47D RID: 58493 RVA: 0x003DE718 File Offset: 0x003DC918
		public string formattingAdjustment { get; set; }

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x0600E47E RID: 58494 RVA: 0x003DE721 File Offset: 0x003DC921
		// (set) Token: 0x0600E47F RID: 58495 RVA: 0x003DE729 File Offset: 0x003DC929
		public string ifTextItalic { get; set; }

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x0600E480 RID: 58496 RVA: 0x003DE732 File Offset: 0x003DC932
		// (set) Token: 0x0600E481 RID: 58497 RVA: 0x003DE73A File Offset: 0x003DC93A
		public string info { get; set; }

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x0600E482 RID: 58498 RVA: 0x003DE743 File Offset: 0x003DC943
		// (set) Token: 0x0600E483 RID: 58499 RVA: 0x003DE74B File Offset: 0x003DC94B
		public string tagA { get; set; }

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x0600E484 RID: 58500 RVA: 0x003DE754 File Offset: 0x003DC954
		// (set) Token: 0x0600E485 RID: 58501 RVA: 0x003DE75C File Offset: 0x003DC95C
		public string tagB { get; set; }

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x0600E486 RID: 58502 RVA: 0x003DE765 File Offset: 0x003DC965
		// (set) Token: 0x0600E487 RID: 58503 RVA: 0x003DE76D File Offset: 0x003DC96D
		public string tagC { get; set; }

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600E488 RID: 58504 RVA: 0x003DE776 File Offset: 0x003DC976
		// (set) Token: 0x0600E489 RID: 58505 RVA: 0x003DE77E File Offset: 0x003DC97E
		public int argsNum { get; set; }

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x0600E48A RID: 58506 RVA: 0x003DE787 File Offset: 0x003DC987
		// (set) Token: 0x0600E48B RID: 58507 RVA: 0x003DE78F File Offset: 0x003DC98F
		public int Bosseffective { get; set; }

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x0600E48C RID: 58508 RVA: 0x003DE798 File Offset: 0x003DC998
		// (set) Token: 0x0600E48D RID: 58509 RVA: 0x003DE7A0 File Offset: 0x003DC9A0
		public int id { get; set; }

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x0600E48E RID: 58510 RVA: 0x003DE7A9 File Offset: 0x003DC9A9
		// (set) Token: 0x0600E48F RID: 58511 RVA: 0x003DE7B1 File Offset: 0x003DC9B1
		public int isif { get; set; }

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x0600E490 RID: 58512 RVA: 0x003DE7BA File Offset: 0x003DC9BA
		// (set) Token: 0x0600E491 RID: 58513 RVA: 0x003DE7C2 File Offset: 0x003DC9C2
		public int tagAboss { get; set; }

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x0600E492 RID: 58514 RVA: 0x003DE7CB File Offset: 0x003DC9CB
		// (set) Token: 0x0600E493 RID: 58515 RVA: 0x003DE7D3 File Offset: 0x003DC9D3
		public int tagBboss { get; set; }

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x0600E494 RID: 58516 RVA: 0x003DE7DC File Offset: 0x003DC9DC
		// (set) Token: 0x0600E495 RID: 58517 RVA: 0x003DE7E4 File Offset: 0x003DC9E4
		public int tagCboss { get; set; }

		// Token: 0x0600E496 RID: 58518 RVA: 0x003DE7F0 File Offset: 0x003DC9F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bosseffective = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.argsNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.formattingAdjustment = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ifTextItalic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.info = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isif = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tagA = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tagAboss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tagB = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tagBboss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tagC = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tagCboss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
