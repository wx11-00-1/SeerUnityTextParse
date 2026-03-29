using System;

namespace core.config
{
	// Token: 0x02002387 RID: 9095
	public class IStarmapTempInfo : IConfigItem
	{
		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06011682 RID: 71298 RVA: 0x0049C9F4 File Offset: 0x0049ABF4
		// (set) Token: 0x06011683 RID: 71299 RVA: 0x0049C9FC File Offset: 0x0049ABFC
		public string fun { get; set; }

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06011684 RID: 71300 RVA: 0x0049CA05 File Offset: 0x0049AC05
		// (set) Token: 0x06011685 RID: 71301 RVA: 0x0049CA0D File Offset: 0x0049AC0D
		public string intro { get; set; }

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06011686 RID: 71302 RVA: 0x0049CA16 File Offset: 0x0049AC16
		// (set) Token: 0x06011687 RID: 71303 RVA: 0x0049CA1E File Offset: 0x0049AC1E
		public string name { get; set; }

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06011688 RID: 71304 RVA: 0x0049CA27 File Offset: 0x0049AC27
		// (set) Token: 0x06011689 RID: 71305 RVA: 0x0049CA2F File Offset: 0x0049AC2F
		public string pic { get; set; }

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x0601168A RID: 71306 RVA: 0x0049CA38 File Offset: 0x0049AC38
		// (set) Token: 0x0601168B RID: 71307 RVA: 0x0049CA40 File Offset: 0x0049AC40
		public string StarContrl { get; set; }

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x0601168C RID: 71308 RVA: 0x0049CA49 File Offset: 0x0049AC49
		// (set) Token: 0x0601168D RID: 71309 RVA: 0x0049CA51 File Offset: 0x0049AC51
		public string submap { get; set; }

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x0601168E RID: 71310 RVA: 0x0049CA5A File Offset: 0x0049AC5A
		// (set) Token: 0x0601168F RID: 71311 RVA: 0x0049CA62 File Offset: 0x0049AC62
		public string TipContrl { get; set; }

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06011690 RID: 71312 RVA: 0x0049CA6B File Offset: 0x0049AC6B
		// (set) Token: 0x06011691 RID: 71313 RVA: 0x0049CA73 File Offset: 0x0049AC73
		public string TipType { get; set; }

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06011692 RID: 71314 RVA: 0x0049CA7C File Offset: 0x0049AC7C
		// (set) Token: 0x06011693 RID: 71315 RVA: 0x0049CA84 File Offset: 0x0049AC84
		public int anima { get; set; }

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06011694 RID: 71316 RVA: 0x0049CA8D File Offset: 0x0049AC8D
		// (set) Token: 0x06011695 RID: 71317 RVA: 0x0049CA95 File Offset: 0x0049AC95
		public int Gotomap { get; set; }

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06011696 RID: 71318 RVA: 0x0049CA9E File Offset: 0x0049AC9E
		// (set) Token: 0x06011697 RID: 71319 RVA: 0x0049CAA6 File Offset: 0x0049ACA6
		public int id { get; set; }

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06011698 RID: 71320 RVA: 0x0049CAAF File Offset: 0x0049ACAF
		// (set) Token: 0x06011699 RID: 71321 RVA: 0x0049CAB7 File Offset: 0x0049ACB7
		public int isopen { get; set; }

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x0601169A RID: 71322 RVA: 0x0049CAC0 File Offset: 0x0049ACC0
		// (set) Token: 0x0601169B RID: 71323 RVA: 0x0049CAC8 File Offset: 0x0049ACC8
		public int StarShow { get; set; }

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x0601169C RID: 71324 RVA: 0x0049CAD1 File Offset: 0x0049ACD1
		// (set) Token: 0x0601169D RID: 71325 RVA: 0x0049CAD9 File Offset: 0x0049ACD9
		public int TipShow { get; set; }

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x0601169E RID: 71326 RVA: 0x0049CAE2 File Offset: 0x0049ACE2
		// (set) Token: 0x0601169F RID: 71327 RVA: 0x0049CAEA File Offset: 0x0049ACEA
		public int type { get; set; }

		// Token: 0x060116A0 RID: 71328 RVA: 0x0049CAF4 File Offset: 0x0049ACF4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Gotomap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.StarContrl = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.StarShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TipContrl = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.TipShow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TipType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.anima = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.fun = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.submap = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
