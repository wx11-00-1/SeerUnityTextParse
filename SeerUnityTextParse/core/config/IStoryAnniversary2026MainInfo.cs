namespace core.config
{
	public class IStoryAnniversary2026MainInfo : IConfigItem
	{
		public string field { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int linkID { get; set; }

		public int title { get; set; }

		public int type { get; set; }

		public int unlock { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			field = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			linkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			title = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
