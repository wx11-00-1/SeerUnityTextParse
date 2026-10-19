namespace core.config
{
	public class IWarGameSkillInfo : IConfigItem
	{
		public string buff { get; set; }

		public string describe { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int value1 { get; set; }

		public int value2 { get; set; }

		public int valueLvUp1 { get; set; }

		public int valueLvUp2 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			buff = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			value1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			valueLvUp1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			valueLvUp2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
