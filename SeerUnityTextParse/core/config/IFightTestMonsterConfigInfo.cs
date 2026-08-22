namespace core.config
{
	public class IFightTestMonsterConfigInfo : IConfigItem
	{
		public int[] baseData { get; set; }

		public int[] extraData { get; set; }

		public int[] mintmark { get; set; }

		public int[] mintmarkData { get; set; }

		public int[] monsterLearning { get; set; }

		public int[] monsterMove { get; set; }

		public int id { get; set; }

		public int monsterCharacter { get; set; }

		public int monsterEffect_id { get; set; }

		public int monsterId { get; set; }

		public int monsterLv { get; set; }

		public int monsterNature { get; set; }

		public int monsterStrength { get; set; }

		public int monsterTalent { get; set; }

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
				mintmark = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					mintmark[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				mintmarkData = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					mintmarkData[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			monsterCharacter = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterEffect_id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				monsterLearning = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					monsterLearning[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			monsterLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				monsterMove = new int[num6];
				for (int n = 0; n < num6; n++)
				{
					monsterMove[n] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			monsterNature = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterStrength = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterTalent = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
