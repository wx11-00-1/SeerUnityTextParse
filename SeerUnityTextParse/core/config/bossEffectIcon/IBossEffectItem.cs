namespace core.config.bossEffectIcon
{
	public class IBossEffectItem
	{
		public string Args { get; set; }

		public string tips { get; set; }

		public int Eid { get; set; }

		public int iconId { get; set; }

		public int rows { get; set; }

		public int sort { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Args = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Eid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			iconId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rows = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
