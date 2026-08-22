namespace core.config
{
	public class IBorucaStrategyInfo : IConfigItem
	{
		public string role { get; set; }

		public string situation { get; set; }

		public string title { get; set; }

		public int id { get; set; }

		public int place { get; set; }

		public int sotryid { get; set; }

		public int time { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			place = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			role = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			situation = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sotryid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
