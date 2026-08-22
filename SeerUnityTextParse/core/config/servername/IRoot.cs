namespace core.config.servername
{
	public class IRoot
	{
		public IListItem[] list { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				list = new IListItem[num];
				for (int i = 0; i < num; i++)
				{
					list[i] = new IListItem();
					list[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
