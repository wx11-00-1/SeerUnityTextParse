namespace core.config
{
	public class ISkillEffectInfo : IConfigItem
	{
		public string formattingAdjustment { get; set; }

		public string ifTextItalic { get; set; }

		public string info { get; set; }

		public string tagA { get; set; }

		public string tagB { get; set; }

		public string tagC { get; set; }

		public int argsNum { get; set; }

		public int Bosseffective { get; set; }

		public int id { get; set; }

		public int isif { get; set; }

		public int tagAboss { get; set; }

		public int tagBboss { get; set; }

		public int tagCboss { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Bosseffective = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			argsNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			formattingAdjustment = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ifTextItalic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			info = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			isif = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tagA = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tagAboss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tagB = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tagBboss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tagC = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tagCboss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
