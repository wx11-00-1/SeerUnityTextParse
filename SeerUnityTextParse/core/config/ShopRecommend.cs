namespace core.config
{
	public class ShopRecommend : XlsConfigBase<ShopRecommend, IShopRecommendInfo>
	{
		public override string fileName
		{
			get
			{
				return "shop_recommend";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IShopRecommendInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IShopRecommendInfo();
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
