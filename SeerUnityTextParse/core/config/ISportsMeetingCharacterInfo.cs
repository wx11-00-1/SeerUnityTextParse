namespace core.config
{
	public class ISportsMeetingCharacterInfo : IConfigItem
	{
		public string level1value { get; set; }

		public string level2value { get; set; }

		public string level3value { get; set; }

		public string name { get; set; }

		public string skilldescribe { get; set; }

		public int id { get; set; }

		public int skill { get; set; }

		public int unlock { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level1value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			level2value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			level3value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skilldescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
