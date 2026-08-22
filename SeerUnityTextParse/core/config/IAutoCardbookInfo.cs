namespace core.config
{
	public class IAutoCardbookInfo : IConfigItem
	{
		public string BuffIcon { get; set; }

		public string CardRecom { get; set; }

		public string Title { get; set; }

		public int id { get; set; }

		public int NatureId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			BuffIcon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			CardRecom = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			NatureId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
