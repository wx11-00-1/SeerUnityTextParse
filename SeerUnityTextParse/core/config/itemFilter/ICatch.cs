namespace core.config.itemFilter
{
	public class ICatch
	{
		public string _text { get; set; }

		public string des { get; set; }

		public IItemItem[] Item { get; set; }

		public ITopLevel SP { get; set; }

		public IPeakJihad SUPER_ID { get; set; }

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
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				SP = new ITopLevel();
				SP.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				SUPER_ID = new IPeakJihad();
				SUPER_ID.Parse(bytes, ref byteIndex);
			}
			_text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
