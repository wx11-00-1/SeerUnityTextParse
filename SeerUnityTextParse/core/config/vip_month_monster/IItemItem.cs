namespace core.config.vip_month_monster
{
	public class IItemItem
	{
		public int[] BonusIds { get; set; }

		public int[] GotFlagInfo { get; set; }

		public int[] MonstersID { get; set; }

		public int CurMonth { get; set; }

		public int CurYear { get; set; }

		public int ID { get; set; }

		public int MonsterID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				BonusIds = new int[num];
				for (int i = 0; i < num; i++)
				{
					BonusIds[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			CurMonth = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			CurYear = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				GotFlagInfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					GotFlagInfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				MonstersID = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					MonstersID[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
