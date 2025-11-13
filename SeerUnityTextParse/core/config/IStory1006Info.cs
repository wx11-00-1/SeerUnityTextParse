using System;

namespace core.config
{
	// Token: 0x02001E52 RID: 7762
	public class IStory1006Info : IConfigItem
	{
		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x0600E65E RID: 58974 RVA: 0x003E0CF0 File Offset: 0x003DEEF0
		// (set) Token: 0x0600E65F RID: 58975 RVA: 0x003E0CF8 File Offset: 0x003DEEF8
		public string param1 { get; set; }

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x0600E660 RID: 58976 RVA: 0x003E0D01 File Offset: 0x003DEF01
		// (set) Token: 0x0600E661 RID: 58977 RVA: 0x003E0D09 File Offset: 0x003DEF09
		public string param2 { get; set; }

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x0600E662 RID: 58978 RVA: 0x003E0D12 File Offset: 0x003DEF12
		// (set) Token: 0x0600E663 RID: 58979 RVA: 0x003E0D1A File Offset: 0x003DEF1A
		public string param3 { get; set; }

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x0600E664 RID: 58980 RVA: 0x003E0D23 File Offset: 0x003DEF23
		// (set) Token: 0x0600E665 RID: 58981 RVA: 0x003E0D2B File Offset: 0x003DEF2B
		public string param4 { get; set; }

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x0600E666 RID: 58982 RVA: 0x003E0D34 File Offset: 0x003DEF34
		// (set) Token: 0x0600E667 RID: 58983 RVA: 0x003E0D3C File Offset: 0x003DEF3C
		public string param5 { get; set; }

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x0600E668 RID: 58984 RVA: 0x003E0D45 File Offset: 0x003DEF45
		// (set) Token: 0x0600E669 RID: 58985 RVA: 0x003E0D4D File Offset: 0x003DEF4D
		public float control { get; set; }

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x0600E66A RID: 58986 RVA: 0x003E0D56 File Offset: 0x003DEF56
		// (set) Token: 0x0600E66B RID: 58987 RVA: 0x003E0D5E File Offset: 0x003DEF5E
		public int id { get; set; }

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x0600E66C RID: 58988 RVA: 0x003E0D67 File Offset: 0x003DEF67
		// (set) Token: 0x0600E66D RID: 58989 RVA: 0x003E0D6F File Offset: 0x003DEF6F
		public int logic { get; set; }

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x0600E66E RID: 58990 RVA: 0x003E0D78 File Offset: 0x003DEF78
		// (set) Token: 0x0600E66F RID: 58991 RVA: 0x003E0D80 File Offset: 0x003DEF80
		public int next { get; set; }

		// Token: 0x0600E670 RID: 58992 RVA: 0x003E0D8C File Offset: 0x003DEF8C
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
