namespace core.config
{
	public class ISomuaGeneConfigInfo : IConfigItem
	{
		public string gene { get; set; }

		public string skinbaby { get; set; }

		public string skinteen { get; set; }

		public int foodid { get; set; }

		public int id { get; set; }

		public int rarity { get; set; }

		public int shopID { get; set; }

		public int sort { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			foodid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			gene = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			shopID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skinbaby = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skinteen = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
