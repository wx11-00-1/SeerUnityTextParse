namespace core.config
{
	public class ActivityTimeUpdateConfig : XlsConfigBase<ActivityTimeUpdateConfig, IActivityTimeUpdateConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "Activity_TimeUpdateConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IActivityTimeUpdateConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IActivityTimeUpdateConfigInfo();
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
