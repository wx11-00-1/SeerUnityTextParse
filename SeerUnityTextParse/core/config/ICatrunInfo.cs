namespace core.config
{
	public class ICatrunInfo : IConfigItem
	{
		public string block { get; set; }

		public string map { get; set; }

		public string name { get; set; }

		public string npc { get; set; }

		public string rewardinfo { get; set; }

		public int endtime { get; set; }

		public int id { get; set; }

		public int score { get; set; }

		public int starttime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			block = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			map = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			npc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			score = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
