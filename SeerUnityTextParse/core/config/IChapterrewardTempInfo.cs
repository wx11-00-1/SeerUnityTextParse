namespace core.config
{
	public class IChapterrewardTempInfo : IConfigItem
	{
		public string item { get; set; }

		public int chapterid { get; set; }

		public int id { get; set; }

		public int open { get; set; }

		public int order { get; set; }

		public int param { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			item = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			open = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			param = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
