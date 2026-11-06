namespace core.config
{
	public class ISomuaToturialConfigInfo : IConfigItem
	{
		public string img { get; set; }

		public string module { get; set; }

		public string txt { get; set; }

		public int id { get; set; }

		public int page { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			img = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			module = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			page = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			txt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
