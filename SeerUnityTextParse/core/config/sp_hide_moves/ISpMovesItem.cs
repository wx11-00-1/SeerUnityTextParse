namespace core.config.sp_hide_moves
{
	public class ISpMovesItem : IConfigItem
	{
		public string itemname { get; set; }

		public string movesname { get; set; }

		public int id { get; set; }

		public int item { get; set; }

		public int itemnumber { get; set; }

		public int monster { get; set; }

		public int moves { get; set; }

		public int movetype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			item = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			itemnumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			moves = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			movesname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			movetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
