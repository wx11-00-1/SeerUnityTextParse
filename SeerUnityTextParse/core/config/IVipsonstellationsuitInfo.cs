namespace core.config
{
	public class IVipsonstellationsuitInfo : IConfigItem
	{
		public string TagName { get; set; }

		public int id { get; set; }

		public int Suitid { get; set; }

		public int TagType { get; set; }

		public int UserInfoId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Suitid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			TagName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			TagType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UserInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
