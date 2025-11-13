using System;

namespace core.config
{
	// Token: 0x02001DD6 RID: 7638
	public class IPveBossLearningTrainingInfo : IConfigItem
	{
		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x0600E102 RID: 57602 RVA: 0x003DA008 File Offset: 0x003D8208
		// (set) Token: 0x0600E103 RID: 57603 RVA: 0x003DA010 File Offset: 0x003D8210
		public string raidunlocktext { get; set; }

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x0600E104 RID: 57604 RVA: 0x003DA019 File Offset: 0x003D8219
		// (set) Token: 0x0600E105 RID: 57605 RVA: 0x003DA021 File Offset: 0x003D8221
		public int[] bosslist { get; set; }

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x0600E106 RID: 57606 RVA: 0x003DA02A File Offset: 0x003D822A
		// (set) Token: 0x0600E107 RID: 57607 RVA: 0x003DA032 File Offset: 0x003D8232
		public int[] rewardid { get; set; }

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x0600E108 RID: 57608 RVA: 0x003DA03B File Offset: 0x003D823B
		// (set) Token: 0x0600E109 RID: 57609 RVA: 0x003DA043 File Offset: 0x003D8243
		public int[] rewardnum { get; set; }

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x0600E10A RID: 57610 RVA: 0x003DA04C File Offset: 0x003D824C
		// (set) Token: 0x0600E10B RID: 57611 RVA: 0x003DA054 File Offset: 0x003D8254
		public int id { get; set; }

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x0600E10C RID: 57612 RVA: 0x003DA05D File Offset: 0x003D825D
		// (set) Token: 0x0600E10D RID: 57613 RVA: 0x003DA065 File Offset: 0x003D8265
		public int raidunlockarg { get; set; }

		// Token: 0x0600E10E RID: 57614 RVA: 0x003DA070 File Offset: 0x003D8270
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.bosslist = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.bosslist[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.raidunlockarg = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.raidunlocktext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardid = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.rewardid[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardnum = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.rewardnum[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
