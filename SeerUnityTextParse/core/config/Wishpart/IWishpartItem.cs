namespace core.config.Wishpart
{
	public class IWishpartItem
	{
		public string PartItemName { get; set; }

		public string PartItemType { get; set; }

		public int PartItemID { get; set; }

		public int WishpartID { get; set; }

		public int WishrankID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			PartItemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PartItemName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			PartItemType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			WishpartID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			WishrankID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
