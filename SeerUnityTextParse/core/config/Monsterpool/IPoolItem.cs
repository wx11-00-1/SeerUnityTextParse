namespace core.config.Monsterpool
{
	public class IPoolItem : IConfigItem
	{
		public IItemItem[] item { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					item[i] = new IItemItem();
					item[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
