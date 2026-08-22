namespace core.config
{
	public class IFightTestStageConfigInfo : IConfigItem
	{
		public string bossIntro { get; set; }

		public int[] fightBossIndexes { get; set; }

		public int[] fightMonsterIndexs { get; set; }

		public int[] firstReward { get; set; }

		public int[] reward { get; set; }

		public int equip { get; set; }

		public int id { get; set; }

		public int NeedMonNum { get; set; }

		public int order { get; set; }

		public int StageType { get; set; }

		public int title { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			NeedMonNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			StageType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bossIntro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			equip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				fightBossIndexes = new int[num];
				for (int i = 0; i < num; i++)
				{
					fightBossIndexes[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				fightMonsterIndexs = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					fightMonsterIndexs[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				firstReward = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					firstReward[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					reward[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			title = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
