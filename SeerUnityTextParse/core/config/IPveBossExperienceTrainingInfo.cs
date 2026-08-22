namespace core.config
{
	public class IPveBossExperienceTrainingInfo : IConfigItem
	{
		public string raidunlocktext { get; set; }

		public int[] bosslist { get; set; }

		public int[] rewardid { get; set; }

		public int[] rewardnum { get; set; }

		public int id { get; set; }

		public int raidunlockarg { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				bosslist = new int[num];
				for (int i = 0; i < num; i++)
				{
					bosslist[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			raidunlockarg = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			raidunlocktext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardid = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					rewardid[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				rewardnum = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					rewardnum[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
