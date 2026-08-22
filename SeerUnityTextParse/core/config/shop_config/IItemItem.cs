namespace core.config.shop_config
{
	public class IItemItem
	{
		public string checkBuy { get; set; }

		public string name { get; set; }

		public string tip { get; set; }

		public int[] checkown { get; set; }

		public int[] itemID { get; set; }

		public int coins { get; set; }

		public int exchangeId { get; set; }

		public int excludeSearch { get; set; }

		public int gold { get; set; }

		public int hide { get; set; }

		public int malldiscount { get; set; }

		public int mintMark { get; set; }

		public int MonsterID { get; set; }

		public int moveID { get; set; }

		public int POPID { get; set; }

		public float price { get; set; }

		public int productID { get; set; }

		public int productType { get; set; }

		public int skinId { get; set; }

		public int tip2 { get; set; }

		public int tip3 { get; set; }

		public int type { get; set; }

		public int usenew { get; set; }

		public float vip { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			POPID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			checkBuy = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				checkown = new int[num];
				for (int i = 0; i < num; i++)
				{
					checkown[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			coins = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			exchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			excludeSearch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			gold = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				itemID = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					itemID[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			malldiscount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			mintMark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			moveID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadFloat(bytes, ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tip = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tip2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tip3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			usenew = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			vip = ByteUtil.ReadFloat(bytes, ref byteIndex);
		}
	}
}
