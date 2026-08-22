namespace core.config
{
	public class IStoryAnniversary2026ChatTalkInfo : IConfigItem
	{
		public string answer { get; set; }

		public string deal { get; set; }

		public string msg { get; set; }

		public int chatId { get; set; }

		public int end { get; set; }

		public int groupId { get; set; }

		public int id { get; set; }

		public int linkNpc { get; set; }

		public int talker { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			answer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			chatId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			deal = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			end = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			groupId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			linkNpc = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			talker = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
