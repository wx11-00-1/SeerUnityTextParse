namespace core.config
{
	public class IWarGameBuffInfo : IConfigItem
	{
		public string describe { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
