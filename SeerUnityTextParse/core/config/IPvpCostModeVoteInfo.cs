namespace core.config
{
	public class IPvpCostModeVoteInfo : IConfigItem
	{
		public string officialsetpet { get; set; }

		public string previousresultpet { get; set; }

		public string votepet { get; set; }

		public int adjust { get; set; }

		public int id { get; set; }

		public int previousresultshowtime { get; set; }

		public int ranklimit1 { get; set; }

		public int ranklimit2 { get; set; }

		public int subkey { get; set; }

		public int time1 { get; set; }

		public int time2 { get; set; }

		public int time3 { get; set; }

		public int type { get; set; }

		public int votenumber { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			adjust = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			officialsetpet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			previousresultpet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			previousresultshowtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ranklimit1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ranklimit2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			subkey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			votenumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			votepet = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
