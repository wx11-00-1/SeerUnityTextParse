namespace core.config
{
	public class IBrickBreakerGameBuffInfo : IConfigItem
	{
		public string des { get; set; }

		public string name { get; set; }

		public string value { get; set; }

		public int buffid { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int rare { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			buffid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
