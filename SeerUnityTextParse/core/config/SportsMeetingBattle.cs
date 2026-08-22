namespace core.config
{
	public class SportsMeetingBattle : XlsConfigBase<SportsMeetingBattle, ISportsMeetingBattleInfo>
	{
		public override string fileName
		{
			get
			{
				return "sportsMeetingBattle";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISportsMeetingBattleInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISportsMeetingBattleInfo();
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
