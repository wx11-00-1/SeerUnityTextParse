namespace core.config
{
	public class ISecurityCheckPersonInfo : IConfigItem
	{
		public string name { get; set; }

		public string word { get; set; }

		public int id { get; set; }

		public int petid { get; set; }

		public int petnum { get; set; }

		public int wrongid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			word = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			wrongid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
