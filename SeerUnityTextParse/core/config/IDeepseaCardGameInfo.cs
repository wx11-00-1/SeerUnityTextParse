namespace core.config
{
	public class IDeepseaCardGameInfo : IConfigItem
	{
		public string levelname { get; set; }

		public string reward { get; set; }

		public int bosshp { get; set; }

		public int id { get; set; }

		public int opentime { get; set; }

		public int playerhp { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bosshp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			levelname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			playerhp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
