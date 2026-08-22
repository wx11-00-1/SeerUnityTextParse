namespace core.config
{
	public class PassReward : XlsConfigBase<PassReward, IPassRewardInfo>
	{
		public override string fileName
		{
			get
			{
				return "pass_reward";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPassRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPassRewardInfo();
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
