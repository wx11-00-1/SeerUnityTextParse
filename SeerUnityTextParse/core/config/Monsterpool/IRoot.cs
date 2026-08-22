namespace core.config.Monsterpool
{
	public class IRoot
	{
		public IPoolItem[] Pool { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Pool = new IPoolItem[num];
				for (int i = 0; i < num; i++)
				{
					Pool[i] = new IPoolItem();
					Pool[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
