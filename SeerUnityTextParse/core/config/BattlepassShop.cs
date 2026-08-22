namespace core.config
{
	public class BattlepassShop : XlsConfigBase<BattlepassShop, IBattlepassShopInfo>
	{
		public override string fileName
		{
			get
			{
				return "battlepass_shop";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBattlepassShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBattlepassShopInfo();
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
