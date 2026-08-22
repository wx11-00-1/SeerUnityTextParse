namespace core.config
{
	public class PvpReward : XlsConfigBase<PvpReward, IPvpRewardInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvp_reward";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpRewardInfo();
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
