namespace core.config
{
	public class IMiniGameInfo : IConfigItem
	{
		public string path { get; set; }

		public int[] child { get; set; }

		public int health { get; set; }

		public int id { get; set; }

		public int realId { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				child = new int[num];
				for (int i = 0; i < num; i++)
				{
					child[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			health = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			path = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			realId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
