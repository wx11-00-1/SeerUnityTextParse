namespace core.config.titanlode
{
	public class IRoot
	{
		public IMapItem[] map { get; set; }

		public IRewards rewards { get; set; }

		public ITitanlodeItem[] titanlode { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				map = new IMapItem[num];
				for (int i = 0; i < num; i++)
				{
					map[i] = new IMapItem();
					map[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				rewards = new IRewards();
				rewards.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				titanlode = new ITitanlodeItem[num2];
				for (int j = 0; j < num2; j++)
				{
					titanlode[j] = new ITitanlodeItem();
					titanlode[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
