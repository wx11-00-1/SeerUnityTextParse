namespace core.config
{
	public class IBrickBreakerGameSkillInfo : IConfigItem
	{
		public string des { get; set; }

		public string name { get; set; }

		public string unlock { get; set; }

		public string unlockdes { get; set; }

		public int consume { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int locationshow { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			consume = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			locationshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			unlock = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			unlockdes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
