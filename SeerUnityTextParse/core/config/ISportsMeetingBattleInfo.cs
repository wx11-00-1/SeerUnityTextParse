namespace core.config
{
	public class ISportsMeetingBattleInfo : IConfigItem
	{
		public string battelattack { get; set; }

		public string battelhp { get; set; }

		public string icon { get; set; }

		public string name { get; set; }

		public int attackup { get; set; }

		public int hpup { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			attackup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			battelattack = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			battelhp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			hpup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
