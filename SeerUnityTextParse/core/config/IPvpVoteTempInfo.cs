namespace core.config
{
	public class IPvpVoteTempInfo : IConfigItem
	{
		public string name { get; set; }

		public string oldresult { get; set; }

		public string result { get; set; }

		public int id { get; set; }

		public int number { get; set; }

		public int ranklimit1 { get; set; }

		public int ranklimit2 { get; set; }

		public int subkey { get; set; }

		public int time1 { get; set; }

		public int time2 { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			number = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			oldresult = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ranklimit1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ranklimit2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			result = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			subkey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
