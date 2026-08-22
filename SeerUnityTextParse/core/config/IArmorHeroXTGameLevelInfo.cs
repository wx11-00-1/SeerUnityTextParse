namespace core.config
{
	public class IArmorHeroXTGameLevelInfo : IConfigItem
	{
		public string monster { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int num { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
