namespace core.config
{
	public class ReturnMain : XlsConfigBase<ReturnMain, IReturnMainInfo>
	{
		public override string fileName
		{
			get
			{
				return "return_main";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IReturnMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IReturnMainInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
