namespace core.config.Wishpet
{
	public class IWishpetItem
	{
		public int MonsterID { get; set; }

		public int MonsterStar { get; set; }

		public int WishpetID { get; set; }

		public int WishProgress { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonsterStar = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			WishProgress = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			WishpetID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
