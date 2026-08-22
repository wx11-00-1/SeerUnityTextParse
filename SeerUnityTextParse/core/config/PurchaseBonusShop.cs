namespace core.config
{
	public class PurchaseBonusShop : XlsConfigBase<PurchaseBonusShop, IPurchaseBonusShopInfo>
	{
		public override string fileName
		{
			get
			{
				return "purchaseBonus_shop";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPurchaseBonusShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPurchaseBonusShopInfo();
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
