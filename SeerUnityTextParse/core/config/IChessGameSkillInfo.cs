namespace core.config
{
	public class IChessGameSkillInfo : IConfigItem
	{
		public string condition { get; set; }

		public string mark { get; set; }

		public string skillact { get; set; }

		public string skillcarton { get; set; }

		public string skilldesc { get; set; }

		public string skilleffect { get; set; }

		public string skillicon { get; set; }

		public string skillname { get; set; }

		public string skillsound { get; set; }

		public int id { get; set; }

		public int skilltype { get; set; }

		public int takerange { get; set; }

		public int takerangetype { get; set; }

		public int userangelength { get; set; }

		public int userangetype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			condition = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			mark = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skillact = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skillcarton = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skilldesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skilleffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skillicon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skillname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skillsound = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skilltype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			takerange = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			takerangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userangelength = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userangetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
