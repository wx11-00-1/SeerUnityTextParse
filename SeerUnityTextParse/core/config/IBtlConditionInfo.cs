namespace core.config
{
	public class IBtlConditionInfo : IConfigItem
	{
		public string btldesc { get; set; }

		public int baseconid { get; set; }

		public int id { get; set; }

		public int sendNumber { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			baseconid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			btldesc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sendNumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
