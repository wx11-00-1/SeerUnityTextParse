namespace core.config
{
	public class IDangoGoldInfo : IConfigItem
	{
		public int dangoGold { get; set; }

		public int dangoNumMax { get; set; }

		public int dangoNumMix { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			dangoGold = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dangoNumMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dangoNumMix = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
