namespace core.config
{
	public class IAutocardChipInfo : IConfigItem
	{
		public string chipTxt { get; set; }

		public string name { get; set; }

		public string type { get; set; }

		public int id { get; set; }

		public int label { get; set; }

		public int level { get; set; }

		public int picID { get; set; }

		public int seriesId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			chipTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			label = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			picID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			seriesId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
