namespace core.config.titanlode
{
	public class IRewardItem : IConfigItem
	{
		public int id { get; set; }

		public int realcnt { get; set; }

		public int realid { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			realcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			realid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
