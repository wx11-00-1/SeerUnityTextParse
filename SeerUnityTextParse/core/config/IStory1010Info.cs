using System;

namespace core.config
{
	// Token: 0x02001E5A RID: 7770
	public class IStory1010Info : IConfigItem
	{
		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x0600E6BE RID: 59070 RVA: 0x003E1400 File Offset: 0x003DF600
		// (set) Token: 0x0600E6BF RID: 59071 RVA: 0x003E1408 File Offset: 0x003DF608
		public string param1 { get; set; }

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x0600E6C0 RID: 59072 RVA: 0x003E1411 File Offset: 0x003DF611
		// (set) Token: 0x0600E6C1 RID: 59073 RVA: 0x003E1419 File Offset: 0x003DF619
		public string param2 { get; set; }

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x0600E6C2 RID: 59074 RVA: 0x003E1422 File Offset: 0x003DF622
		// (set) Token: 0x0600E6C3 RID: 59075 RVA: 0x003E142A File Offset: 0x003DF62A
		public string param3 { get; set; }

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x0600E6C4 RID: 59076 RVA: 0x003E1433 File Offset: 0x003DF633
		// (set) Token: 0x0600E6C5 RID: 59077 RVA: 0x003E143B File Offset: 0x003DF63B
		public string param4 { get; set; }

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x0600E6C6 RID: 59078 RVA: 0x003E1444 File Offset: 0x003DF644
		// (set) Token: 0x0600E6C7 RID: 59079 RVA: 0x003E144C File Offset: 0x003DF64C
		public string param5 { get; set; }

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x0600E6C8 RID: 59080 RVA: 0x003E1455 File Offset: 0x003DF655
		// (set) Token: 0x0600E6C9 RID: 59081 RVA: 0x003E145D File Offset: 0x003DF65D
		public float control { get; set; }

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x0600E6CA RID: 59082 RVA: 0x003E1466 File Offset: 0x003DF666
		// (set) Token: 0x0600E6CB RID: 59083 RVA: 0x003E146E File Offset: 0x003DF66E
		public int id { get; set; }

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x0600E6CC RID: 59084 RVA: 0x003E1477 File Offset: 0x003DF677
		// (set) Token: 0x0600E6CD RID: 59085 RVA: 0x003E147F File Offset: 0x003DF67F
		public int logic { get; set; }

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x0600E6CE RID: 59086 RVA: 0x003E1488 File Offset: 0x003DF688
		// (set) Token: 0x0600E6CF RID: 59087 RVA: 0x003E1490 File Offset: 0x003DF690
		public int next { get; set; }

		// Token: 0x0600E6D0 RID: 59088 RVA: 0x003E149C File Offset: 0x003DF69C
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
