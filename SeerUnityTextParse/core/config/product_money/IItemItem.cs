namespace core.config.product_money
{
	public class IItemItem
	{
		public string name { get; set; }

		public int[] itemID { get; set; }

		public int gold { get; set; }

		public float price { get; set; }

		public int productID { get; set; }

		public int vip { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			gold = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				itemID = new int[num];
				for (int i = 0; i < num; i++)
				{
					itemID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadFloat(bytes, ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			vip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
