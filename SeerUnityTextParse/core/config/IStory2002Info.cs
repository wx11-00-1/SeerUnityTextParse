using System;

namespace core.config
{
	// Token: 0x02001E62 RID: 7778
	public class IStory2002Info : IConfigItem
	{
		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x0600E71E RID: 59166 RVA: 0x003E1B10 File Offset: 0x003DFD10
		// (set) Token: 0x0600E71F RID: 59167 RVA: 0x003E1B18 File Offset: 0x003DFD18
		public string param1 { get; set; }

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x0600E720 RID: 59168 RVA: 0x003E1B21 File Offset: 0x003DFD21
		// (set) Token: 0x0600E721 RID: 59169 RVA: 0x003E1B29 File Offset: 0x003DFD29
		public string param2 { get; set; }

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x0600E722 RID: 59170 RVA: 0x003E1B32 File Offset: 0x003DFD32
		// (set) Token: 0x0600E723 RID: 59171 RVA: 0x003E1B3A File Offset: 0x003DFD3A
		public string param3 { get; set; }

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x0600E724 RID: 59172 RVA: 0x003E1B43 File Offset: 0x003DFD43
		// (set) Token: 0x0600E725 RID: 59173 RVA: 0x003E1B4B File Offset: 0x003DFD4B
		public string param4 { get; set; }

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x0600E726 RID: 59174 RVA: 0x003E1B54 File Offset: 0x003DFD54
		// (set) Token: 0x0600E727 RID: 59175 RVA: 0x003E1B5C File Offset: 0x003DFD5C
		public string param5 { get; set; }

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x0600E728 RID: 59176 RVA: 0x003E1B65 File Offset: 0x003DFD65
		// (set) Token: 0x0600E729 RID: 59177 RVA: 0x003E1B6D File Offset: 0x003DFD6D
		public float control { get; set; }

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x0600E72A RID: 59178 RVA: 0x003E1B76 File Offset: 0x003DFD76
		// (set) Token: 0x0600E72B RID: 59179 RVA: 0x003E1B7E File Offset: 0x003DFD7E
		public int id { get; set; }

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x0600E72C RID: 59180 RVA: 0x003E1B87 File Offset: 0x003DFD87
		// (set) Token: 0x0600E72D RID: 59181 RVA: 0x003E1B8F File Offset: 0x003DFD8F
		public int logic { get; set; }

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x0600E72E RID: 59182 RVA: 0x003E1B98 File Offset: 0x003DFD98
		// (set) Token: 0x0600E72F RID: 59183 RVA: 0x003E1BA0 File Offset: 0x003DFDA0
		public int next { get; set; }

		// Token: 0x0600E730 RID: 59184 RVA: 0x003E1BAC File Offset: 0x003DFDAC
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
