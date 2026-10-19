namespace core.config
{
	public class WarGameSkill : XlsConfigBase<WarGameSkill, IWarGameSkillInfo>
	{
		public override string fileName
		{
			get
			{
				return "warGame_Skill";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IWarGameSkillInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IWarGameSkillInfo();
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
