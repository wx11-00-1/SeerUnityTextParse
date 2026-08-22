namespace core.config
{
	public class ExplorationReward : XlsConfigBase<ExplorationReward, IExplorationRewardInfo>
	{
		public override string fileName
		{
			get
			{
				return "ExplorationReward";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IExplorationRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IExplorationRewardInfo();
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
