namespace core.config
{
	public class ActivityTaskConfig : XlsConfigBase<ActivityTaskConfig, IActivityTaskConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "Activity_TaskConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IActivityTaskConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IActivityTaskConfigInfo();
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
