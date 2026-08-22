namespace core.config
{
	public class IAutocarddiduoRewardInfo : IConfigItem
	{
		public string diduoReward { get; set; }

		public int coinNum { get; set; }

		public int id { get; set; }

		public int rewardrank { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			coinNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			diduoReward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardrank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
