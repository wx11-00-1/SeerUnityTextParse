namespace core.config
{
	public class ISomuaTaskConfigInfo : IConfigItem
	{
		public string describe { get; set; }

		public string rewardinfo { get; set; }

		public int group { get; set; }

		public int id { get; set; }

		public int period { get; set; }

		public int season { get; set; }

		public int tasktype { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			period = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			season = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
