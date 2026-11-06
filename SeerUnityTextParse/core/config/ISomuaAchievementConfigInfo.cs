namespace core.config
{
	public class ISomuaAchievementConfigInfo : IConfigItem
	{
		public string desc { get; set; }

		public string name { get; set; }

		public int condition { get; set; }

		public int icon { get; set; }

		public int id { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			condition = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
