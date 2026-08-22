namespace core.config
{
	public class IAurumEndgameStageConfigInfo : IConfigItem
	{
		public string name { get; set; }

		public int[] elite1 { get; set; }

		public int[] elite2 { get; set; }

		public int[] enemy1 { get; set; }

		public int[] enemy2 { get; set; }

		public int[] enemy3 { get; set; }

		public int atkRatio { get; set; }

		public int boss { get; set; }

		public int bossCoef { get; set; }

		public int elite1Coef { get; set; }

		public int elite2Coef { get; set; }

		public int hpIncr { get; set; }

		public int hpRatio { get; set; }

		public int id { get; set; }

		public int modId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			atkRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			boss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bossCoef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				elite1 = new int[num];
				for (int i = 0; i < num; i++)
				{
					elite1[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			elite1Coef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				elite2 = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					elite2[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			elite2Coef = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				enemy1 = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					enemy1[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				enemy2 = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					enemy2[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				enemy3 = new int[num5];
				for (int m = 0; m < num5; m++)
				{
					enemy3[m] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			hpIncr = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			hpRatio = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			modId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
