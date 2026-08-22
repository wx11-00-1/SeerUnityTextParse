namespace core.config
{
	public class DreamyHotSpringRoadLevelConfig : XlsConfigBase<DreamyHotSpringRoadLevelConfig, IDreamyHotSpringRoadLevelConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "dreamyHotSpringRoadLevelConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IDreamyHotSpringRoadLevelConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IDreamyHotSpringRoadLevelConfigInfo();
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
