namespace core.config.Monsterpool
{
	public class IItemItem
	{
		public string monstername { get; set; }

		public int isjustone { get; set; }

		public int kind { get; set; }

		public int monsterid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			isjustone = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			kind = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monstername = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
