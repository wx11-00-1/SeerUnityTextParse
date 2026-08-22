namespace core.config
{
	public class IAutocardSessionInfo : IConfigItem
	{
		public string reward1 { get; set; }

		public string reward2 { get; set; }

		public string reward3 { get; set; }

		public string reward4 { get; set; }

		public string reward5 { get; set; }

		public string reward6 { get; set; }

		public string reward7 { get; set; }

		public string reward8 { get; set; }

		public string reward9 { get; set; }

		public string rewardtrip { get; set; }

		public string sessionReward { get; set; }

		public string stat { get; set; }

		public int cositemid { get; set; }

		public int cosNum { get; set; }

		public int forever { get; set; }

		public int id { get; set; }

		public int Index_idmax { get; set; }

		public int Index_idmin { get; set; }

		public int Value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Index_idmax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Index_idmin = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cosNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cositemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			forever = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward6 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward7 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward8 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward9 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rewardtrip = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sessionReward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stat = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
