namespace core.config
{
	public class IDangoTaskInfo : IConfigItem
	{
		public string describe { get; set; }

		public string planet { get; set; }

		public string taskSkin { get; set; }

		public string title { get; set; }

		public int id { get; set; }

		public int limit { get; set; }

		public int NewMsglogId { get; set; }

		public int rewardinfo { get; set; }

		public int taskTeam { get; set; }

		public int tasktype { get; set; }

		public int time { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			planet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			taskSkin = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			taskTeam = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
