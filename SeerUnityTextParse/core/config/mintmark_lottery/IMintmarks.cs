namespace core.config.mintmark_lottery
{
	public class IMintmarks
	{
		public IMenuItem[] Menu { get; set; }

		public IShop Shop { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Menu = new IMenuItem[num];
				for (int i = 0; i < num; i++)
				{
					Menu[i] = new IMenuItem();
					Menu[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Shop = new IShop();
				Shop.Parse(bytes, ref byteIndex);
			}
		}
	}
}
