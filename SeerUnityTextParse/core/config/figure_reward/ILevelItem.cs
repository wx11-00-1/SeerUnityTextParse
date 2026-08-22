namespace core.config.figure_reward
{
	public class ILevelItem
	{
		public int ExpNeed { get; set; }

		public int ID { get; set; }

		public int RewardID { get; set; }

		public int UseBit { get; set; }

		public int UseValue { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ExpNeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			RewardID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UseBit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UseValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
