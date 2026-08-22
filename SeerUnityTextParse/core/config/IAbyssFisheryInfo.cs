namespace core.config
{
	public class IAbyssFisheryInfo : IConfigItem
	{
		public string des { get; set; }

		public string name { get; set; }

		public int gameid { get; set; }

		public int id { get; set; }

		public int rare { get; set; }

		public int scale { get; set; }

		public int showtype { get; set; }

		public int star { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			gameid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			scale = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			showtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			star = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
