namespace core.config
{
	public class IChessGameStageInfo : IConfigItem
	{
		public string group1 { get; set; }

		public string group2 { get; set; }

		public string group3 { get; set; }

		public string rewardrange1 { get; set; }

		public string scope { get; set; }

		public int cardnum { get; set; }

		public int chapter { get; set; }

		public int equipnum { get; set; }

		public int id { get; set; }

		public int rewardrange2 { get; set; }

		public int stagetype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			cardnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			chapter = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			equipnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			group1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			group2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			group3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardrange1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardrange2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			scope = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stagetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
