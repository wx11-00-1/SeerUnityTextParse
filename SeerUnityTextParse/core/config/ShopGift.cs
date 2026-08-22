namespace core.config
{
	public class ShopGift : XlsConfigBase<ShopGift, IShopGiftInfo>
	{
		public override string fileName
		{
			get
			{
				return "shop_gift";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IShopGiftInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IShopGiftInfo();
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
