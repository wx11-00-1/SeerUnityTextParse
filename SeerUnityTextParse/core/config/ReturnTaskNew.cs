namespace core.config
{
	public class ReturnTaskNew : XlsConfigBase<ReturnTaskNew, IReturnTaskNewInfo>
	{
		public override string fileName
		{
			get
			{
				return "return_task_new";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IReturnTaskNewInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IReturnTaskNewInfo();
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
