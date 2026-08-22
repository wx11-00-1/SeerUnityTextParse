namespace core.config.WishMintmark
{
	public class IWishMintmarkItem
	{
		public string MintmarkName { get; set; }

		public int MintmarkID { get; set; }

		public int WishMintmarkID { get; set; }

		public int WishrankID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MintmarkName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			WishMintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			WishrankID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
