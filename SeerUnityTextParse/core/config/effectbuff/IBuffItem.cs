namespace core.config.effectbuff
{
	public class IBuffItem
	{
		public string Desc { get; set; }

		public string Name { get; set; }

		public int ID { get; set; }

		public int Kind { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Kind = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
