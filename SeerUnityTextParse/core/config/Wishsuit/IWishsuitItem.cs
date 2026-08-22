namespace core.config.Wishsuit
{
	public class IWishsuitItem
	{
		public string SuitName { get; set; }

		public int SuitID { get; set; }

		public int SuitPart1 { get; set; }

		public int SuitPart2 { get; set; }

		public int SuitPart3 { get; set; }

		public int SuitPart4 { get; set; }

		public int SuitPart5 { get; set; }

		public int WishrankID { get; set; }

		public int WishsuitID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			SuitID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SuitName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			SuitPart1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SuitPart2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SuitPart3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SuitPart4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SuitPart5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			WishrankID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			WishsuitID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
