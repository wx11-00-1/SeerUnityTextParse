namespace core.config
{
	public class IStarrySkyStoryConfigInfo : IConfigItem
	{
		public string desc { get; set; }

		public string image { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int unlock { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
