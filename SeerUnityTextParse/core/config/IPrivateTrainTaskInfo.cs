namespace core.config
{
	public class IPrivateTrainTaskInfo : IConfigItem
	{
		public string rewardinfo { get; set; }

		public string title { get; set; }

		public int group { get; set; }

		public int id { get; set; }

		public int jump { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			jump = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
