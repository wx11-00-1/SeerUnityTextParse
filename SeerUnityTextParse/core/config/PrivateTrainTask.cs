namespace core.config
{
	public class PrivateTrainTask : XlsConfigBase<PrivateTrainTask, IPrivateTrainTaskInfo>
	{
		public override string fileName
		{
			get
			{
				return "privateTrainTask";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPrivateTrainTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPrivateTrainTaskInfo();
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
