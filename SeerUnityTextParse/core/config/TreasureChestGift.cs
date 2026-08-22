namespace core.config
{
	public class TreasureChestGift : XlsConfigBase<TreasureChestGift, ITreasureChestGiftInfo>
	{
		public override string fileName
		{
			get
			{
				return "treasure_chest_gift";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ITreasureChestGiftInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ITreasureChestGiftInfo();
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
