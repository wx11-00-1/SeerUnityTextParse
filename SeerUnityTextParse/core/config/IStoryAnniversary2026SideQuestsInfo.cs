namespace core.config
{
	public class IStoryAnniversary2026SideQuestsInfo : IConfigItem
	{
		public string answer { get; set; }

		public string deal { get; set; }

		public string msg { get; set; }

		public string npcId { get; set; }

		public string npcname { get; set; }

		public int end { get; set; }

		public int groupId { get; set; }

		public int id { get; set; }

		public int sidequestId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			answer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			deal = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			end = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			groupId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			npcId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			npcname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sidequestId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
