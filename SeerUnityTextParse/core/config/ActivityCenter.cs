namespace core.config
{
	public class ActivityCenter : XlsConfigBase<ActivityCenter, IActivityCenterInfo>
	{
		public override string fileName
		{
			get
			{
				return "ActivityCenter";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IActivityCenterInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IActivityCenterInfo();
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
