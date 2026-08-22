namespace core.config
{
	public class IAnniversaryVaultInfo : IConfigItem
	{
		public string commodity { get; set; }

		public string petinfo { get; set; }

		public int id { get; set; }

		public int mintmarkNum { get; set; }

		public int needID { get; set; }

		public int needNum { get; set; }

		public int needtype { get; set; }

		public int page { get; set; }

		public int price { get; set; }

		public int quantity { get; set; }

		public int tab { get; set; }

		public int unique { get; set; }

		public int userInfoId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			mintmarkNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			needID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			needNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			needtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			page = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tab = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unique = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
