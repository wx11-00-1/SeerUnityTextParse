namespace core.config
{
	public class IPrivateCostDiamondRewardInfo : IConfigItem
	{
		public string reward { get; set; }

		public int id { get; set; }

		public int step { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			step = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
