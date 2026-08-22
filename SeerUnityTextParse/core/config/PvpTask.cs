namespace core.config
{
	public class PvpTask : XlsConfigBase<PvpTask, IPvpTaskInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvp_task";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpTaskInfo();
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
