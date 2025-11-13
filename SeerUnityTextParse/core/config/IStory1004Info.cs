using System;

namespace core.config
{
	// Token: 0x02001E4E RID: 7758
	public class IStory1004Info : IConfigItem
	{
		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x0600E62E RID: 58926 RVA: 0x003E0968 File Offset: 0x003DEB68
		// (set) Token: 0x0600E62F RID: 58927 RVA: 0x003E0970 File Offset: 0x003DEB70
		public string param1 { get; set; }

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x0600E630 RID: 58928 RVA: 0x003E0979 File Offset: 0x003DEB79
		// (set) Token: 0x0600E631 RID: 58929 RVA: 0x003E0981 File Offset: 0x003DEB81
		public string param2 { get; set; }

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x0600E632 RID: 58930 RVA: 0x003E098A File Offset: 0x003DEB8A
		// (set) Token: 0x0600E633 RID: 58931 RVA: 0x003E0992 File Offset: 0x003DEB92
		public string param3 { get; set; }

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x0600E634 RID: 58932 RVA: 0x003E099B File Offset: 0x003DEB9B
		// (set) Token: 0x0600E635 RID: 58933 RVA: 0x003E09A3 File Offset: 0x003DEBA3
		public string param4 { get; set; }

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x0600E636 RID: 58934 RVA: 0x003E09AC File Offset: 0x003DEBAC
		// (set) Token: 0x0600E637 RID: 58935 RVA: 0x003E09B4 File Offset: 0x003DEBB4
		public string param5 { get; set; }

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x0600E638 RID: 58936 RVA: 0x003E09BD File Offset: 0x003DEBBD
		// (set) Token: 0x0600E639 RID: 58937 RVA: 0x003E09C5 File Offset: 0x003DEBC5
		public float control { get; set; }

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600E63A RID: 58938 RVA: 0x003E09CE File Offset: 0x003DEBCE
		// (set) Token: 0x0600E63B RID: 58939 RVA: 0x003E09D6 File Offset: 0x003DEBD6
		public int id { get; set; }

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x0600E63C RID: 58940 RVA: 0x003E09DF File Offset: 0x003DEBDF
		// (set) Token: 0x0600E63D RID: 58941 RVA: 0x003E09E7 File Offset: 0x003DEBE7
		public int logic { get; set; }

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x0600E63E RID: 58942 RVA: 0x003E09F0 File Offset: 0x003DEBF0
		// (set) Token: 0x0600E63F RID: 58943 RVA: 0x003E09F8 File Offset: 0x003DEBF8
		public int next { get; set; }

		// Token: 0x0600E640 RID: 58944 RVA: 0x003E0A04 File Offset: 0x003DEC04
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
