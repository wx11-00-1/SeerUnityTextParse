namespace core.config
{
	public class IElfGachaTaskInfo : IConfigItem
	{
		public string endtime { get; set; }

		public string rewardinfo { get; set; }

		public string title { get; set; }

		public int id { get; set; }

		public int NewMsglogId { get; set; }

		public int poolid { get; set; }

		public int taskid { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			taskid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
