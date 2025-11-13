using System;

namespace core.config
{
	// Token: 0x02001E80 RID: 7808
	public class ITitanMineRewardInfo : IConfigItem
	{
		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x0600E86C RID: 59500 RVA: 0x003E34C8 File Offset: 0x003E16C8
		// (set) Token: 0x0600E86D RID: 59501 RVA: 0x003E34D0 File Offset: 0x003E16D0
		public string rewardinfo { get; set; }

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x0600E86E RID: 59502 RVA: 0x003E34D9 File Offset: 0x003E16D9
		// (set) Token: 0x0600E86F RID: 59503 RVA: 0x003E34E1 File Offset: 0x003E16E1
		public string text1 { get; set; }

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x0600E870 RID: 59504 RVA: 0x003E34EA File Offset: 0x003E16EA
		// (set) Token: 0x0600E871 RID: 59505 RVA: 0x003E34F2 File Offset: 0x003E16F2
		public string text2 { get; set; }

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x0600E872 RID: 59506 RVA: 0x003E34FB File Offset: 0x003E16FB
		// (set) Token: 0x0600E873 RID: 59507 RVA: 0x003E3503 File Offset: 0x003E1703
		public string text3 { get; set; }

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600E874 RID: 59508 RVA: 0x003E350C File Offset: 0x003E170C
		// (set) Token: 0x0600E875 RID: 59509 RVA: 0x003E3514 File Offset: 0x003E1714
		public string text4 { get; set; }

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x0600E876 RID: 59510 RVA: 0x003E351D File Offset: 0x003E171D
		// (set) Token: 0x0600E877 RID: 59511 RVA: 0x003E3525 File Offset: 0x003E1725
		public int id { get; set; }

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x0600E878 RID: 59512 RVA: 0x003E352E File Offset: 0x003E172E
		// (set) Token: 0x0600E879 RID: 59513 RVA: 0x003E3536 File Offset: 0x003E1736
		public int type { get; set; }

		// Token: 0x0600E87A RID: 59514 RVA: 0x003E3540 File Offset: 0x003E1740
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.text1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.text2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.text3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.text4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
