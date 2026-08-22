namespace core.config
{
	public class INewSeer7SignInfo : IConfigItem
	{
		public string Daycount { get; set; }

		public string GiftID { get; set; }

		public string GiftName { get; set; }

		public string GiftType { get; set; }

		public int Amount { get; set; }

		public int id { get; set; }

		public int Rare { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Amount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Daycount = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			GiftID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			GiftName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			GiftType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
