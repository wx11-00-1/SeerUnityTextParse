namespace core.config.map_config
{
	public class IChangeMapComp
	{
		public IComponentItem[] component { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				component = new IComponentItem[num];
				for (int i = 0; i < num; i++)
				{
					component[i] = new IComponentItem();
					component[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
