namespace core.config
{
	public class IYearPetTrain2025Info : IConfigItem
	{
		public string battlecond { get; set; }

		public string bossid { get; set; }

		public string prizedes { get; set; }

		public string prizedetail { get; set; }

		public int id { get; set; }

		public int storyid { get; set; }

		public int time { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			battlecond = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bossid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			prizedes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			prizedetail = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			storyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
