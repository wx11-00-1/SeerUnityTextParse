namespace core.config.midleExchangeItems
{
	public class IItemsItem
	{
		public string ExchangeOutCnt { get; set; }

		public string ExchangeOutId { get; set; }

		public string Name { get; set; }

		public int catID { get; set; }

		public int ExchangeId { get; set; }

		public int ExchangeType { get; set; }

		public int ID { get; set; }

		public int Max { get; set; }

		public int SkinId { get; set; }

		public int TargetId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ExchangeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			SkinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
