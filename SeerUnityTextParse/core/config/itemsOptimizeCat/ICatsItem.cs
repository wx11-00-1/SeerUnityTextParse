namespace core.config.itemsOptimizeCat
{
	public class ICatsItem
	{
		public string Name { get; set; }

		public string url { get; set; }

		public int DbCatID { get; set; }

		public int ID { get; set; }

		public int Max { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			DbCatID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			url = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
