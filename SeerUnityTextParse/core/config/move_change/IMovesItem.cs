namespace core.config.move_change
{
	public class IMovesItem
	{
		public string moveName1 { get; set; }

		public string moveName2 { get; set; }

		public string NewName { get; set; }

		public int MoveID { get; set; }

		public int SkinID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			MoveID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			SkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			moveName1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			moveName2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
