namespace core.config
{
	public class IShopInfo : IConfigItem
	{
		public int Discountprice { get; set; }

		public int exchangeId { get; set; }

		public int id { get; set; }

		public int itemID { get; set; }

		public int limittype { get; set; }

		public int productID { get; set; }

		public int usenew { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Discountprice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			exchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limittype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			usenew = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
