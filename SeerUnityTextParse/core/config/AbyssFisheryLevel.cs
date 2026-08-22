namespace core.config
{
	public class AbyssFisheryLevel : XlsConfigBase<AbyssFisheryLevel, IAbyssFisheryLevelInfo>
	{
		public override string fileName
		{
			get
			{
				return "AbyssFisheryLevel";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAbyssFisheryLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAbyssFisheryLevelInfo();
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
