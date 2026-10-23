namespace core.config
{
	public class IAutocardHappyActivityInfo : IConfigItem
	{
		public string rewardinfo { get; set; }

		public string Rro { get; set; }

		public int id { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Rro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
