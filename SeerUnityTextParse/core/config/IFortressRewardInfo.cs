namespace core.config
{
	public class IFortressRewardInfo : IConfigItem
	{
		public int[] reward { get; set; }

		public int endRank { get; set; }

		public int id { get; set; }

		public int startRank { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			endRank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num];
				for (int i = 0; i < num; i++)
				{
					reward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			startRank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
