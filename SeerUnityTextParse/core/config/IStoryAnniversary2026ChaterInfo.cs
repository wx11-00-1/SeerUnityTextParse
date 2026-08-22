namespace core.config
{
	public class IStoryAnniversary2026ChaterInfo : IConfigItem
	{
		public string half { get; set; }

		public string head { get; set; }

		public string nickname { get; set; }

		public string signature { get; set; }

		public string trueName { get; set; }

		public int id { get; set; }

		public int userinfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			half = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			head = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			nickname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			signature = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			trueName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
