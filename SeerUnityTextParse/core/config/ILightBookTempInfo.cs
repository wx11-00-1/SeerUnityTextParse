namespace core.config
{
	public class ILightBookTempInfo : IConfigItem
	{
		public string coinid { get; set; }

		public string monsterID { get; set; }

		public string needmonID { get; set; }

		public string price { get; set; }

		public int id { get; set; }

		public int newest { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			coinid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			needmonID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			newest = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
