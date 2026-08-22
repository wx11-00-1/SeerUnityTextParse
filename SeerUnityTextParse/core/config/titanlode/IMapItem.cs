namespace core.config.titanlode
{
	public class IMapItem : IConfigItem
	{
		public IShowItem[] Show { get; set; }

		public int colcnt { get; set; }

		public int id { get; set; }

		public int maxcnt { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Show = new IShowItem[num];
				for (int i = 0; i < num; i++)
				{
					Show[i] = new IShowItem();
					Show[i].Parse(bytes, ref byteIndex);
				}
			}
			colcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			maxcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
