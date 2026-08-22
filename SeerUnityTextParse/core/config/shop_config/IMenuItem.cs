namespace core.config.shop_config
{
	public class IMenuItem : IConfigItem
	{
		public string ad { get; set; }

		public string cls { get; set; }

		public string countID { get; set; }

		public IItemItem[] item { get; set; }

		public IMenuItem[] menu { get; set; }

		public string name { get; set; }

		public string viewClass { get; set; }

		public int id { get; set; }

		public int pageSize { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ad = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			cls = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			countID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
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
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				menu = new IMenuItem[num2];
				for (int j = 0; j < num2; j++)
				{
					menu[j] = new IMenuItem();
					menu[j].Parse(bytes, ref byteIndex);
				}
			}
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			pageSize = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			viewClass = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
