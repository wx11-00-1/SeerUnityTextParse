namespace core.config
{
	public class IBraveTowerReverseDefenseMonsterInfo : IConfigItem
	{
		public string name { get; set; }

		public int battlevalue { get; set; }

		public int id { get; set; }

		public int monsterid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			battlevalue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
