namespace core.config
{
	public class IArchivesStoryTempInfo : IConfigItem
	{
		public string classname { get; set; }

		public string monname { get; set; }

		public string txt { get; set; }

		public int[] samemonid { get; set; }

		public int classid { get; set; }

		public int id { get; set; }

		public int isrec { get; set; }

		public int monid { get; set; }

		public int storyid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			classid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			classname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isrec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				samemonid = new int[num];
				for (int i = 0; i < num; i++)
				{
					samemonid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			storyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			txt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
