namespace core.config.wenjuan
{
	public class IWjmain
	{
		public IWjItem[] wj { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				wj = new IWjItem[num];
				for (int i = 0; i < num; i++)
				{
					wj[i] = new IWjItem();
					wj[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
