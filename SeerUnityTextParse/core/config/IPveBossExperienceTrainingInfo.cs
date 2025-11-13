using System;

namespace core.config
{
	// Token: 0x02001DD4 RID: 7636
	public class IPveBossExperienceTrainingInfo : IConfigItem
	{
		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x0600E0F0 RID: 57584 RVA: 0x003D9E30 File Offset: 0x003D8030
		// (set) Token: 0x0600E0F1 RID: 57585 RVA: 0x003D9E38 File Offset: 0x003D8038
		public string raidunlocktext { get; set; }

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x0600E0F2 RID: 57586 RVA: 0x003D9E41 File Offset: 0x003D8041
		// (set) Token: 0x0600E0F3 RID: 57587 RVA: 0x003D9E49 File Offset: 0x003D8049
		public int[] bosslist { get; set; }

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x0600E0F4 RID: 57588 RVA: 0x003D9E52 File Offset: 0x003D8052
		// (set) Token: 0x0600E0F5 RID: 57589 RVA: 0x003D9E5A File Offset: 0x003D805A
		public int[] rewardid { get; set; }

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x0600E0F6 RID: 57590 RVA: 0x003D9E63 File Offset: 0x003D8063
		// (set) Token: 0x0600E0F7 RID: 57591 RVA: 0x003D9E6B File Offset: 0x003D806B
		public int[] rewardnum { get; set; }

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x0600E0F8 RID: 57592 RVA: 0x003D9E74 File Offset: 0x003D8074
		// (set) Token: 0x0600E0F9 RID: 57593 RVA: 0x003D9E7C File Offset: 0x003D807C
		public int id { get; set; }

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x0600E0FA RID: 57594 RVA: 0x003D9E85 File Offset: 0x003D8085
		// (set) Token: 0x0600E0FB RID: 57595 RVA: 0x003D9E8D File Offset: 0x003D808D
		public int raidunlockarg { get; set; }

		// Token: 0x0600E0FC RID: 57596 RVA: 0x003D9E98 File Offset: 0x003D8098
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
