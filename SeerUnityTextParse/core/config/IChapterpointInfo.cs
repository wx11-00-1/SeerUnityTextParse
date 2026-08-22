namespace core.config
{
	public class IChapterpointInfo : IConfigItem
	{
		public string img { get; set; }

		public string intro { get; set; }

		public string item { get; set; }

		public string linunlock1 { get; set; }

		public string linunlock2 { get; set; }

		public string name { get; set; }

		public string NewMsglogId { get; set; }

		public string title { get; set; }

		public int bossid { get; set; }

		public int chapterid { get; set; }

		public int connect { get; set; }

		public int id { get; set; }

		public int line { get; set; }

		public int next { get; set; }

		public int open { get; set; }

		public int order { get; set; }

		public int position { get; set; }

		public int previous { get; set; }

		public int stagetype { get; set; }

		public int storyafter { get; set; }

		public int storybefore { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			NewMsglogId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			bossid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			connect = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			img = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			item = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			line = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			linunlock1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			linunlock2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			open = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			position = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			previous = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stagetype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			storyafter = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			storybefore = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
