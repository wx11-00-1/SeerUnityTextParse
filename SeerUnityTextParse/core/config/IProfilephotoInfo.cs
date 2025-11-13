using System;

namespace core.config
{
	// Token: 0x02001DD0 RID: 7632
	public class IProfilephotoInfo : IConfigItem
	{
		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x0600E0B8 RID: 57528 RVA: 0x003D99BC File Offset: 0x003D7BBC
		// (set) Token: 0x0600E0B9 RID: 57529 RVA: 0x003D99C4 File Offset: 0x003D7BC4
		public string desc { get; set; }

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x0600E0BA RID: 57530 RVA: 0x003D99CD File Offset: 0x003D7BCD
		// (set) Token: 0x0600E0BB RID: 57531 RVA: 0x003D99D5 File Offset: 0x003D7BD5
		public string @goto { get; set; }

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x0600E0BC RID: 57532 RVA: 0x003D99DE File Offset: 0x003D7BDE
		// (set) Token: 0x0600E0BD RID: 57533 RVA: 0x003D99E6 File Offset: 0x003D7BE6
		public string name { get; set; }

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x0600E0BE RID: 57534 RVA: 0x003D99EF File Offset: 0x003D7BEF
		// (set) Token: 0x0600E0BF RID: 57535 RVA: 0x003D99F7 File Offset: 0x003D7BF7
		public string spine { get; set; }

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x0600E0C0 RID: 57536 RVA: 0x003D9A00 File Offset: 0x003D7C00
		// (set) Token: 0x0600E0C1 RID: 57537 RVA: 0x003D9A08 File Offset: 0x003D7C08
		public string text { get; set; }

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x0600E0C2 RID: 57538 RVA: 0x003D9A11 File Offset: 0x003D7C11
		// (set) Token: 0x0600E0C3 RID: 57539 RVA: 0x003D9A19 File Offset: 0x003D7C19
		public int checkown { get; set; }

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x0600E0C4 RID: 57540 RVA: 0x003D9A22 File Offset: 0x003D7C22
		// (set) Token: 0x0600E0C5 RID: 57541 RVA: 0x003D9A2A File Offset: 0x003D7C2A
		public int finishTime { get; set; }

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x0600E0C6 RID: 57542 RVA: 0x003D9A33 File Offset: 0x003D7C33
		// (set) Token: 0x0600E0C7 RID: 57543 RVA: 0x003D9A3B File Offset: 0x003D7C3B
		public int hide { get; set; }

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x0600E0C8 RID: 57544 RVA: 0x003D9A44 File Offset: 0x003D7C44
		// (set) Token: 0x0600E0C9 RID: 57545 RVA: 0x003D9A4C File Offset: 0x003D7C4C
		public int icon { get; set; }

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x0600E0CA RID: 57546 RVA: 0x003D9A55 File Offset: 0x003D7C55
		// (set) Token: 0x0600E0CB RID: 57547 RVA: 0x003D9A5D File Offset: 0x003D7C5D
		public int id { get; set; }

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x0600E0CC RID: 57548 RVA: 0x003D9A66 File Offset: 0x003D7C66
		// (set) Token: 0x0600E0CD RID: 57549 RVA: 0x003D9A6E File Offset: 0x003D7C6E
		public int rarity { get; set; }

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x0600E0CE RID: 57550 RVA: 0x003D9A77 File Offset: 0x003D7C77
		// (set) Token: 0x0600E0CF RID: 57551 RVA: 0x003D9A7F File Offset: 0x003D7C7F
		public int tab { get; set; }

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x0600E0D0 RID: 57552 RVA: 0x003D9A88 File Offset: 0x003D7C88
		// (set) Token: 0x0600E0D1 RID: 57553 RVA: 0x003D9A90 File Offset: 0x003D7C90
		public int type { get; set; }

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x0600E0D2 RID: 57554 RVA: 0x003D9A99 File Offset: 0x003D7C99
		// (set) Token: 0x0600E0D3 RID: 57555 RVA: 0x003D9AA1 File Offset: 0x003D7CA1
		public int unavailable { get; set; }

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x003D9AAA File Offset: 0x003D7CAA
		// (set) Token: 0x0600E0D5 RID: 57557 RVA: 0x003D9AB2 File Offset: 0x003D7CB2
		public int unlocktype { get; set; }

		// Token: 0x0600E0D6 RID: 57558 RVA: 0x003D9ABC File Offset: 0x003D7CBC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.checkown = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.finishTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.@goto = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.spine = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tab = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unavailable = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlocktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
