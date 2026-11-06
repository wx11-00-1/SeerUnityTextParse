namespace core.config
{
	public class ISomuaDispatchConfigInfo : IConfigItem
	{
		public string award { get; set; }

		public string bonus1 { get; set; }

		public string bonus2 { get; set; }

		public string bonus3 { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int tasktype { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			award = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bonus1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bonus2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bonus3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
