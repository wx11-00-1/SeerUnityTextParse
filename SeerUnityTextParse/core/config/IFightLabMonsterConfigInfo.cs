namespace core.config
{
	public class IFightLabMonsterConfigInfo : IConfigItem
	{
		public string monsterIntro { get; set; }

		public int[] monsterData { get; set; }

		public int[] monsterMove { get; set; }

		public int id { get; set; }

		public int monsterId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				monsterData = new int[num];
				for (int i = 0; i < num; i++)
				{
					monsterData[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterIntro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				monsterMove = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					monsterMove[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
