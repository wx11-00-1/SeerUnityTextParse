using System;

namespace core.config
{
	// Token: 0x02001E64 RID: 7780
	public class IStory2003Info : IConfigItem
	{
		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x0600E736 RID: 59190 RVA: 0x003E1CD4 File Offset: 0x003DFED4
		// (set) Token: 0x0600E737 RID: 59191 RVA: 0x003E1CDC File Offset: 0x003DFEDC
		public string param1 { get; set; }

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x0600E738 RID: 59192 RVA: 0x003E1CE5 File Offset: 0x003DFEE5
		// (set) Token: 0x0600E739 RID: 59193 RVA: 0x003E1CED File Offset: 0x003DFEED
		public string param2 { get; set; }

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x0600E73A RID: 59194 RVA: 0x003E1CF6 File Offset: 0x003DFEF6
		// (set) Token: 0x0600E73B RID: 59195 RVA: 0x003E1CFE File Offset: 0x003DFEFE
		public string param3 { get; set; }

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x0600E73C RID: 59196 RVA: 0x003E1D07 File Offset: 0x003DFF07
		// (set) Token: 0x0600E73D RID: 59197 RVA: 0x003E1D0F File Offset: 0x003DFF0F
		public string param4 { get; set; }

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x0600E73E RID: 59198 RVA: 0x003E1D18 File Offset: 0x003DFF18
		// (set) Token: 0x0600E73F RID: 59199 RVA: 0x003E1D20 File Offset: 0x003DFF20
		public string param5 { get; set; }

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x0600E740 RID: 59200 RVA: 0x003E1D29 File Offset: 0x003DFF29
		// (set) Token: 0x0600E741 RID: 59201 RVA: 0x003E1D31 File Offset: 0x003DFF31
		public float control { get; set; }

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x0600E742 RID: 59202 RVA: 0x003E1D3A File Offset: 0x003DFF3A
		// (set) Token: 0x0600E743 RID: 59203 RVA: 0x003E1D42 File Offset: 0x003DFF42
		public int id { get; set; }

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x0600E744 RID: 59204 RVA: 0x003E1D4B File Offset: 0x003DFF4B
		// (set) Token: 0x0600E745 RID: 59205 RVA: 0x003E1D53 File Offset: 0x003DFF53
		public int logic { get; set; }

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x0600E746 RID: 59206 RVA: 0x003E1D5C File Offset: 0x003DFF5C
		// (set) Token: 0x0600E747 RID: 59207 RVA: 0x003E1D64 File Offset: 0x003DFF64
		public int next { get; set; }

		// Token: 0x0600E748 RID: 59208 RVA: 0x003E1D70 File Offset: 0x003DFF70
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
