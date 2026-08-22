namespace core.config
{
	public class ICrystalLegendUpdateTxtInfo : IConfigItem
	{
		public string mainTitle { get; set; }

		public string subTxt { get; set; }

		public int id { get; set; }

		public int updateID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			mainTitle = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			subTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			updateID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
