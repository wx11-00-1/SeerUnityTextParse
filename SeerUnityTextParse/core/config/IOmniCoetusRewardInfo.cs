namespace core.config
{
	public class IOmniCoetusRewardInfo : IConfigItem
	{
		public string reward { get; set; }

		public int exp { get; set; }

		public int id { get; set; }

		public int stat { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
