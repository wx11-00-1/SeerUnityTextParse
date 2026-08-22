namespace core.config
{
	public class ILuckyrocketLevelInfo : IConfigItem
	{
		public string equip { get; set; }

		public int close { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int phase { get; set; }

		public float ratio { get; set; }

		public int requirement { get; set; }

		public int reward { get; set; }

		public int round { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			close = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			equip = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			phase = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ratio = ByteUtil.ReadFloat(bytes, ref byteIndex);
			requirement = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			round = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
