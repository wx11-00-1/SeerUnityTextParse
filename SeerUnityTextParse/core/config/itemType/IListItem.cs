namespace core.config.itemType
{
	public class IListItem
	{
		public IItemItem[] Item { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
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
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
