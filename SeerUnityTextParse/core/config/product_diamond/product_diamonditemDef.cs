namespace core.config.product_diamond
{
	public class product_diamonditemDef
	{
		public string name;

		public int productID;

		public string itemID;

		public int price;

		public float vip;

		public string icon;

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			vip = ByteUtil.ReadFloat(bytes, ref byteIndex);
			icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
