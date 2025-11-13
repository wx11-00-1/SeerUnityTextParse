using System;

namespace core.config
{
	// Token: 0x02001E5E RID: 7774
	public class IStory1012Info : IConfigItem
	{
		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x0600E6EE RID: 59118 RVA: 0x003E1788 File Offset: 0x003DF988
		// (set) Token: 0x0600E6EF RID: 59119 RVA: 0x003E1790 File Offset: 0x003DF990
		public string param1 { get; set; }

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x0600E6F0 RID: 59120 RVA: 0x003E1799 File Offset: 0x003DF999
		// (set) Token: 0x0600E6F1 RID: 59121 RVA: 0x003E17A1 File Offset: 0x003DF9A1
		public string param2 { get; set; }

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x0600E6F2 RID: 59122 RVA: 0x003E17AA File Offset: 0x003DF9AA
		// (set) Token: 0x0600E6F3 RID: 59123 RVA: 0x003E17B2 File Offset: 0x003DF9B2
		public string param3 { get; set; }

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x0600E6F4 RID: 59124 RVA: 0x003E17BB File Offset: 0x003DF9BB
		// (set) Token: 0x0600E6F5 RID: 59125 RVA: 0x003E17C3 File Offset: 0x003DF9C3
		public string param4 { get; set; }

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x0600E6F6 RID: 59126 RVA: 0x003E17CC File Offset: 0x003DF9CC
		// (set) Token: 0x0600E6F7 RID: 59127 RVA: 0x003E17D4 File Offset: 0x003DF9D4
		public string param5 { get; set; }

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x0600E6F8 RID: 59128 RVA: 0x003E17DD File Offset: 0x003DF9DD
		// (set) Token: 0x0600E6F9 RID: 59129 RVA: 0x003E17E5 File Offset: 0x003DF9E5
		public float control { get; set; }

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x0600E6FA RID: 59130 RVA: 0x003E17EE File Offset: 0x003DF9EE
		// (set) Token: 0x0600E6FB RID: 59131 RVA: 0x003E17F6 File Offset: 0x003DF9F6
		public int id { get; set; }

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x0600E6FC RID: 59132 RVA: 0x003E17FF File Offset: 0x003DF9FF
		// (set) Token: 0x0600E6FD RID: 59133 RVA: 0x003E1807 File Offset: 0x003DFA07
		public int logic { get; set; }

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x0600E6FE RID: 59134 RVA: 0x003E1810 File Offset: 0x003DFA10
		// (set) Token: 0x0600E6FF RID: 59135 RVA: 0x003E1818 File Offset: 0x003DFA18
		public int next { get; set; }

		// Token: 0x0600E700 RID: 59136 RVA: 0x003E1824 File Offset: 0x003DFA24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
