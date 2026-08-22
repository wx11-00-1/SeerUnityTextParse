namespace core.config.midleItems
{
	public class IItemsItem
	{
		public string Name { get; set; }

		public int catID { get; set; }

		public int ID { get; set; }

		public int Max { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
