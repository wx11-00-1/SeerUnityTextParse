namespace core.config.Wishsuit
{
	public class IWishsuits
	{
		public IWishsuitItem[] Wishsuit { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Wishsuit = new IWishsuitItem[num];
				for (int i = 0; i < num; i++)
				{
					Wishsuit[i] = new IWishsuitItem();
					Wishsuit[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
