namespace core.config.petbook_bisaifu
{
	public class IPetDataItem : IConfigItem
	{
		public int[] TagB { get; set; }

		public int id { get; set; }

		public int pid { get; set; }

		public int TagA { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			TagA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				TagB = new int[num];
				for (int i = 0; i < num; i++)
				{
					TagB[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			pid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
