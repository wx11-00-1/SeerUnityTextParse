namespace core.config.Wishskin
{
	public class IWishskinItem
	{
		public int MonID { get; set; }

		public int PetSkinID { get; set; }

		public int WishskinID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PetSkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			WishskinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
