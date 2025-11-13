using System;

namespace core.config
{
	// Token: 0x02001D04 RID: 7428
	public class IChessGameStageInfo : IConfigItem
	{
		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x0600D89C RID: 55452 RVA: 0x003CF868 File Offset: 0x003CDA68
		// (set) Token: 0x0600D89D RID: 55453 RVA: 0x003CF870 File Offset: 0x003CDA70
		public string group1 { get; set; }

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x0600D89E RID: 55454 RVA: 0x003CF879 File Offset: 0x003CDA79
		// (set) Token: 0x0600D89F RID: 55455 RVA: 0x003CF881 File Offset: 0x003CDA81
		public string group2 { get; set; }

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x0600D8A0 RID: 55456 RVA: 0x003CF88A File Offset: 0x003CDA8A
		// (set) Token: 0x0600D8A1 RID: 55457 RVA: 0x003CF892 File Offset: 0x003CDA92
		public string group3 { get; set; }

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x0600D8A2 RID: 55458 RVA: 0x003CF89B File Offset: 0x003CDA9B
		// (set) Token: 0x0600D8A3 RID: 55459 RVA: 0x003CF8A3 File Offset: 0x003CDAA3
		public string rewardrange1 { get; set; }

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x0600D8A4 RID: 55460 RVA: 0x003CF8AC File Offset: 0x003CDAAC
		// (set) Token: 0x0600D8A5 RID: 55461 RVA: 0x003CF8B4 File Offset: 0x003CDAB4
		public string scope { get; set; }

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x0600D8A6 RID: 55462 RVA: 0x003CF8BD File Offset: 0x003CDABD
		// (set) Token: 0x0600D8A7 RID: 55463 RVA: 0x003CF8C5 File Offset: 0x003CDAC5
		public int cardnum { get; set; }

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x0600D8A8 RID: 55464 RVA: 0x003CF8CE File Offset: 0x003CDACE
		// (set) Token: 0x0600D8A9 RID: 55465 RVA: 0x003CF8D6 File Offset: 0x003CDAD6
		public int chapter { get; set; }

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x0600D8AA RID: 55466 RVA: 0x003CF8DF File Offset: 0x003CDADF
		// (set) Token: 0x0600D8AB RID: 55467 RVA: 0x003CF8E7 File Offset: 0x003CDAE7
		public int equipnum { get; set; }

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x0600D8AC RID: 55468 RVA: 0x003CF8F0 File Offset: 0x003CDAF0
		// (set) Token: 0x0600D8AD RID: 55469 RVA: 0x003CF8F8 File Offset: 0x003CDAF8
		public int id { get; set; }

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x0600D8AE RID: 55470 RVA: 0x003CF901 File Offset: 0x003CDB01
		// (set) Token: 0x0600D8AF RID: 55471 RVA: 0x003CF909 File Offset: 0x003CDB09
		public int rewardrange2 { get; set; }

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x0600D8B0 RID: 55472 RVA: 0x003CF912 File Offset: 0x003CDB12
		// (set) Token: 0x0600D8B1 RID: 55473 RVA: 0x003CF91A File Offset: 0x003CDB1A
		public int stagetype { get; set; }

		// Token: 0x0600D8B2 RID: 55474 RVA: 0x003CF924 File Offset: 0x003CDB24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.cardnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.chapter = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.equipnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.group1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.group2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.group3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardrange1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardrange2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.scope = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stagetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
