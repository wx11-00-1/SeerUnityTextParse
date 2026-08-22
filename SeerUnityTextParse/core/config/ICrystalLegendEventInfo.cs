namespace core.config
{
	public class ICrystalLegendEventInfo : IConfigItem
	{
		public string answerTxt1 { get; set; }

		public string answerTxt2 { get; set; }

		public string answerTxt3 { get; set; }

		public string eventTxt { get; set; }

		public string picName { get; set; }

		public int id { get; set; }

		public int limitNum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			answerTxt1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			answerTxt2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			answerTxt3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			eventTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limitNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			picName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
