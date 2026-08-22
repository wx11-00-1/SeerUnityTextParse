namespace core.config
{
	public class IWishFloatingBottleInfo : IConfigItem
	{
		public int[] wishoutput { get; set; }

		public int[] wishrealid { get; set; }

		public int id { get; set; }

		public int wishtype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				wishoutput = new int[num];
				for (int i = 0; i < num; i++)
				{
					wishoutput[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				wishrealid = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					wishrealid[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			wishtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
