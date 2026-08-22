namespace core.config
{
	public class IAchievementbonusInfo : IConfigItem
	{
		public string rewardcnt { get; set; }

		public string rewardid { get; set; }

		public int Branch { get; set; }

		public int id { get; set; }

		public int rewardtype { get; set; }

		public int Rule { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Branch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Rule = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
