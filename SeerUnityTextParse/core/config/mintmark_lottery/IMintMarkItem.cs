namespace core.config.mintmark_lottery
{
	public class IMintMarkItem
	{
		public string Des { get; set; }

		public int exchangeId { get; set; }

		public int ID { get; set; }

		public int Level { get; set; }

		public int maxNum { get; set; }

		public int price { get; set; }

		public int puton { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			exchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			maxNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			puton = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
