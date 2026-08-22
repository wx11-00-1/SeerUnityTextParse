namespace core.config
{
	public class SunmoonStagewave : XlsConfigBase<SunmoonStagewave, ISunmoonStagewaveInfo>
	{
		public override string fileName
		{
			get
			{
				return "sunmoon_stagewave";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISunmoonStagewaveInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISunmoonStagewaveInfo();
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
