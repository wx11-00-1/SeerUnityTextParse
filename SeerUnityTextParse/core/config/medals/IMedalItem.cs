namespace core.config.medals
{
	public class IMedalItem : IConfigItem
	{
		public string title { get; set; }

		public int achievepoint { get; set; }

		public int award { get; set; }

		public int hide { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			achievepoint = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			award = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
