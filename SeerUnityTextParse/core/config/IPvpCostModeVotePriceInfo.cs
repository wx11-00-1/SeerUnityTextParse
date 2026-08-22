namespace core.config
{
	public class IPvpCostModeVotePriceInfo : IConfigItem
	{
		public int id { get; set; }

		public int price { get; set; }

		public int rank { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
