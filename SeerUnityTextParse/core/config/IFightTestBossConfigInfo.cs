namespace core.config
{
	public class IFightTestBossConfigInfo : IConfigItem
	{
		public int[] baseData { get; set; }

		public int[] extraData { get; set; }

		public int[] mintmarkData { get; set; }

		public int[] monsterMove { get; set; }

		public int id { get; set; }

		public int monsterEffect_id { get; set; }

		public int monsterId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				baseData = new int[num];
				for (int i = 0; i < num; i++)
				{
					baseData[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				extraData = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					extraData[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				mintmarkData = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					mintmarkData[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			monsterEffect_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				monsterMove = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					monsterMove[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
