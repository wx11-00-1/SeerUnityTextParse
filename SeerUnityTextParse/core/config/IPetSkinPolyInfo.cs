namespace core.config
{
	public class IPetSkinPolyInfo : IConfigItem
	{
		public string replaceid { get; set; }

		public int id { get; set; }

		public int petid { get; set; }

		public int skinid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			replaceid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skinid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
