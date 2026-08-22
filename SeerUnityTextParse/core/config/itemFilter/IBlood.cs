namespace core.config.itemFilter
{
	public class IBlood
	{
		public IPeakJihad GoblinKing { get; set; }

		public IItemItem[] Item { get; set; }

		public IPeakJihad PeakJihad { get; set; }

		public IPeakJihad Status { get; set; }

		public ITopLevel TopLevel { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				GoblinKing = new IPeakJihad();
				GoblinKing.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					Item[i] = new IItemItem();
					Item[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				PeakJihad = new IPeakJihad();
				PeakJihad.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Status = new IPeakJihad();
				Status.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				TopLevel = new ITopLevel();
				TopLevel.Parse(bytes, ref byteIndex);
			}
		}
	}
}
