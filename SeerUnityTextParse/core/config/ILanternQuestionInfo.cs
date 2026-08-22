namespace core.config
{
	public class ILanternQuestionInfo : IConfigItem
	{
		public string Achoose { get; set; }

		public string Bchoose { get; set; }

		public string Cchoose { get; set; }

		public string Dchoose { get; set; }

		public string describe { get; set; }

		public int answer { get; set; }

		public int id { get; set; }

		public int title { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Achoose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Bchoose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Cchoose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Dchoose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			answer = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
