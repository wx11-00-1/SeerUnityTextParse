namespace core.config
{
	public class ITeamResourceInfo : IConfigItem
	{
		public int ExchangeLimit { get; set; }

		public int id { get; set; }

		public int ObtainItemNeedContribute { get; set; }

		public int ObtainItemNeedExp { get; set; }

		public int RewardID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ExchangeLimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ObtainItemNeedContribute = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ObtainItemNeedExp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			RewardID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
