namespace core.config
{
	public class FightTestBossConfig : XlsConfigBase<FightTestBossConfig, IFightTestBossConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "fightTestBossConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IFightTestBossConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IFightTestBossConfigInfo();
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
