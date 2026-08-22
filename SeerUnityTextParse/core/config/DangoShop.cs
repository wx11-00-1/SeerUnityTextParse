namespace core.config
{
	public class DangoShop : XlsConfigBase<DangoShop, IDangoShopInfo>
	{
		public override string fileName
		{
			get
			{
				return "dangoShop";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IDangoShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IDangoShopInfo();
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
