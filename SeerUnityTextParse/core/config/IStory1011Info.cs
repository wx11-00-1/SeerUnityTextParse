using System;

namespace core.config
{
	// Token: 0x02001E5C RID: 7772
	public class IStory1011Info : IConfigItem
	{
		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x0600E6D6 RID: 59094 RVA: 0x003E15C4 File Offset: 0x003DF7C4
		// (set) Token: 0x0600E6D7 RID: 59095 RVA: 0x003E15CC File Offset: 0x003DF7CC
		public string param1 { get; set; }

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x0600E6D8 RID: 59096 RVA: 0x003E15D5 File Offset: 0x003DF7D5
		// (set) Token: 0x0600E6D9 RID: 59097 RVA: 0x003E15DD File Offset: 0x003DF7DD
		public string param2 { get; set; }

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x0600E6DA RID: 59098 RVA: 0x003E15E6 File Offset: 0x003DF7E6
		// (set) Token: 0x0600E6DB RID: 59099 RVA: 0x003E15EE File Offset: 0x003DF7EE
		public string param3 { get; set; }

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x0600E6DC RID: 59100 RVA: 0x003E15F7 File Offset: 0x003DF7F7
		// (set) Token: 0x0600E6DD RID: 59101 RVA: 0x003E15FF File Offset: 0x003DF7FF
		public string param4 { get; set; }

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x0600E6DE RID: 59102 RVA: 0x003E1608 File Offset: 0x003DF808
		// (set) Token: 0x0600E6DF RID: 59103 RVA: 0x003E1610 File Offset: 0x003DF810
		public string param5 { get; set; }

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x0600E6E0 RID: 59104 RVA: 0x003E1619 File Offset: 0x003DF819
		// (set) Token: 0x0600E6E1 RID: 59105 RVA: 0x003E1621 File Offset: 0x003DF821
		public float control { get; set; }

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x0600E6E2 RID: 59106 RVA: 0x003E162A File Offset: 0x003DF82A
		// (set) Token: 0x0600E6E3 RID: 59107 RVA: 0x003E1632 File Offset: 0x003DF832
		public int id { get; set; }

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x0600E6E4 RID: 59108 RVA: 0x003E163B File Offset: 0x003DF83B
		// (set) Token: 0x0600E6E5 RID: 59109 RVA: 0x003E1643 File Offset: 0x003DF843
		public int logic { get; set; }

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x0600E6E6 RID: 59110 RVA: 0x003E164C File Offset: 0x003DF84C
		// (set) Token: 0x0600E6E7 RID: 59111 RVA: 0x003E1654 File Offset: 0x003DF854
		public int next { get; set; }

		// Token: 0x0600E6E8 RID: 59112 RVA: 0x003E1660 File Offset: 0x003DF860
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
