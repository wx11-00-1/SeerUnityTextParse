namespace core.config
{
	public class IPvpQuizshopInfo : IConfigItem
	{
		public string name { get; set; }

		public int consumeitemid { get; set; }

		public int id { get; set; }

		public int limit { get; set; }

		public int price { get; set; }

		public int product { get; set; }

		public int productnum { get; set; }

		public int producttype { get; set; }

		public int quantity { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			product = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			producttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
