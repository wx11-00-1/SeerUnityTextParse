namespace core.config
{
	public class IBagTowerStageFightInfo : IConfigItem
	{
		public int[] monster { get; set; }

		public int[] position { get; set; }

		public int atkmonsterup { get; set; }

		public int delaytime { get; set; }

		public int exo { get; set; }

		public int hpmonsterup { get; set; }

		public int id { get; set; }

		public int isboss { get; set; }

		public int stage { get; set; }

		public int wave { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atkmonsterup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			delaytime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			exo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hpmonsterup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isboss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				monster = new int[num];
				for (int i = 0; i < num; i++)
				{
					monster[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				position = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					position[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			stage = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			wave = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
