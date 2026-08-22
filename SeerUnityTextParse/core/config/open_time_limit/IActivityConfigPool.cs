namespace core.config.open_time_limit
{
	public class IActivityConfigPool
	{
		public IActivityItem[] Activity { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Activity = new IActivityItem[num];
				for (int i = 0; i < num; i++)
				{
					Activity[i] = new IActivityItem();
					Activity[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
