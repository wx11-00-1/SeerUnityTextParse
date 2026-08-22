namespace core.config
{
	public class IFilmgameStoryInfo : IConfigItem
	{
		public string actlist { get; set; }

		public string acttype { get; set; }

		public string bglist { get; set; }

		public string name { get; set; }

		public string recstyle { get; set; }

		public string trueactor { get; set; }

		public string truebg { get; set; }

		public int actnum { get; set; }

		public int id { get; set; }

		public int wordnum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			actlist = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			actnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			acttype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bglist = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			recstyle = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			trueactor = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			truebg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			wordnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
