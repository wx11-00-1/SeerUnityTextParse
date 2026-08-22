namespace core.config
{
	public class IShopElfInfo : IConfigItem
	{
		public string name { get; set; }

		public string reward { get; set; }

		public int[] discountprice { get; set; }

		public int[] gift { get; set; }

		public int[] price { get; set; }

		public int discount { get; set; }

		public int id { get; set; }

		public int miditem { get; set; }

		public int prop { get; set; }

		public int quota { get; set; }

		public int recommend { get; set; }

		public int show { get; set; }

		public int sort { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			discount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				discountprice = new int[num];
				for (int i = 0; i < num; i++)
				{
					discountprice[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				gift = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					gift[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			miditem = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				price = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					price[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			prop = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quota = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			recommend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			show = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
