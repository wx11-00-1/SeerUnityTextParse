namespace core.config
{
	public class IFilmgameActionInfo : IConfigItem
	{
		public string trueword { get; set; }

		public int id { get; set; }

		public int lens { get; set; }

		public int order { get; set; }

		public int says { get; set; }

		public int storyid { get; set; }

		public int textid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lens = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			says = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			storyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			textid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			trueword = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
