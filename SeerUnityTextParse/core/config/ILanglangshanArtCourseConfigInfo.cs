namespace core.config
{
	public class ILanglangshanArtCourseConfigInfo : IConfigItem
	{
		public string reward { get; set; }

		public int difficulty { get; set; }

		public int id { get; set; }

		public int imagine { get; set; }

		public int inspiration { get; set; }

		public int observe { get; set; }

		public int obstaclesNum { get; set; }

		public int skill { get; set; }

		public int unlockTime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			difficulty = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			imagine = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			inspiration = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			observe = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			obstaclesNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unlockTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
