namespace core.config
{
	public class PassShop : XlsConfigBase<PassShop, IPassShopInfo>
	{
		public override string fileName
		{
			get
			{
				return "pass_shop";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPassShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPassShopInfo();
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
