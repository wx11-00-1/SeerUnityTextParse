namespace core.config
{
	public class SkillEffect : XlsConfigBase<SkillEffect, ISkillEffectInfo>
	{
		public override string fileName
		{
			get
			{
				return "skill_effect";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISkillEffectInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISkillEffectInfo();
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
