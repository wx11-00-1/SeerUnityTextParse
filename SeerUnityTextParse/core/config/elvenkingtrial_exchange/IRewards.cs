namespace core.config.elvenkingtrial_exchange
{
	public class IRewards
	{
		public IRewardItem[] reward { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new IRewardItem[num];
				for (int i = 0; i < num; i++)
				{
					reward[i] = new IRewardItem();
					reward[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
