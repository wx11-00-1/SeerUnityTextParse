namespace core.config
{
	public class NewMonsterLevelBisaifu : XlsConfigBase<NewMonsterLevelBisaifu, INewMonsterLevelBisaifuInfo>
	{
		public override string fileName
		{
			get
			{
				return "new_monster_level_bisaifu";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new INewMonsterLevelBisaifuInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new INewMonsterLevelBisaifuInfo();
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
