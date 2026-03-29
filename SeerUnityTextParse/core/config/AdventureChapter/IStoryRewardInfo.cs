using System;

namespace core.config.AdventureChapter
{
	// Token: 0x0200263A RID: 9786
	public class IStoryRewardInfo
	{
		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x06013409 RID: 78857 RVA: 0x004C7BE8 File Offset: 0x004C5DE8
		// (set) Token: 0x0601340A RID: 78858 RVA: 0x004C7BF0 File Offset: 0x004C5DF0
		public IPassStoryRewardItem[] PassStoryReward { get; set; }

		// Token: 0x0601340B RID: 78859 RVA: 0x004C7BFC File Offset: 0x004C5DFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.PassStoryReward = new IPassStoryRewardItem[num];
				for (int i = 0; i < num; i++)
				{
					this.PassStoryReward[i] = new IPassStoryRewardItem();
					this.PassStoryReward[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
