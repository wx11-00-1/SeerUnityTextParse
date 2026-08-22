namespace core.config.typesRelation
{
	public class IOpponentItem
	{
		public string type { get; set; }

		public float multiple { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			multiple = ByteUtil.ReadFloat(bytes, ref byteIndex);
			type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
