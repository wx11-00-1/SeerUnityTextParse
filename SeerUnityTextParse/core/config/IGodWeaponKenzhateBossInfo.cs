namespace core.config
{
	public class IGodWeaponKenzhateBossInfo : IConfigItem
	{
		public string parm1 { get; set; }

		public string parm2 { get; set; }

		public int id { get; set; }

		public int petid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			parm1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			parm2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
