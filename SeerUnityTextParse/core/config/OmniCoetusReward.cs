namespace core.config
{
	public class OmniCoetusReward : XlsConfigBase<OmniCoetusReward, IOmniCoetusRewardInfo>
	{
		public override string fileName
		{
			get
			{
				return "omniCoetus_reward";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IOmniCoetusRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IOmniCoetusRewardInfo();
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
