namespace core.config.map_config
{
	public class IEntries
	{
		public IEntryItem[] Entry { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Entry = new IEntryItem[num];
				for (int i = 0; i < num; i++)
				{
					Entry[i] = new IEntryItem();
					Entry[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
