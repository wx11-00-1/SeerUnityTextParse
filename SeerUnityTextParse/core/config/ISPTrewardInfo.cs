namespace core.config
{
	public class ISPTrewardInfo : IConfigItem
	{
		public int[] rewardcnt { get; set; }

		public int[] rewardid { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardcnt = new int[num];
				for (int i = 0; i < num; i++)
				{
					rewardcnt[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardid = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					rewardid[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
