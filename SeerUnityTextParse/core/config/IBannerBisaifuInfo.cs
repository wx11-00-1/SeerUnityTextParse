namespace core.config
{
	public class IBannerBisaifuInfo : IConfigItem
	{
		public string finishtime { get; set; }

		public string image { get; set; }

		public string starttime { get; set; }

		public int id { get; set; }

		public int isshow { get; set; }

		public int sort { get; set; }

		public int target { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			finishtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
