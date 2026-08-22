namespace core.config
{
	public class IYear2025StgMainInfo : IConfigItem
	{
		public string bossMessages { get; set; }

		public string skills { get; set; }

		public int[] args { get; set; }

		public int[] bossSkillSpeed { get; set; }

		public int[] playerSkills { get; set; }

		public int bossSpeed { get; set; }

		public int bossState { get; set; }

		public int finishCondition { get; set; }

		public int health { get; set; }

		public int id { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				args = new int[num];
				for (int i = 0; i < num; i++)
				{
					args[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			bossMessages = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				bossSkillSpeed = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					bossSkillSpeed[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			bossSpeed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			bossState = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			finishCondition = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			health = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				playerSkills = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					playerSkills[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			skills = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
