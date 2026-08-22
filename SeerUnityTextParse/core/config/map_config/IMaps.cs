namespace core.config.map_config
{
	public class IMaps
	{
		public IMapItem[] map { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				map = new IMapItem[num];
				for (int i = 0; i < num; i++)
				{
					map[i] = new IMapItem();
					map[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
