using System;

namespace core.config
{
	// Token: 0x02001D08 RID: 7432
	public class IClassicSweepInfoInfo : IConfigItem
	{
		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x0600D8CE RID: 55502 RVA: 0x003CFC0C File Offset: 0x003CDE0C
		// (set) Token: 0x0600D8CF RID: 55503 RVA: 0x003CFC14 File Offset: 0x003CDE14
		public string Arg2 { get; set; }

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x0600D8D0 RID: 55504 RVA: 0x003CFC1D File Offset: 0x003CDE1D
		// (set) Token: 0x0600D8D1 RID: 55505 RVA: 0x003CFC25 File Offset: 0x003CDE25
		public string LevelLock { get; set; }

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x0600D8D2 RID: 55506 RVA: 0x003CFC2E File Offset: 0x003CDE2E
		// (set) Token: 0x0600D8D3 RID: 55507 RVA: 0x003CFC36 File Offset: 0x003CDE36
		public string name { get; set; }

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x0600D8D4 RID: 55508 RVA: 0x003CFC3F File Offset: 0x003CDE3F
		// (set) Token: 0x0600D8D5 RID: 55509 RVA: 0x003CFC47 File Offset: 0x003CDE47
		public int Arg1 { get; set; }

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x0600D8D6 RID: 55510 RVA: 0x003CFC50 File Offset: 0x003CDE50
		// (set) Token: 0x0600D8D7 RID: 55511 RVA: 0x003CFC58 File Offset: 0x003CDE58
		public int dataKey { get; set; }

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x0600D8D8 RID: 55512 RVA: 0x003CFC61 File Offset: 0x003CDE61
		// (set) Token: 0x0600D8D9 RID: 55513 RVA: 0x003CFC69 File Offset: 0x003CDE69
		public int id { get; set; }

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x0600D8DA RID: 55514 RVA: 0x003CFC72 File Offset: 0x003CDE72
		// (set) Token: 0x0600D8DB RID: 55515 RVA: 0x003CFC7A File Offset: 0x003CDE7A
		public int monsterid { get; set; }

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x0600D8DC RID: 55516 RVA: 0x003CFC83 File Offset: 0x003CDE83
		// (set) Token: 0x0600D8DD RID: 55517 RVA: 0x003CFC8B File Offset: 0x003CDE8B
		public int order { get; set; }

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x0600D8DE RID: 55518 RVA: 0x003CFC94 File Offset: 0x003CDE94
		// (set) Token: 0x0600D8DF RID: 55519 RVA: 0x003CFC9C File Offset: 0x003CDE9C
		public int type { get; set; }

		// Token: 0x0600D8E0 RID: 55520 RVA: 0x003CFCA8 File Offset: 0x003CDEA8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Arg1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Arg2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.LevelLock = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.dataKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
