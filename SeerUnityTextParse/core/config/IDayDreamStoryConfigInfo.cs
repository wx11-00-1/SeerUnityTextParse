namespace core.config
{
	public class IDayDreamStoryConfigInfo : IConfigItem
	{
		public string a { get; set; }

		public string b { get; set; }

		public string c { get; set; }

		public string status { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			a = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			b = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			c = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			status = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
