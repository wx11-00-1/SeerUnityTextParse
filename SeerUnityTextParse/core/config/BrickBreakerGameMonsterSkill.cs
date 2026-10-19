namespace core.config
{
	public class BrickBreakerGameMonsterSkill : XlsConfigBase<BrickBreakerGameMonsterSkill, IBrickBreakerGameMonsterSkillInfo>
	{
		public override string fileName
		{
			get
			{
				return "brickBreakerGameMonsterSkill";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBrickBreakerGameMonsterSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBrickBreakerGameMonsterSkillInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
