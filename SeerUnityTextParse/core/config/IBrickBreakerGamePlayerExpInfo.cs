namespace core.config
{
	public class IBrickBreakerGamePlayerExpInfo : IConfigItem
	{
		public int exp { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
