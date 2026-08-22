namespace core.config
{
	public class ISPTstarInfo : IConfigItem
	{
		public int achievementid { get; set; }

		public int galaxyid { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int rewardid { get; set; }

		public int starcnt { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			achievementid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			galaxyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
