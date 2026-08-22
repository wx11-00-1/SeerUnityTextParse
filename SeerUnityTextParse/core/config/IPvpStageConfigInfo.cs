namespace core.config
{
	public class IPvpStageConfigInfo : IConfigItem
	{
		public string bossIntro { get; set; }

		public string firstReward { get; set; }

		public string monsterName { get; set; }

		public int[] fightMonsterIndexs { get; set; }

		public int id { get; set; }

		public int index { get; set; }

		public int monsterId { get; set; }

		public int order { get; set; }

		public int UserInfoID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			UserInfoID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bossIntro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				fightMonsterIndexs = new int[num];
				for (int i = 0; i < num; i++)
				{
					fightMonsterIndexs[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			firstReward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			index = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
