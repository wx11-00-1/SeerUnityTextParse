using System;

namespace core.config
{
	// Token: 0x02001D7B RID: 7547
	public class LimitedAdastraActivityReward : XlsConfigBase<LimitedAdastraActivityReward, ILimitedAdastraActivityRewardInfo>
	{
		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x0600DD2E RID: 56622 RVA: 0x003D537F File Offset: 0x003D357F
		public override string fileName
		{
			get
			{
				return "LimitedAdastraActivityReward";
			}
		}

		// Token: 0x0600DD2F RID: 56623 RVA: 0x003D5388 File Offset: 0x003D3588
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILimitedAdastraActivityRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILimitedAdastraActivityRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DD30 RID: 56624 RVA: 0x003D53DC File Offset: 0x003D35DC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
