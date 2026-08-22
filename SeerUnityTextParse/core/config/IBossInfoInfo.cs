namespace core.config
{
	public class IBossInfoInfo : IConfigItem
	{
		public string move { get; set; }

		public string se { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int petID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			move = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			petID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			se = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
