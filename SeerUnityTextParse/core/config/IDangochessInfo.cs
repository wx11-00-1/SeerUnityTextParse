namespace core.config
{
	public class IDangochessInfo : IConfigItem
	{
		public string cardid { get; set; }

		public string firstreward { get; set; }

		public string GuideCard { get; set; }

		public string starttime { get; set; }

		public int chapterid { get; set; }

		public int dangoID { get; set; }

		public int id { get; set; }

		public int stageid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			GuideCard = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			cardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dangoID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			firstreward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
