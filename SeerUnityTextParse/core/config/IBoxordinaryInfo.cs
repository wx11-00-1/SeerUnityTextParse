namespace core.config
{
	public class IBoxordinaryInfo : IConfigItem
	{
		public string tips { get; set; }

		public int id { get; set; }

		public int itemid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
