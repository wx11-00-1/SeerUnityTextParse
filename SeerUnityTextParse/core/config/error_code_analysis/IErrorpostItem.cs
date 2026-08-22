namespace core.config.error_code_analysis
{
	public class IErrorpostItem : IConfigItem
	{
		public int @event { get; set; }

		public int id { get; set; }

		public string tx { get; set; }

		public int txType { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			@event = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tx = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			txType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
