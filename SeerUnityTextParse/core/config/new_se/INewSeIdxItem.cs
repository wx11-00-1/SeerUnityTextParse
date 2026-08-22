namespace core.config.new_se
{
	public class INewSeIdxItem
	{
		public string Args { get; set; }

		public string Des { get; set; }

		public string Desc { get; set; }

		public string Intro { get; set; }

		public int AdditionNum { get; set; }

		public int AdditionType { get; set; }

		public int Eid { get; set; }

		public int Idx { get; set; }

		public int ItemId { get; set; }

		public int StarLevel { get; set; }

		public int Stat { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			AdditionNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			AdditionType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Args = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Eid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Idx = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			ItemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			StarLevel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Stat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
