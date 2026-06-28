using System;

namespace core.config
{
	// Token: 0x0200258B RID: 9611
	public class IAutocardSeasonEffectInfo : IConfigItem
	{
		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06012A71 RID: 76401 RVA: 0x005477FC File Offset: 0x005459FC
		// (set) Token: 0x06012A72 RID: 76402 RVA: 0x00547804 File Offset: 0x00545A04
		public string BuffDisplay { get; set; }

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06012A73 RID: 76403 RVA: 0x0054780D File Offset: 0x00545A0D
		// (set) Token: 0x06012A74 RID: 76404 RVA: 0x00547815 File Offset: 0x00545A15
		public string BuffId { get; set; }

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06012A75 RID: 76405 RVA: 0x0054781E File Offset: 0x00545A1E
		// (set) Token: 0x06012A76 RID: 76406 RVA: 0x00547826 File Offset: 0x00545A26
		public string BuffParam { get; set; }

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06012A77 RID: 76407 RVA: 0x0054782F File Offset: 0x00545A2F
		// (set) Token: 0x06012A78 RID: 76408 RVA: 0x00547837 File Offset: 0x00545A37
		public string effectName { get; set; }

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06012A79 RID: 76409 RVA: 0x00547840 File Offset: 0x00545A40
		// (set) Token: 0x06012A7A RID: 76410 RVA: 0x00547848 File Offset: 0x00545A48
		public string effectTxt { get; set; }

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06012A7B RID: 76411 RVA: 0x00547851 File Offset: 0x00545A51
		// (set) Token: 0x06012A7C RID: 76412 RVA: 0x00547859 File Offset: 0x00545A59
		public int CountNum { get; set; }

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06012A7D RID: 76413 RVA: 0x00547862 File Offset: 0x00545A62
		// (set) Token: 0x06012A7E RID: 76414 RVA: 0x0054786A File Offset: 0x00545A6A
		public int DefaultNum { get; set; }

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06012A7F RID: 76415 RVA: 0x00547873 File Offset: 0x00545A73
		// (set) Token: 0x06012A80 RID: 76416 RVA: 0x0054787B File Offset: 0x00545A7B
		public int effectGroup { get; set; }

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06012A81 RID: 76417 RVA: 0x00547884 File Offset: 0x00545A84
		// (set) Token: 0x06012A82 RID: 76418 RVA: 0x0054788C File Offset: 0x00545A8C
		public int id { get; set; }

		// Token: 0x17001841 RID: 6209
		// (get) Token: 0x06012A83 RID: 76419 RVA: 0x00547895 File Offset: 0x00545A95
		// (set) Token: 0x06012A84 RID: 76420 RVA: 0x0054789D File Offset: 0x00545A9D
		public int opTurn { get; set; }

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x06012A85 RID: 76421 RVA: 0x005478A6 File Offset: 0x00545AA6
		// (set) Token: 0x06012A86 RID: 76422 RVA: 0x005478AE File Offset: 0x00545AAE
		public int picID { get; set; }

		// Token: 0x17001843 RID: 6211
		// (get) Token: 0x06012A87 RID: 76423 RVA: 0x005478B7 File Offset: 0x00545AB7
		// (set) Token: 0x06012A88 RID: 76424 RVA: 0x005478BF File Offset: 0x00545ABF
		public int season { get; set; }

		// Token: 0x17001844 RID: 6212
		// (get) Token: 0x06012A89 RID: 76425 RVA: 0x005478C8 File Offset: 0x00545AC8
		// (set) Token: 0x06012A8A RID: 76426 RVA: 0x005478D0 File Offset: 0x00545AD0
		public int stageLevel { get; set; }

		// Token: 0x06012A8B RID: 76427 RVA: 0x005478DC File Offset: 0x00545ADC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BuffDisplay = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.BuffId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.BuffParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.CountNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.DefaultNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.effectGroup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.effectName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.effectTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.opTurn = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.picID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.season = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stageLevel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
