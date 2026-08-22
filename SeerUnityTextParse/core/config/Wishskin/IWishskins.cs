namespace core.config.Wishskin
{
	public class IWishskins
	{
		public IWishskinItem[] Wishskin { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Wishskin = new IWishskinItem[num];
				for (int i = 0; i < num; i++)
				{
					Wishskin[i] = new IWishskinItem();
					Wishskin[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
