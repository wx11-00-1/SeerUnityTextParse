namespace core.config.figure_reward
{
	public class IRewardItem
	{
		public IAch ach { get; set; }

		public IMonsterItem Head { get; set; }

		public IMonsterItem HeadFrame { get; set; }

		public IItemItem[] Item { get; set; }

		public IItemItem[] Mintmark { get; set; }

		public IMonsterItem[] Monster { get; set; }

		public IMonsterItem Skin { get; set; }

		public int ID { get; set; }

		public int Type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Head = new IMonsterItem();
				Head.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				HeadFrame = new IMonsterItem();
				HeadFrame.Parse(bytes, ref byteIndex);
			}
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Mintmark = new IItemItem[num2];
				for (int j = 0; j < num2; j++)
				{
					Mintmark[j] = new IItemItem();
					Mintmark[j].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Monster = new IMonsterItem[num3];
				for (int k = 0; k < num3; k++)
				{
					Monster[k] = new IMonsterItem();
					Monster[k].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Skin = new IMonsterItem();
				Skin.Parse(bytes, ref byteIndex);
			}
			Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				ach = new IAch();
				ach.Parse(bytes, ref byteIndex);
			}
		}
	}
}
