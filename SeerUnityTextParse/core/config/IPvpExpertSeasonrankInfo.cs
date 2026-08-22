namespace core.config
{
	public class IPvpExpertSeasonrankInfo : IConfigItem
	{
		public string time { get; set; }

		public int account1 { get; set; }

		public int account2 { get; set; }

		public int account3 { get; set; }

		public int id { get; set; }

		public int score1 { get; set; }

		public int score2 { get; set; }

		public int score3 { get; set; }

		public int winrate1 { get; set; }

		public int winrate2 { get; set; }

		public int winrate3 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			account1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			account2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			account3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			score1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			score2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			score3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			winrate1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			winrate2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			winrate3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
