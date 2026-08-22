namespace core.config
{
	public class IPrivateShopInfo : IConfigItem
	{
		public string content { get; set; }

		public string title { get; set; }

		public int bytepos { get; set; }

		public int costNum { get; set; }

		public int costType { get; set; }

		public int id { get; set; }

		public int limitNum { get; set; }

		public int limitType { get; set; }

		public int originPrice { get; set; }

		public int productID { get; set; }

		public int type { get; set; }

		public int userinfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bytepos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			content = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			costNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			costType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limitNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limitType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			originPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
