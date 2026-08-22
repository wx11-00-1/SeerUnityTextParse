namespace core.config
{
	public class IInsectFormationInfo : IConfigItem
	{
		public string Abscissa { get; set; }

		public string LockExclude { get; set; }

		public string LockSymbol { get; set; }

		public string Ordinate { get; set; }

		public string Prompt { get; set; }

		public string Target { get; set; }

		public int id { get; set; }

		public int Level { get; set; }

		public int Sort { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Abscissa = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LockExclude = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			LockSymbol = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Ordinate = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Prompt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
