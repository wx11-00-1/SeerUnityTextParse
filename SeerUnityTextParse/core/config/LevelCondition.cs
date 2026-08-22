namespace core.config
{
	public class LevelCondition : XlsConfigBase<LevelCondition, ILevelConditionInfo>
	{
		public override string fileName
		{
			get
			{
				return "LevelCondition";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ILevelConditionInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ILevelConditionInfo();
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
