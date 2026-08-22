namespace core.config
{
	public class IDreamyHotSpringRoadLevelConfigInfo : IConfigItem
	{
		public int id { get; set; }

		public int rewardNum { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
