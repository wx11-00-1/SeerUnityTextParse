namespace core.config
{
	public class IFurnitureInfo : IConfigItem
	{
		public string funcParam { get; set; }

		public string name { get; set; }

		public int func { get; set; }

		public int funcIdentity { get; set; }

		public int id { get; set; }

		public int type { get; set; }

		public int vipOnly { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			func = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			funcIdentity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			funcParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			vipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
