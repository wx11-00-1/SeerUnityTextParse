namespace core.config
{
	public class IStartrekRouteInfo : IConfigItem
	{
		public int[] arrive { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				arrive = new int[num];
				for (int i = 0; i < num; i++)
				{
					arrive[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
