namespace core.config
{
	public class IStarDiamondShopInfo : IConfigItem
	{
		public string icon { get; set; }

		public string name { get; set; }

		public string reward { get; set; }

		public int commodity { get; set; }

		public int currency { get; set; }

		public int grade { get; set; }

		public int id { get; set; }

		public int limit { get; set; }

		public int MintmarkID { get; set; }

		public int NewSeID { get; set; }

		public int price { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewSeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			commodity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			currency = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			grade = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
