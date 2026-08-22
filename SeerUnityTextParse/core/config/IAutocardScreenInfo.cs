namespace core.config
{
	public class IAutocardScreenInfo : IConfigItem
	{
		public string jumpToLink { get; set; }

		public string source { get; set; }

		public int duration { get; set; }

		public int endTime { get; set; }

		public int id { get; set; }

		public int jumpTo { get; set; }

		public int sort { get; set; }

		public int startTime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			duration = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			endTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			jumpTo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			jumpToLink = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			source = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			startTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
