namespace core.config
{
	public class ISportsMeetingItemsInfo : IConfigItem
	{
		public string icon { get; set; }

		public string name { get; set; }

		public string skilldescribe { get; set; }

		public int id { get; set; }

		public int skill { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skilldescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
