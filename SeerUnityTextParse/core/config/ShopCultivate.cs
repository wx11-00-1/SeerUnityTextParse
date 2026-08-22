namespace core.config
{
	public class ShopCultivate : XlsConfigBase<ShopCultivate, IShopCultivateInfo>
	{
		public override string fileName
		{
			get
			{
				return "shop_cultivate";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IShopCultivateInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IShopCultivateInfo();
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
