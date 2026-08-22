namespace core.config
{
	public class IExplorationRewardInfo : IConfigItem
	{
		public int @class { get; set; }

		public int currency { get; set; }

		public int currencynum { get; set; }

		public int id { get; set; }

		public int item { get; set; }

		public int limit { get; set; }

		public int number { get; set; }

		public int sort { get; set; }

		public int starting { get; set; }

		public int type { get; set; }

		public int user_info { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			@class = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			currency = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			currencynum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			item = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			number = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			user_info = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
