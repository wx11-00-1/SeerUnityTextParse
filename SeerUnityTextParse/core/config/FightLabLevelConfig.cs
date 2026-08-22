namespace core.config
{
	public class FightLabLevelConfig : XlsConfigBase<FightLabLevelConfig, IFightLabLevelConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "fightLabLevelConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IFightLabLevelConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IFightLabLevelConfigInfo();
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
