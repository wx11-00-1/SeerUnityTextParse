namespace core.config
{
	public class ISunmoonFightInfo : IConfigItem
	{
		public string line { get; set; }

		public string monster { get; set; }

		public int delaytime { get; set; }

		public int id { get; set; }

		public int stageid { get; set; }

		public int waveid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			delaytime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			line = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			monster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			waveid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
