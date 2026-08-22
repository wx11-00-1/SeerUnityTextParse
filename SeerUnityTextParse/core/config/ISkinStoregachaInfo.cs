namespace core.config
{
	public class ISkinStoregachaInfo : IConfigItem
	{
		public string Des { get; set; }

		public string Name { get; set; }

		public int DiamondPrice { get; set; }

		public int id { get; set; }

		public int item_id { get; set; }

		public int MonID { get; set; }

		public int ProductId { get; set; }

		public int SkinID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			DiamondPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ProductId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			item_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
