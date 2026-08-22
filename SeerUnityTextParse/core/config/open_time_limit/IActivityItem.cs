namespace core.config.open_time_limit
{
	public class IActivityItem
	{
		public ITimeLimitItem[] TimeLimit { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				TimeLimit = new ITimeLimitItem[num];
				for (int i = 0; i < num; i++)
				{
					TimeLimit[i] = new ITimeLimitItem();
					TimeLimit[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
