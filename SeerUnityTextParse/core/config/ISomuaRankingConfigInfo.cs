namespace core.config
{
	public class ISomuaRankingConfigInfo : IConfigItem
	{
		public string level { get; set; }

		public string minscore { get; set; }

		public string name { get; set; }

		public int icon { get; set; }

		public int id { get; set; }

		public int isFalling { get; set; }

		public int phase { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isFalling = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			minscore = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			phase = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
