namespace core.config
{
	public class ISunmoonStagewaveInfo : IConfigItem
	{
		public int id { get; set; }

		public int isprompt { get; set; }

		public int stageid { get; set; }

		public int waveid { get; set; }

		public int wavestarttime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isprompt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			waveid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wavestarttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
