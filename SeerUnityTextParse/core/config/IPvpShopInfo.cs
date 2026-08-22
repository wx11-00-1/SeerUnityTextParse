namespace core.config
{
	public class IPvpShopInfo : IConfigItem
	{
		public string commodity { get; set; }

		public string petinfo { get; set; }

		public int bagLimit { get; set; }

		public int consumeitemid { get; set; }

		public int discount { get; set; }

		public int id { get; set; }

		public int limit { get; set; }

		public int price { get; set; }

		public int producttype { get; set; }

		public int quantity { get; set; }

		public int sort { get; set; }

		public int suit { get; set; }

		public int type { get; set; }

		public int userinfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bagLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			discount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			producttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			suit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
