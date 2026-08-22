namespace core.config
{
	public class IClassicSweepInfoInfo : IConfigItem
	{
		public string Arg2 { get; set; }

		public string LevelLock { get; set; }

		public string name { get; set; }

		public int Arg1 { get; set; }

		public int dataKey { get; set; }

		public int id { get; set; }

		public int monsterid { get; set; }

		public int order { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Arg1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Arg2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			LevelLock = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			dataKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
