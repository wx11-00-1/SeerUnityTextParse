namespace core.config
{
	public class IPvpBanInfo : IConfigItem
	{
		public int[] name { get; set; }

		public int id { get; set; }

		public int quantity { get; set; }

		public int subkey { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				name = new int[num];
				for (int i = 0; i < num; i++)
				{
					name[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			subkey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
