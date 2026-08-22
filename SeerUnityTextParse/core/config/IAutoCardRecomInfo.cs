namespace core.config
{
	public class IAutoCardRecomInfo : IConfigItem
	{
		public string MaCardID { get; set; }

		public string petCardId { get; set; }

		public string title { get; set; }

		public int classId { get; set; }

		public int id { get; set; }

		public int petBG { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MaCardID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			classId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petBG = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petCardId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
