namespace core.config
{
	public class ReturnTask : XlsConfigBase<ReturnTask, IReturnTaskInfo>
	{
		public override string fileName
		{
			get
			{
				return "return_task";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IReturnTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IReturnTaskInfo();
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
