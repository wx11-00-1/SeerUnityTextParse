namespace core.config
{
	public class IMinstoneSaleInfo : IConfigItem
	{
		public string packName { get; set; }

		public int id { get; set; }

		public int ItemId { get; set; }

		public int limit { get; set; }

		public int originalPrice { get; set; }

		public int price { get; set; }

		public int productId { get; set; }

		public int quantity { get; set; }

		public int RewardId { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ItemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			RewardId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			originalPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			packName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
