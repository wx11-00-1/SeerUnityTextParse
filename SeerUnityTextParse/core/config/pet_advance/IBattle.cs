namespace core.config.pet_advance
{
	public class IBattle
	{
		public ITaskItem[] Task { get; set; }

		public int FreeBattleKey { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			FreeBattleKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Task = new ITaskItem[num];
				for (int i = 0; i < num; i++)
				{
					Task[i] = new ITaskItem();
					Task[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
