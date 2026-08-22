namespace core.config
{
	public class ILuckyrocketRareInfo : IConfigItem
	{
		public string equiprare { get; set; }

		public string itemrare { get; set; }

		public string requirement { get; set; }

		public string reward { get; set; }

		public int id { get; set; }

		public int isequip { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			equiprare = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isequip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemrare = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			requirement = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
