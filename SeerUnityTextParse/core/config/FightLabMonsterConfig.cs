namespace core.config
{
	public class FightLabMonsterConfig : XlsConfigBase<FightLabMonsterConfig, IFightLabMonsterConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "fightLabMonsterConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IFightLabMonsterConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IFightLabMonsterConfigInfo();
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
