namespace core.config
{
	public class IReturnTaskInfo : IConfigItem
	{
		public int[] reward { get; set; }

		public int id { get; set; }

		public int times { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num];
				for (int i = 0; i < num; i++)
				{
					reward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			times = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
