namespace core.config
{
	public class IDragonboatExploratioLevelInfo : IConfigItem
	{
		public string plotOrigin { get; set; }

		public string plotStorage { get; set; }

		public string rewardSpace { get; set; }

		public string space { get; set; }

		public int id { get; set; }

		public int originSpace { get; set; }

		public int plotLimit { get; set; }

		public int unlocktime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			originSpace = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			plotLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			plotOrigin = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			plotStorage = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardSpace = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			space = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			unlocktime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
