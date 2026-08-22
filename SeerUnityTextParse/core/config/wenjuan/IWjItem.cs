namespace core.config.wenjuan
{
	public class IWjItem : IConfigItem
	{
		public IItemItem[] item { get; set; }

		public string q { get; set; }

		public string statlog { get; set; }

		public int id { get; set; }

		public int skip { get; set; }

		public int type { get; set; }

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
			q = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			skip = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			statlog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
