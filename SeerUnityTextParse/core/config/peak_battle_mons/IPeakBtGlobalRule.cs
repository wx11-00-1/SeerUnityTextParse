namespace core.config.peak_battle_mons
{
	public class IPeakBtGlobalRule
	{
		public IWeeklyIDItem[] WeeklyID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				WeeklyID = new IWeeklyIDItem[num];
				for (int i = 0; i < num; i++)
				{
					WeeklyID[i] = new IWeeklyIDItem();
					WeeklyID[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
