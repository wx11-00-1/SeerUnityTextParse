namespace core.config.PetFightSkinSkillReplace
{
	public class IItemItem
	{
		public ISkill skill { get; set; }

		public int petid { get; set; }

		public int skinid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				skill = new ISkill();
				skill.Parse(bytes, ref byteIndex);
			}
			skinid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
