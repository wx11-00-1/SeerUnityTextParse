using System;

namespace core.config
{
	// Token: 0x02002245 RID: 8773
	public class IExpTowerInfo : IConfigItem
	{
		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x0601089C RID: 67740 RVA: 0x0048B310 File Offset: 0x00489510
		// (set) Token: 0x0601089D RID: 67741 RVA: 0x0048B318 File Offset: 0x00489518
		public string bosslist { get; set; }

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x0601089E RID: 67742 RVA: 0x0048B321 File Offset: 0x00489521
		// (set) Token: 0x0601089F RID: 67743 RVA: 0x0048B329 File Offset: 0x00489529
		public string raidunlocktext { get; set; }

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x060108A0 RID: 67744 RVA: 0x0048B332 File Offset: 0x00489532
		// (set) Token: 0x060108A1 RID: 67745 RVA: 0x0048B33A File Offset: 0x0048953A
		public string rewardid { get; set; }

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x060108A2 RID: 67746 RVA: 0x0048B343 File Offset: 0x00489543
		// (set) Token: 0x060108A3 RID: 67747 RVA: 0x0048B34B File Offset: 0x0048954B
		public string rewardnum { get; set; }

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x060108A4 RID: 67748 RVA: 0x0048B354 File Offset: 0x00489554
		// (set) Token: 0x060108A5 RID: 67749 RVA: 0x0048B35C File Offset: 0x0048955C
		public string rewardtype { get; set; }

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x060108A6 RID: 67750 RVA: 0x0048B365 File Offset: 0x00489565
		// (set) Token: 0x060108A7 RID: 67751 RVA: 0x0048B36D File Offset: 0x0048956D
		public string sebossid { get; set; }

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x060108A8 RID: 67752 RVA: 0x0048B376 File Offset: 0x00489576
		// (set) Token: 0x060108A9 RID: 67753 RVA: 0x0048B37E File Offset: 0x0048957E
		public int id { get; set; }

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x060108AA RID: 67754 RVA: 0x0048B387 File Offset: 0x00489587
		// (set) Token: 0x060108AB RID: 67755 RVA: 0x0048B38F File Offset: 0x0048958F
		public int raidunlockarg { get; set; }

		// Token: 0x060108AC RID: 67756 RVA: 0x0048B398 File Offset: 0x00489598
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bosslist = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.raidunlockarg = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.raidunlocktext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardnum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sebossid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
