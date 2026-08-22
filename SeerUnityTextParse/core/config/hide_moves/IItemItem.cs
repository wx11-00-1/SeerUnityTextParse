namespace core.config.hide_moves
{
	public class IItemItem
	{
		public string moveName1 { get; set; }

		public string moveName2 { get; set; }

		public int moveId { get; set; }

		public int petId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			moveId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			moveName1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			moveName2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
