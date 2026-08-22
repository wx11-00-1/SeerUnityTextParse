namespace core.config
{
	public class IStory2007Info : IConfigItem
	{
		public string param1 { get; set; }

		public string param2 { get; set; }

		public string param3 { get; set; }

		public string param4 { get; set; }

		public string param5 { get; set; }

		public int control { get; set; }

		public int id { get; set; }

		public int logic { get; set; }

		public int next { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			control = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
