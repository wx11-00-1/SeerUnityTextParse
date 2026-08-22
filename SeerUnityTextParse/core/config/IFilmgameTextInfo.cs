namespace core.config
{
	public class IFilmgameTextInfo : IConfigItem
	{
		public string text { get; set; }

		public int id { get; set; }

		public int texttype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			texttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
