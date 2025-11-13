using System;

namespace core.config
{
	// Token: 0x02001CD0 RID: 7376
	public class IBraveTowerReverseDefenseChallengerInfo : IConfigItem
	{
		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x0600D61E RID: 54814 RVA: 0x003CC844 File Offset: 0x003CAA44
		// (set) Token: 0x0600D61F RID: 54815 RVA: 0x003CC84C File Offset: 0x003CAA4C
		public string name { get; set; }

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x0600D620 RID: 54816 RVA: 0x003CC855 File Offset: 0x003CAA55
		// (set) Token: 0x0600D621 RID: 54817 RVA: 0x003CC85D File Offset: 0x003CAA5D
		public int battlevalue1 { get; set; }

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x0600D622 RID: 54818 RVA: 0x003CC866 File Offset: 0x003CAA66
		// (set) Token: 0x0600D623 RID: 54819 RVA: 0x003CC86E File Offset: 0x003CAA6E
		public int battlevalue2 { get; set; }

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x0600D624 RID: 54820 RVA: 0x003CC877 File Offset: 0x003CAA77
		// (set) Token: 0x0600D625 RID: 54821 RVA: 0x003CC87F File Offset: 0x003CAA7F
		public int battlevalue3 { get; set; }

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x0600D626 RID: 54822 RVA: 0x003CC888 File Offset: 0x003CAA88
		// (set) Token: 0x0600D627 RID: 54823 RVA: 0x003CC890 File Offset: 0x003CAA90
		public int id { get; set; }

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x0600D628 RID: 54824 RVA: 0x003CC899 File Offset: 0x003CAA99
		// (set) Token: 0x0600D629 RID: 54825 RVA: 0x003CC8A1 File Offset: 0x003CAAA1
		public int monsterid1 { get; set; }

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x0600D62A RID: 54826 RVA: 0x003CC8AA File Offset: 0x003CAAAA
		// (set) Token: 0x0600D62B RID: 54827 RVA: 0x003CC8B2 File Offset: 0x003CAAB2
		public int monsterid2 { get; set; }

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x0600D62C RID: 54828 RVA: 0x003CC8BB File Offset: 0x003CAABB
		// (set) Token: 0x0600D62D RID: 54829 RVA: 0x003CC8C3 File Offset: 0x003CAAC3
		public int monsterid3 { get; set; }

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x0600D62E RID: 54830 RVA: 0x003CC8CC File Offset: 0x003CAACC
		// (set) Token: 0x0600D62F RID: 54831 RVA: 0x003CC8D4 File Offset: 0x003CAAD4
		public int suitid { get; set; }

		// Token: 0x0600D630 RID: 54832 RVA: 0x003CC8E0 File Offset: 0x003CAAE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.battlevalue1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.battlevalue2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.battlevalue3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterid1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterid2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterid3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.suitid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
