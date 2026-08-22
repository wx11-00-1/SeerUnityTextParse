namespace core.config
{
	public class IPassShopInfo : IConfigItem
	{
		public string commodity { get; set; }

		public int consumeitemid { get; set; }

		public int discount { get; set; }

		public int id { get; set; }

		public int limit { get; set; }

		public int price { get; set; }

		public int quantity { get; set; }

		public int sort { get; set; }

		public int userinfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			discount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
