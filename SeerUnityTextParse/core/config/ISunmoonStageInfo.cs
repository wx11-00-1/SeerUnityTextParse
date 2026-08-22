namespace core.config
{
	public class ISunmoonStageInfo : IConfigItem
	{
		public string career { get; set; }

		public string openx { get; set; }

		public int id { get; set; }

		public int initial { get; set; }

		public int stageid { get; set; }

		public int stagetype { get; set; }

		public int times { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			career = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			initial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			openx = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stagetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			times = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
