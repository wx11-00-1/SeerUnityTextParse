namespace core.config
{
	public class PvpStageConfig : XlsConfigBase<PvpStageConfig, IPvpStageConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "pvp_StageConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IPvpStageConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IPvpStageConfigInfo();
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
