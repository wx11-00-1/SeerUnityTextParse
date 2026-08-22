namespace core.config.error_code_analysis
{
	public class IRoot
	{
		private bool b;

		public IErrorpostItem[] errorpost { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				errorpost = new IErrorpostItem[num];
				for (int i = 0; i < num; i++)
				{
					errorpost[i] = new IErrorpostItem();
					errorpost[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
