namespace core.config.JackPotShop
{
	public class IBlueChipShops
	{
		public IBulechipShopItem[] BulechipShop { get; set; }

		public string Endday { get; set; }

		public string Endtime { get; set; }

		public string Openday { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				BulechipShop = new IBulechipShopItem[num];
				for (int i = 0; i < num; i++)
				{
					BulechipShop[i] = new IBulechipShopItem();
					BulechipShop[i].Parse(bytes, ref byteIndex);
				}
			}
			Endday = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Openday = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
