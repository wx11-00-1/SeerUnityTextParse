namespace core.config
{
	public class SpHideMovesShop : XlsConfigBase<SpHideMovesShop, ISpHideMovesShopInfo>
	{
		public override string fileName
		{
			get
			{
				return "sp_hide_moves_shop";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISpHideMovesShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISpHideMovesShopInfo();
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
