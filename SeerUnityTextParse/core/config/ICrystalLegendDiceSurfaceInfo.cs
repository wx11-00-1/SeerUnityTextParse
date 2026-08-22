namespace core.config
{
	public class ICrystalLegendDiceSurfaceInfo : IConfigItem
	{
		public string des { get; set; }

		public string name { get; set; }

		public int iconID { get; set; }

		public int id { get; set; }

		public int paramType { get; set; }

		public int relateStateID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			iconID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			paramType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			relateStateID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
