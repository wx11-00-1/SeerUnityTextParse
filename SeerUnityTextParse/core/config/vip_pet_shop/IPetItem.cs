namespace core.config.vip_pet_shop
{
	public class IPetItem
	{
		public int ForeverHalfPos { get; set; }

		public int ForeverKey { get; set; }

		public int IsExtra { get; set; }

		public int JudgeType { get; set; }

		public int LimitLv { get; set; }

		public int MiditemId { get; set; }

		public int MintmarkId { get; set; }

		public int NewMsglogId { get; set; }

		public int NewSe { get; set; }

		public int PetId { get; set; }

		public int Price { get; set; }

		public int productID { get; set; }

		public int TimeId { get; set; }

		public int TimeSubId { get; set; }

		public int Turn { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ForeverHalfPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ForeverKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsExtra = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			JudgeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LimitLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MiditemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MintmarkId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewMsglogId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewSe = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			PetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TimeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TimeSubId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Turn = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
