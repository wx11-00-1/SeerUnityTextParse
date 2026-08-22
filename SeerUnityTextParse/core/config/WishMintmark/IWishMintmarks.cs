namespace core.config.WishMintmark
{
	public class IWishMintmarks
	{
		public IWishMintmarkItem[] WishMintmark { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				WishMintmark = new IWishMintmarkItem[num];
				for (int i = 0; i < num; i++)
				{
					WishMintmark[i] = new IWishMintmarkItem();
					WishMintmark[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
