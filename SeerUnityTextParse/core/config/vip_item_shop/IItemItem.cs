namespace core.config.vip_item_shop
{
	public class IItemItem
	{
		public int ex { get; set; }

		public int Id { get; set; }

		public int LimitLv { get; set; }

		public int LimitNum { get; set; }

		public int MiditemId { get; set; }

		public int MonthKey { get; set; }

		public int MonthPos { get; set; }

		public int Price { get; set; }

		public int productID { get; set; }

		public int ShowNum { get; set; }

		public int ShowReward { get; set; }

		public int Type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LimitLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LimitNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MiditemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonthKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonthPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ShowNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ShowReward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ex = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
