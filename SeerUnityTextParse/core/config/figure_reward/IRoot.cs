namespace core.config.figure_reward
{
	public class IRoot
	{
		public ILevelItem[] Level { get; set; }

		public IRewardItem[] Reward { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Level = new ILevelItem[num];
				for (int i = 0; i < num; i++)
				{
					Level[i] = new ILevelItem();
					Level[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Reward = new IRewardItem[num2];
				for (int j = 0; j < num2; j++)
				{
					Reward[j] = new IRewardItem();
					Reward[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
