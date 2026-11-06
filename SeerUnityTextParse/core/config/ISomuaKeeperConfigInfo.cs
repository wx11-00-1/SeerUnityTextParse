namespace core.config
{
	public class ISomuaKeeperConfigInfo : IConfigItem
	{
		public string dangoTask { get; set; }

		public string describe1 { get; set; }

		public string describe2 { get; set; }

		public string describe3 { get; set; }

		public string reward { get; set; }

		public int benefit1 { get; set; }

		public int benefit2 { get; set; }

		public int benefit3 { get; set; }

		public int benefit4 { get; set; }

		public int benefit5 { get; set; }

		public int benefit6 { get; set; }

		public int benefit7 { get; set; }

		public int dangoGold { get; set; }

		public int id { get; set; }

		public int minorNum { get; set; }

		public int storeMax { get; set; }

		public int taskNum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			benefit1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			benefit2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			benefit3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			benefit4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			benefit5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			benefit6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			benefit7 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dangoGold = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dangoTask = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			describe1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			describe2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			describe3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			minorNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			storeMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			taskNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
