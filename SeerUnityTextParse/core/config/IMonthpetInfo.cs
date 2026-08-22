namespace core.config
{
	public class IMonthpetInfo : IConfigItem
	{
		public string title { get; set; }

		public int id { get; set; }

		public int month { get; set; }

		public int reward { get; set; }

		public int showpet { get; set; }

		public int showskill { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			month = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			showpet = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			showskill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
