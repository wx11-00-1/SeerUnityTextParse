namespace core.config
{
	public class IMatchGameInfo : IConfigItem
	{
		public string beginning { get; set; }

		public string describe { get; set; }

		public string ending { get; set; }

		public string name { get; set; }

		public string reward { get; set; }

		public int Horizontal { get; set; }

		public int id { get; set; }

		public int npdSkin { get; set; }

		public int score { get; set; }

		public int time { get; set; }

		public int Vertical { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Horizontal = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Vertical = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			npdSkin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			score = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
