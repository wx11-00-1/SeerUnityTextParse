namespace core.config
{
	public class ShopElf : XlsConfigBase<ShopElf, IShopElfInfo>
	{
		public override string fileName
		{
			get
			{
				return "shop_elf";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IShopElfInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IShopElfInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
