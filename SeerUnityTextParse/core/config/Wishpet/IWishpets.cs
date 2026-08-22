namespace core.config.Wishpet
{
	public class IWishpets
	{
		public IWishpetItem[] Wishpet { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Wishpet = new IWishpetItem[num];
				for (int i = 0; i < num; i++)
				{
					Wishpet[i] = new IWishpetItem();
					Wishpet[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
