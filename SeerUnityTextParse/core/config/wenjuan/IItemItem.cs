namespace core.config.wenjuan
{
	public class IItemItem
	{
		public string a { get; set; }

		public int dir { get; set; }

		public int wb { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			a = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			dir = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wb = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
