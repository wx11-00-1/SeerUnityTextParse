namespace core.config.itemFilter
{
	public class IPeakJihad
	{
		public string des { get; set; }

		public IItemItem[] Item { get; set; }

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
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
