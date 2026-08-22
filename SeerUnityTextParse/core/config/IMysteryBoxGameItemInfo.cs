namespace core.config
{
	public class IMysteryBoxGameItemInfo : IConfigItem
	{
		public string des { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int price { get; set; }

		public int rare { get; set; }

		public int size { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			size = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
