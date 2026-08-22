namespace core.config
{
	public class IDuelChatInfo : IConfigItem
	{
		public string describe { get; set; }

		public int chattype { get; set; }

		public int endtime { get; set; }

		public int head { get; set; }

		public int id { get; set; }

		public int LevelId { get; set; }

		public int starttime { get; set; }

		public int texttype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			LevelId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			chattype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			head = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			texttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
