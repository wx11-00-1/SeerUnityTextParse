namespace core.config.pet_advance
{
	public class IAdvEffect
	{
		public string Des { get; set; }

		public int Id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
