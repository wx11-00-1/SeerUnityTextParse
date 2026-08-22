namespace core.config
{
	public class OmniCoetusTask : XlsConfigBase<OmniCoetusTask, IOmniCoetusTaskInfo>
	{
		public override string fileName
		{
			get
			{
				return "omniCoetus_task";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IOmniCoetusTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IOmniCoetusTaskInfo();
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
