namespace core.config.midleExchangeItems
{
	public class midleExchangeItemsItemDef
	{
		public int ID;

		public string Name;

		public int Max;

		public int catID;

		public int TargetId;

		public int ExchangeId;

		public string ExchangeOutId;

		public string ExchangeOutCnt;

		public int SkinId;

		public int ExchangeType;

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			SkinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ExchangeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
