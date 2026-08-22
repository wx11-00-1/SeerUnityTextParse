namespace core.config
{
	public class IFilmgameLvInfo : IConfigItem
	{
		public string name { get; set; }

		public int exp { get; set; }

		public int id { get; set; }

		public int lockstory { get; set; }

		public int lv { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lockstory = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
