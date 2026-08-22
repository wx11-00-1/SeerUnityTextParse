namespace core.config.email
{
	public class IElements
	{
		public IElementItem[] element { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				element = new IElementItem[num];
				for (int i = 0; i < num; i++)
				{
					element[i] = new IElementItem();
					element[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
