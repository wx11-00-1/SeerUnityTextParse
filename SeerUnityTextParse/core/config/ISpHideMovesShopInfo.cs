namespace core.config
{
	public class ISpHideMovesShopInfo : IConfigItem
	{
		public string ItemName { get; set; }

		public int CoinId { get; set; }

		public int id { get; set; }

		public int ItemId { get; set; }

		public int Limit { get; set; }

		public int MonsterId { get; set; }

		public int MoveId { get; set; }

		public int Price { get; set; }

		public int UserInfoId { get; set; }

		public int UserInfoPos { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			CoinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ItemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ItemName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MoveId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UserInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UserInfoPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
