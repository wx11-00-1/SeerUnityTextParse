namespace core.config
{
	public class IAbyssFisheryLevelInfo : IConfigItem
	{
		public int exp { get; set; }

		public int id { get; set; }

		public int rank { get; set; }

		public int rare { get; set; }

		public int star { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			star = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
