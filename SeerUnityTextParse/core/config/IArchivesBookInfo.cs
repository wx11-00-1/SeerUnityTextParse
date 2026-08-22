namespace core.config
{
	public class IArchivesBookInfo : IConfigItem
	{
		public string chaptername { get; set; }

		public string[] txt { get; set; }

		public int[] txtdivide { get; set; }

		public int bookid { get; set; }

		public int chapterid { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bookid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			chaptername = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				txt = new string[num];
				for (int i = 0; i < num; i++)
				{
					txt[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				txtdivide = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					txtdivide[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
