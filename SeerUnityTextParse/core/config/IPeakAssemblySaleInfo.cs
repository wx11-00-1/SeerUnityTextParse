namespace core.config
{
	public class IPeakAssemblySaleInfo : IConfigItem
	{
		public int ExtraMovesID { get; set; }

		public int id { get; set; }

		public int IsSell { get; set; }

		public int MintmarkID { get; set; }

		public int MonsterID { get; set; }

		public int Month { get; set; }

		public int NewSeID { get; set; }

		public int NewStatLog1 { get; set; }

		public int NewStatLog2 { get; set; }

		public int NewStatLog3 { get; set; }

		public int SkinID { get; set; }

		public int Year { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ExtraMovesID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			IsSell = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Month = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewSeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewStatLog1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewStatLog2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			NewStatLog3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			SkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Year = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
