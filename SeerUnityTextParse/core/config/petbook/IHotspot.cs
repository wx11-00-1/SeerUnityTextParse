namespace core.config.petbook
{
	public class IHotspot
	{
		public IItem item { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int byteIndex2 = byteIndex;
			if (byteIndex2 < bytes.Length)
			{
				if (bytes[byteIndex2++] != 0)
				{
					item = new IItem();
					item.Parse(bytes, ref byteIndex2);
				}
				byteIndex = byteIndex2;
			}
		}
	}
}
