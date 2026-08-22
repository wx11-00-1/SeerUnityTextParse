namespace core.config
{
	public class IDangoStoryInfo : IConfigItem
	{
		public string describe { get; set; }

		public int dangoID { get; set; }

		public int dangoTask { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			dangoID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dangoTask = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
