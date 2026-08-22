namespace core.config
{
	public class IDailytaskInfo : IConfigItem
	{
		public string describe { get; set; }

		public string rewardinfo { get; set; }

		public string title { get; set; }

		public string value { get; set; }

		public int id { get; set; }

		public int target { get; set; }

		public int time { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
