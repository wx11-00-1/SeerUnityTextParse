namespace core.config
{
	public class IFightLabLevelConfigInfo : IConfigItem
	{
		public string bossIntro { get; set; }

		public string firstRewardTxt { get; set; }

		public string monsterName { get; set; }

		public string rewardTxt { get; set; }

		public int[] firstReward { get; set; }

		public int[] reward { get; set; }

		public int id { get; set; }

		public int monsterId { get; set; }

		public int order { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			bossIntro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				firstReward = new int[num];
				for (int i = 0; i < num; i++)
				{
					firstReward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			firstRewardTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				reward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					reward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			rewardTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
