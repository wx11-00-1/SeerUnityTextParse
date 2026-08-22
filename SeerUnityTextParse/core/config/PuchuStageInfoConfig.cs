namespace core.config
{
	public class PuchuStageInfoConfig : XlsConfigBase<PuchuStageInfoConfig, IPuchuStageInfoConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "puchuStageInfoConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPuchuStageInfoConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPuchuStageInfoConfigInfo();
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
