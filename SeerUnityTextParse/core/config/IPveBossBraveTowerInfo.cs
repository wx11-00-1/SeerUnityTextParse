using System;

namespace core.config
{
	// Token: 0x02001DD2 RID: 7634
	public class IPveBossBraveTowerInfo : IConfigItem
	{
		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x0600E0DC RID: 57564 RVA: 0x003D9C34 File Offset: 0x003D7E34
		// (set) Token: 0x0600E0DD RID: 57565 RVA: 0x003D9C3C File Offset: 0x003D7E3C
		public string bossgettext { get; set; }

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x0600E0DE RID: 57566 RVA: 0x003D9C45 File Offset: 0x003D7E45
		// (set) Token: 0x0600E0DF RID: 57567 RVA: 0x003D9C4D File Offset: 0x003D7E4D
		public string raidunlocktext { get; set; }

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x0600E0E0 RID: 57568 RVA: 0x003D9C56 File Offset: 0x003D7E56
		// (set) Token: 0x0600E0E1 RID: 57569 RVA: 0x003D9C5E File Offset: 0x003D7E5E
		public int[] bosslist { get; set; }

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x0600E0E2 RID: 57570 RVA: 0x003D9C67 File Offset: 0x003D7E67
		// (set) Token: 0x0600E0E3 RID: 57571 RVA: 0x003D9C6F File Offset: 0x003D7E6F
		public int[] rewardid { get; set; }

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x0600E0E4 RID: 57572 RVA: 0x003D9C78 File Offset: 0x003D7E78
		// (set) Token: 0x0600E0E5 RID: 57573 RVA: 0x003D9C80 File Offset: 0x003D7E80
		public int[] rewardnum { get; set; }

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x0600E0E6 RID: 57574 RVA: 0x003D9C89 File Offset: 0x003D7E89
		// (set) Token: 0x0600E0E7 RID: 57575 RVA: 0x003D9C91 File Offset: 0x003D7E91
		public int bossgetarg { get; set; }

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x0600E0E8 RID: 57576 RVA: 0x003D9C9A File Offset: 0x003D7E9A
		// (set) Token: 0x0600E0E9 RID: 57577 RVA: 0x003D9CA2 File Offset: 0x003D7EA2
		public int id { get; set; }

		// Token: 0x0600E0EA RID: 57578 RVA: 0x003D9CAC File Offset: 0x003D7EAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bossgetarg = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bossgettext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
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
