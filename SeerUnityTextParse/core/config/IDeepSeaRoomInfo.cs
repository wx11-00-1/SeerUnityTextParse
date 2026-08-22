namespace core.config
{
	public class IDeepSeaRoomInfo : IConfigItem
	{
		public string bgPic { get; set; }

		public string item { get; set; }

		public int id { get; set; }

		public int mapid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bgPic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			item = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			mapid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
