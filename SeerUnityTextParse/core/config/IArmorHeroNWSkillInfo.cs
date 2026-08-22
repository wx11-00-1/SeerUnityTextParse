namespace core.config
{
	public class IArmorHeroNWSkillInfo : IConfigItem
	{
		public string des { get; set; }

		public int end { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int num { get; set; }

		public int start { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			end = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			start = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
