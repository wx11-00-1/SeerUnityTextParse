using System;

namespace core.config
{
	// Token: 0x02001DC5 RID: 7621
	public class PrivateCostDiamondReward : XlsConfigBase<PrivateCostDiamondReward, IPrivateCostDiamondRewardInfo>
	{
		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x0600E058 RID: 57432 RVA: 0x003D924D File Offset: 0x003D744D
		public override string fileName
		{
			get
			{
				return "privateCostDiamondReward";
			}
		}

		// Token: 0x0600E059 RID: 57433 RVA: 0x003D9254 File Offset: 0x003D7454
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPrivateCostDiamondRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPrivateCostDiamondRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E05A RID: 57434 RVA: 0x003D92A8 File Offset: 0x003D74A8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
