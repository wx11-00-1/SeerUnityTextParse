namespace core.config.shop_config
{
	public class IRoot
	{
		public IMenuItem[] menu { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				menu = new IMenuItem[num];
				for (int i = 0; i < num; i++)
				{
					menu[i] = new IMenuItem();
					menu[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
