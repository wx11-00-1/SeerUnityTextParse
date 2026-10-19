namespace core.config
{
	public class IBrickBreakerGameLevelInfo : IConfigItem
	{
		public string des { get; set; }

		public string monsterid { get; set; }

		public string name { get; set; }

		public int batch { get; set; }

		public int id { get; set; }

		public int levelid { get; set; }

		public int line { get; set; }

		public int linesquares { get; set; }

		public int monsterrate { get; set; }

		public int monstertype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			batch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			levelid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			line = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			linesquares = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			monsterrate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monstertype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
