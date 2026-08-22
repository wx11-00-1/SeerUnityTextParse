namespace core.config.pet_advance
{
	public class IBackMonsters
	{
		public IBackItem[] Back { get; set; }

		public int free_cnt { get; set; }

		public int refresh_add_cost { get; set; }

		public int refresh_base_cost { get; set; }

		public int refresh_max_cost { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Back = new IBackItem[num];
				for (int i = 0; i < num; i++)
				{
					Back[i] = new IBackItem();
					Back[i].Parse(bytes, ref byteIndex);
				}
			}
			free_cnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			refresh_add_cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			refresh_base_cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			refresh_max_cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
