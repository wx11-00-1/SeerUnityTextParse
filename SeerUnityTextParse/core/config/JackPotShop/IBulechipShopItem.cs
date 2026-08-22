namespace core.config.JackPotShop
{
	public class IBulechipShopItem
	{
		public string productName { get; set; }

		public int[] productID { get; set; }

		public int batch { get; set; }

		public int Endtime { get; set; }

		public int exchangeId { get; set; }

		public int forever { get; set; }

		public int ID { get; set; }

		public int Opentime { get; set; }

		public int productPrice { get; set; }

		public int shopkind { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			batch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			exchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			forever = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				productID = new int[num];
				for (int i = 0; i < num; i++)
				{
					productID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			productName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			productPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			shopkind = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
