namespace core.config
{
	public class IActivityTimeUpdateConfigInfo : IConfigItem
	{
		public string beginning { get; set; }

		public string ending { get; set; }

		public string name { get; set; }

		public string parametersDesc { get; set; }

		public int id { get; set; }

		public int parameters1 { get; set; }

		public int parameters2 { get; set; }

		public int parameters3 { get; set; }

		public int parameters4 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			parameters1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			parameters2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			parameters3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			parameters4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			parametersDesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
