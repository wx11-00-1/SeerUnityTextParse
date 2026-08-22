namespace core.config.Attireconversion
{
	public class IAttireconversionItem
	{
		public int ExchangeNum { get; set; }

		public int ID { get; set; }

		public int Platform { get; set; }

		public int RewardID { get; set; }

		public int RewardNum { get; set; }

		public int SubNum { get; set; }

		public int UserInfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ExchangeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Platform = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			RewardID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			RewardNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SubNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UserInfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
