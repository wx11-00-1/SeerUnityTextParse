namespace core.config
{
	public class IStarBeanShopInfo : IConfigItem
	{
		public int commodity { get; set; }

		public int currency { get; set; }

		public int grade { get; set; }

		public int id { get; set; }

		public int limit { get; set; }

		public int MintmarkID { get; set; }

		public int NewSeID { get; set; }

		public int price { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewSeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			commodity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			currency = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			grade = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
