namespace core.config
{
	public class ICrystalLegendTalentInfo : IConfigItem
	{
		public string des { get; set; }

		public string name { get; set; }

		public int consumeNum { get; set; }

		public int frontID { get; set; }

		public int iconID { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			consumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			frontID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			iconID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
