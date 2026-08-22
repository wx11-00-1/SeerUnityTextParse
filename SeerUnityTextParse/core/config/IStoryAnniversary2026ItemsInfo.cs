namespace core.config
{
	public class IStoryAnniversary2026ItemsInfo : IConfigItem
	{
		public string desc { get; set; }

		public string image { get; set; }

		public string name { get; set; }

		public int donate { get; set; }

		public int id { get; set; }

		public int sort { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			donate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
