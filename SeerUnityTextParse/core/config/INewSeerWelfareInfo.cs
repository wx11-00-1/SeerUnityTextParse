namespace core.config
{
	public class INewSeerWelfareInfo : IConfigItem
	{
		public string beginning { get; set; }

		public string ending { get; set; }

		public string name { get; set; }

		public string statLog { get; set; }

		public int Go { get; set; }

		public int id { get; set; }

		public int redPointID { get; set; }

		public int sorting { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Go = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			redPointID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			statLog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
