namespace core.config
{
	public class IElfGachaDetailsInfo : IConfigItem
	{
		public string itempro { get; set; }

		public int id { get; set; }

		public int item { get; set; }

		public int number { get; set; }

		public int poolid { get; set; }

		public int quality { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			item = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itempro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			number = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
