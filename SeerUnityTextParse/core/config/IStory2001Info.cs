using System;

namespace core.config
{
	// Token: 0x02001E60 RID: 7776
	public class IStory2001Info : IConfigItem
	{
		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x0600E706 RID: 59142 RVA: 0x003E194C File Offset: 0x003DFB4C
		// (set) Token: 0x0600E707 RID: 59143 RVA: 0x003E1954 File Offset: 0x003DFB54
		public string param1 { get; set; }

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x0600E708 RID: 59144 RVA: 0x003E195D File Offset: 0x003DFB5D
		// (set) Token: 0x0600E709 RID: 59145 RVA: 0x003E1965 File Offset: 0x003DFB65
		public string param2 { get; set; }

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x0600E70A RID: 59146 RVA: 0x003E196E File Offset: 0x003DFB6E
		// (set) Token: 0x0600E70B RID: 59147 RVA: 0x003E1976 File Offset: 0x003DFB76
		public string param3 { get; set; }

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600E70C RID: 59148 RVA: 0x003E197F File Offset: 0x003DFB7F
		// (set) Token: 0x0600E70D RID: 59149 RVA: 0x003E1987 File Offset: 0x003DFB87
		public string param4 { get; set; }

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x0600E70E RID: 59150 RVA: 0x003E1990 File Offset: 0x003DFB90
		// (set) Token: 0x0600E70F RID: 59151 RVA: 0x003E1998 File Offset: 0x003DFB98
		public string param5 { get; set; }

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x0600E710 RID: 59152 RVA: 0x003E19A1 File Offset: 0x003DFBA1
		// (set) Token: 0x0600E711 RID: 59153 RVA: 0x003E19A9 File Offset: 0x003DFBA9
		public float control { get; set; }

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x0600E712 RID: 59154 RVA: 0x003E19B2 File Offset: 0x003DFBB2
		// (set) Token: 0x0600E713 RID: 59155 RVA: 0x003E19BA File Offset: 0x003DFBBA
		public int id { get; set; }

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x0600E714 RID: 59156 RVA: 0x003E19C3 File Offset: 0x003DFBC3
		// (set) Token: 0x0600E715 RID: 59157 RVA: 0x003E19CB File Offset: 0x003DFBCB
		public int logic { get; set; }

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x0600E716 RID: 59158 RVA: 0x003E19D4 File Offset: 0x003DFBD4
		// (set) Token: 0x0600E717 RID: 59159 RVA: 0x003E19DC File Offset: 0x003DFBDC
		public int next { get; set; }

		// Token: 0x0600E718 RID: 59160 RVA: 0x003E19E8 File Offset: 0x003DFBE8
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
