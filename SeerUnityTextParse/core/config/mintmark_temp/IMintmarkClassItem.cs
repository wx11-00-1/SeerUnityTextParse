namespace core.config.mintmark_temp
{
	public class IMintmarkClassItem
	{
		public string ClassName { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ClassName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
