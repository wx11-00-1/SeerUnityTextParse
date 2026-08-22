namespace core.config
{
	public class IBagTowerStageWaveInfo : IConfigItem
	{
		public string opengrid { get; set; }

		public string weight1 { get; set; }

		public string weight2 { get; set; }

		public string weight3 { get; set; }

		public int getreward { get; set; }

		public int id { get; set; }

		public int loop { get; set; }

		public int refresh { get; set; }

		public int reward1 { get; set; }

		public int reward2 { get; set; }

		public int stage { get; set; }

		public int wave { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			getreward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			loop = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opengrid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			refresh = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stage = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wave = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			weight1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			weight2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			weight3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
