namespace core.config
{
	public class ArmorHeroNWSkill : XlsConfigBase<ArmorHeroNWSkill, IArmorHeroNWSkillInfo>
	{
		public override string fileName
		{
			get
			{
				return "armorHeroNWSkill";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IArmorHeroNWSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IArmorHeroNWSkillInfo();
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
