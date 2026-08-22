namespace core.config
{
	public class IConnectLinesGameInfo : IConfigItem
	{
		public string monster { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int opentime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
