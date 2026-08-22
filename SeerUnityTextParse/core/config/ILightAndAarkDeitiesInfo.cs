namespace core.config
{
	public class ILightAndAarkDeitiesInfo : IConfigItem
	{
		public string commodity { get; set; }

		public string petinfo { get; set; }

		public int id { get; set; }

		public int price { get; set; }

		public int productID { get; set; }

		public int tab { get; set; }

		public int type { get; set; }

		public int unique { get; set; }

		public int userInfoBitPos { get; set; }

		public int userInfoId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tab = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unique = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userInfoBitPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
