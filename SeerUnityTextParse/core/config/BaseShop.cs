namespace core.config
{
	public class BaseShop : XlsConfigBase<BaseShop, IBaseShopInfo>
	{
		public override string fileName
		{
			get
			{
				return "baseShop";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBaseShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBaseShopInfo();
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
