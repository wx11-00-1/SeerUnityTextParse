using System;

namespace core.config
{
	// Token: 0x02001E68 RID: 7784
	public class IStory2005Info : IConfigItem
	{
		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x0600E766 RID: 59238 RVA: 0x003E205C File Offset: 0x003E025C
		// (set) Token: 0x0600E767 RID: 59239 RVA: 0x003E2064 File Offset: 0x003E0264
		public string param1 { get; set; }

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x0600E768 RID: 59240 RVA: 0x003E206D File Offset: 0x003E026D
		// (set) Token: 0x0600E769 RID: 59241 RVA: 0x003E2075 File Offset: 0x003E0275
		public string param2 { get; set; }

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x0600E76A RID: 59242 RVA: 0x003E207E File Offset: 0x003E027E
		// (set) Token: 0x0600E76B RID: 59243 RVA: 0x003E2086 File Offset: 0x003E0286
		public string param3 { get; set; }

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x0600E76C RID: 59244 RVA: 0x003E208F File Offset: 0x003E028F
		// (set) Token: 0x0600E76D RID: 59245 RVA: 0x003E2097 File Offset: 0x003E0297
		public string param4 { get; set; }

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x0600E76E RID: 59246 RVA: 0x003E20A0 File Offset: 0x003E02A0
		// (set) Token: 0x0600E76F RID: 59247 RVA: 0x003E20A8 File Offset: 0x003E02A8
		public string param5 { get; set; }

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x0600E770 RID: 59248 RVA: 0x003E20B1 File Offset: 0x003E02B1
		// (set) Token: 0x0600E771 RID: 59249 RVA: 0x003E20B9 File Offset: 0x003E02B9
		public float control { get; set; }

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x0600E772 RID: 59250 RVA: 0x003E20C2 File Offset: 0x003E02C2
		// (set) Token: 0x0600E773 RID: 59251 RVA: 0x003E20CA File Offset: 0x003E02CA
		public int id { get; set; }

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x0600E774 RID: 59252 RVA: 0x003E20D3 File Offset: 0x003E02D3
		// (set) Token: 0x0600E775 RID: 59253 RVA: 0x003E20DB File Offset: 0x003E02DB
		public int logic { get; set; }

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x0600E776 RID: 59254 RVA: 0x003E20E4 File Offset: 0x003E02E4
		// (set) Token: 0x0600E777 RID: 59255 RVA: 0x003E20EC File Offset: 0x003E02EC
		public int next { get; set; }

		// Token: 0x0600E778 RID: 59256 RVA: 0x003E20F8 File Offset: 0x003E02F8
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
