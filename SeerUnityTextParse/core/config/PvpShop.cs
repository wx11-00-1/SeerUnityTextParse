namespace core.config
{
	public class PvpShop : XlsConfigBase<PvpShop, IPvpShopInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvp_shop";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpShopInfo();
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
