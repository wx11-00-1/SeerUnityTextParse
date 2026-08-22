namespace core.config.Attirerecycle
{
	public class IAttirerecycleItem
	{
		public string ItemName { get; set; }

		public int ID { get; set; }

		public int ItemID { get; set; }

		public int OutputNum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ItemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ItemName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			OutputNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
