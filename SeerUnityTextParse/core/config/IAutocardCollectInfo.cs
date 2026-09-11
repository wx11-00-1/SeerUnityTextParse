namespace core.config
{
	public class IAutocardCollectInfo : IConfigItem
	{
		public string decompose { get; set; }

		public string ExpTotal { get; set; }

		public string levelinfo { get; set; }

		public string Reward_1 { get; set; }

		public string Reward_2 { get; set; }

		public string Reward_3 { get; set; }

		public string rewardbit { get; set; }

		public int card_id { get; set; }

		public int Expforever { get; set; }

		public int id { get; set; }

		public int rankitem { get; set; }

		public int Rewarduserinfo { get; set; }

		public int sesisson { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ExpTotal = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Expforever = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Reward_1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Reward_2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Reward_3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Rewarduserinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			card_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			decompose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			levelinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rankitem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardbit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sesisson = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
