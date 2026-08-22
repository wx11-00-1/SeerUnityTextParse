namespace core.config.titanlode
{
	public class IShowItem : IConfigItem
	{
		public int id { get; set; }

		public int randomcnt { get; set; }

		public int rewardid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			randomcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
