namespace core.config
{
	public class AbyssFishery : XlsConfigBase<AbyssFishery, IAbyssFisheryInfo>
	{
		public override string fileName
		{
			get
			{
				return "AbyssFishery";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAbyssFisheryInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAbyssFisheryInfo();
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
