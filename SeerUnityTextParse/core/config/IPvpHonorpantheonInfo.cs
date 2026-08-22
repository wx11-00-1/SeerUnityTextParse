namespace core.config
{
	public class IPvpHonorpantheonInfo : IConfigItem
	{
		public string img { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int suit { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			img = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			suit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
