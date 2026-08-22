namespace core.config
{
	public class IAutoCardVideoInfo : IConfigItem
	{
		public string Video { get; set; }

		public string videoDes { get; set; }

		public string videoType { get; set; }

		public int id { get; set; }

		public int playerId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Video = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			playerId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			videoDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			videoType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
