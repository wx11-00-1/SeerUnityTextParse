namespace core.config
{
	public class LimitedAdastraActivityReward : XlsConfigBase<LimitedAdastraActivityReward, ILimitedAdastraActivityRewardInfo>
	{
		public override string fileName
		{
			get
			{
				return "LimitedAdastraActivityReward";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ILimitedAdastraActivityRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ILimitedAdastraActivityRewardInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
