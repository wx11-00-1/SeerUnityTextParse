namespace core.config
{
	public class ISomuaEntryConfigInfo : IConfigItem
	{
		public string desc { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int rarity { get; set; }

		public int type { get; set; }

		public int value1 { get; set; }

		public int value2 { get; set; }

		public int value3 { get; set; }

		public int value4 { get; set; }

		public int value5 { get; set; }

		public int value6 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
