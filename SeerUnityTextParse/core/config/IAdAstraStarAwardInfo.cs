namespace core.config
{
	public class IAdAstraStarAwardInfo : IConfigItem
	{
		public string progressAward { get; set; }

		public int id { get; set; }

		public int progress { get; set; }

		public int star { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			progress = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			progressAward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			star = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
