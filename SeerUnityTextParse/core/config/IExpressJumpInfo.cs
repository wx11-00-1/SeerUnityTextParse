namespace core.config
{
	public class IExpressJumpInfo : IConfigItem
	{
		public string dest { get; set; }

		public string image { get; set; }

		public string name { get; set; }

		public string statlog { get; set; }

		public int clickLock { get; set; }

		public int closeother { get; set; }

		public int id { get; set; }

		public int iosLock { get; set; }

		public int priority { get; set; }

		public int reddotid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			clickLock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			closeother = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			dest = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			iosLock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reddotid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			statlog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
