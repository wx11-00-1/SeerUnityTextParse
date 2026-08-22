namespace core.config
{
	public class IAutocardShopInfo : IConfigItem
	{
		public int bonuscard { get; set; }

		public int cardmax { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int lvlup_cost { get; set; }

		public int rate1 { get; set; }

		public int rate2 { get; set; }

		public int rate3 { get; set; }

		public int rate4 { get; set; }

		public int rate5 { get; set; }

		public int rate6 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bonuscard = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cardmax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lvlup_cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rate1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rate2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rate3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rate4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rate5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rate6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
