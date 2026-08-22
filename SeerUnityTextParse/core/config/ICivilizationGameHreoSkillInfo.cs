namespace core.config
{
	public class ICivilizationGameHreoSkillInfo : IConfigItem
	{
		public string consume { get; set; }

		public string describe { get; set; }

		public string effective { get; set; }

		public string herodescribe { get; set; }

		public string herodescribeafter { get; set; }

		public string herodescribefront { get; set; }

		public string name { get; set; }

		public string range { get; set; }

		public long closetime4 { get; set; }

		public int closetime1 { get; set; }

		public int closetime2 { get; set; }

		public int closetime3 { get; set; }

		public int heropicture { get; set; }

		public int icontype { get; set; }

		public int id { get; set; }

		public int opentime1 { get; set; }

		public int opentime2 { get; set; }

		public int opentime3 { get; set; }

		public int opentime4 { get; set; }

		public int skillcd { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			closetime1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			closetime2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			closetime3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			closetime4 = ByteUtil.ReadLong(bytes, ref byteIndex);
			consume = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			effective = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			herodescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			herodescribeafter = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			herodescribefront = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			heropicture = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icontype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			opentime1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opentime2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opentime3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opentime4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			range = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skillcd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
