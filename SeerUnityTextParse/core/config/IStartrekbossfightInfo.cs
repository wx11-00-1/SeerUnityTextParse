namespace core.config
{
	public class IStartrekbossfightInfo : IConfigItem
	{
		public int[] MonsterIds { get; set; }

		public int[] rewardinfo { get; set; }

		public int BossfightId { get; set; }

		public int BossType { get; set; }

		public int id { get; set; }

		public int WinRewardNum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			BossType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			BossfightId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				MonsterIds = new int[num];
				for (int i = 0; i < num; i++)
				{
					MonsterIds[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			WinRewardNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardinfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					rewardinfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
