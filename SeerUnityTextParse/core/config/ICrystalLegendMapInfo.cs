namespace core.config
{
	public class ICrystalLegendMapInfo : IConfigItem
	{
		public string model1 { get; set; }

		public string model2 { get; set; }

		public string model3 { get; set; }

		public string model4 { get; set; }

		public string model5 { get; set; }

		public string model6 { get; set; }

		public string nextID { get; set; }

		public int id { get; set; }

		public int isStart { get; set; }

		public int roomID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isStart = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			model1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			model2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			model3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			model4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			model5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			model6 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			nextID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			roomID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
