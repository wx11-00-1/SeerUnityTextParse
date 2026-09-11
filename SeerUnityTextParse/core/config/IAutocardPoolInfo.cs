namespace core.config
{
	public class IAutocardPoolInfo : IConfigItem
	{
		public string Cos1 { get; set; }

		public string Cos10 { get; set; }

		public int AutoCardPetId { get; set; }

		public int consumeitemid1 { get; set; }

		public int consumeitemid2 { get; set; }

		public int id { get; set; }

		public int limitbuycount1 { get; set; }

		public int limitbuycount2 { get; set; }

		public int rewarditemcount1 { get; set; }

		public int rewarditemcount2 { get; set; }

		public int rewarditemid1 { get; set; }

		public int rewarditemid2 { get; set; }

		public int userInfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			AutoCardPetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Cos1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Cos10 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			consumeitemid1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			consumeitemid2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limitbuycount1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limitbuycount2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewarditemcount1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewarditemcount2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewarditemid1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewarditemid2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userInfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
