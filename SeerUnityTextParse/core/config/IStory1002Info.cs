using System;

namespace core.config
{
	// Token: 0x02001E4A RID: 7754
	public class IStory1002Info : IConfigItem
	{
		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x0600E5FE RID: 58878 RVA: 0x003E05E0 File Offset: 0x003DE7E0
		// (set) Token: 0x0600E5FF RID: 58879 RVA: 0x003E05E8 File Offset: 0x003DE7E8
		public string param1 { get; set; }

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x0600E600 RID: 58880 RVA: 0x003E05F1 File Offset: 0x003DE7F1
		// (set) Token: 0x0600E601 RID: 58881 RVA: 0x003E05F9 File Offset: 0x003DE7F9
		public string param2 { get; set; }

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x0600E602 RID: 58882 RVA: 0x003E0602 File Offset: 0x003DE802
		// (set) Token: 0x0600E603 RID: 58883 RVA: 0x003E060A File Offset: 0x003DE80A
		public string param3 { get; set; }

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x0600E604 RID: 58884 RVA: 0x003E0613 File Offset: 0x003DE813
		// (set) Token: 0x0600E605 RID: 58885 RVA: 0x003E061B File Offset: 0x003DE81B
		public string param4 { get; set; }

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x0600E606 RID: 58886 RVA: 0x003E0624 File Offset: 0x003DE824
		// (set) Token: 0x0600E607 RID: 58887 RVA: 0x003E062C File Offset: 0x003DE82C
		public string param5 { get; set; }

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x0600E608 RID: 58888 RVA: 0x003E0635 File Offset: 0x003DE835
		// (set) Token: 0x0600E609 RID: 58889 RVA: 0x003E063D File Offset: 0x003DE83D
		public float control { get; set; }

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x0600E60A RID: 58890 RVA: 0x003E0646 File Offset: 0x003DE846
		// (set) Token: 0x0600E60B RID: 58891 RVA: 0x003E064E File Offset: 0x003DE84E
		public int id { get; set; }

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x0600E60C RID: 58892 RVA: 0x003E0657 File Offset: 0x003DE857
		// (set) Token: 0x0600E60D RID: 58893 RVA: 0x003E065F File Offset: 0x003DE85F
		public int logic { get; set; }

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x0600E60E RID: 58894 RVA: 0x003E0668 File Offset: 0x003DE868
		// (set) Token: 0x0600E60F RID: 58895 RVA: 0x003E0670 File Offset: 0x003DE870
		public int next { get; set; }

		// Token: 0x0600E610 RID: 58896 RVA: 0x003E067C File Offset: 0x003DE87C
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
