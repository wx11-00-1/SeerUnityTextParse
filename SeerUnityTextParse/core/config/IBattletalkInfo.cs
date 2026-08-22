namespace core.config
{
	public class IBattletalkInfo : IConfigItem
	{
		public string character { get; set; }

		public string head { get; set; }

		public string name { get; set; }

		public string text { get; set; }

		public int id { get; set; }

		public int place { get; set; }

		public int talkid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			character = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			head = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			place = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			talkid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
