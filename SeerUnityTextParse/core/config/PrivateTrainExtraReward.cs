using System;

namespace core.config
{
	// Token: 0x02001DCB RID: 7627
	public class PrivateTrainExtraReward : XlsConfigBase<PrivateTrainExtraReward, IPrivateTrainExtraRewardInfo>
	{
		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x0600E096 RID: 57494 RVA: 0x003D9704 File Offset: 0x003D7904
		public override string fileName
		{
			get
			{
				return "privateTrainExtraReward";
			}
		}

		// Token: 0x0600E097 RID: 57495 RVA: 0x003D970C File Offset: 0x003D790C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPrivateTrainExtraRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPrivateTrainExtraRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E098 RID: 57496 RVA: 0x003D9760 File Offset: 0x003D7960
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
