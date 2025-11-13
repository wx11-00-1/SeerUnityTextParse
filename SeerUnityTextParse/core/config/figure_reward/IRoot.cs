using System;

namespace core.config.figure_reward
{
	// Token: 0x0200203B RID: 8251
	public class IRoot
	{
		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x0600FC01 RID: 64513 RVA: 0x0040165F File Offset: 0x003FF85F
		// (set) Token: 0x0600FC02 RID: 64514 RVA: 0x00401667 File Offset: 0x003FF867
		public ILevelItem[] Level { get; set; }

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x0600FC03 RID: 64515 RVA: 0x00401670 File Offset: 0x003FF870
		// (set) Token: 0x0600FC04 RID: 64516 RVA: 0x00401678 File Offset: 0x003FF878
		public IRewardItem[] Reward { get; set; }

		// Token: 0x0600FC05 RID: 64517 RVA: 0x00401684 File Offset: 0x003FF884
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Level = new ILevelItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Level[i] = new ILevelItem();
					this.Level[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Reward = new IRewardItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.Reward[j] = new IRewardItem();
					this.Reward[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
