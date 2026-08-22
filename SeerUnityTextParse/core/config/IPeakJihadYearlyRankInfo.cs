namespace core.config
{
	public class IPeakJihadYearlyRankInfo : IConfigItem
	{
		public int id { get; set; }

		public int playerID { get; set; }

		public int rank { get; set; }

		public int score { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			playerID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			score = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
