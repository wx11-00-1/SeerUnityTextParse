namespace core.config
{
	public class IAbyssFisheryShopInfo : IConfigItem
	{
		public string des { get; set; }

		public string functiondes { get; set; }

		public string name { get; set; }

		public int functiontype { get; set; }

		public int functionvalue { get; set; }

		public int id { get; set; }

		public int price { get; set; }

		public int subtype { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			functiondes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			functiontype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			functionvalue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
