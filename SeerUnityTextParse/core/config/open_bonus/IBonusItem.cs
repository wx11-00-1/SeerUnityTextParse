namespace core.config.open_bonus
{
	public class IBonusItem
	{
		public IOutItem[] Out { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Out = new IOutItem[num];
				for (int i = 0; i < num; i++)
				{
					Out[i] = new IOutItem();
					Out[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
