namespace core.config.Fragment
{
	public class IRoot
	{
		public IFragmentItem[] Fragment { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Fragment = new IFragmentItem[num];
				for (int i = 0; i < num; i++)
				{
					Fragment[i] = new IFragmentItem();
					Fragment[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
