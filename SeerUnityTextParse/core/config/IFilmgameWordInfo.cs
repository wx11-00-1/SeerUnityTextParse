namespace core.config
{
	public class IFilmgameWordInfo : IConfigItem
	{
		public string word { get; set; }

		public int id { get; set; }

		public int wordtype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			word = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			wordtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
