namespace core.config
{
	public class ICrystalLegendStateInfo : IConfigItem
	{
		public string battleDes { get; set; }

		public string des { get; set; }

		public string name { get; set; }

		public int iconID { get; set; }

		public int id { get; set; }

		public int isApproved { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			battleDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			iconID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isApproved = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
