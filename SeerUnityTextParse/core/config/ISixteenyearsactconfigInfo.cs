namespace core.config
{
	public class ISixteenyearsactconfigInfo : IConfigItem
	{
		public string activitiesshow { get; set; }

		public string name { get; set; }

		public string showtime { get; set; }

		public string title { get; set; }

		public int begintime { get; set; }

		public int endtime { get; set; }

		public int gift { get; set; }

		public int id { get; set; }

		public int target { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			activitiesshow = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			begintime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			gift = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			showtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
