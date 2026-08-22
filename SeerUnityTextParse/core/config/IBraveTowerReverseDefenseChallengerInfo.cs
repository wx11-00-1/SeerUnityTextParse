namespace core.config
{
	public class IBraveTowerReverseDefenseChallengerInfo : IConfigItem
	{
		public string name { get; set; }

		public int battlevalue1 { get; set; }

		public int battlevalue2 { get; set; }

		public int battlevalue3 { get; set; }

		public int id { get; set; }

		public int monsterid1 { get; set; }

		public int monsterid2 { get; set; }

		public int monsterid3 { get; set; }

		public int suitid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			battlevalue1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			battlevalue2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			battlevalue3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterid1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterid2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterid3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			suitid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
