namespace core.config
{
	public class IDrinkrecipeInfo : IConfigItem
	{
		public string introduce { get; set; }

		public string name { get; set; }

		public string tag { get; set; }

		public int id { get; set; }

		public int recipe1 { get; set; }

		public int recipe2 { get; set; }

		public int recipe3 { get; set; }

		public int time { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			introduce = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			recipe1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			recipe2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			recipe3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
