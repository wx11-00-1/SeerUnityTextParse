namespace core.config
{
	public class ILuckyrocketItemInfo : IConfigItem
	{
		public string describe { get; set; }

		public string name { get; set; }

		public int @class { get; set; }

		public int id { get; set; }

		public int itemicon { get; set; }

		public int output { get; set; }

		public int priority { get; set; }

		public int rare { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			@class = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemicon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			output = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
