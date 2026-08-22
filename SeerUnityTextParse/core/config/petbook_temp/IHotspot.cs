namespace core.config.petbook_temp
{
	public class IHotspot
	{
		public IItem item { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				item = new IItem();
				item.Parse(bytes, ref byteIndex);
			}
		}
	}
}
