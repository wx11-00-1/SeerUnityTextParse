namespace core.config.open_bonus
{
	public class IRoot
	{
		public IBonusItem[] Bonus { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Bonus = new IBonusItem[num];
				for (int i = 0; i < num; i++)
				{
					Bonus[i] = new IBonusItem();
					Bonus[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
