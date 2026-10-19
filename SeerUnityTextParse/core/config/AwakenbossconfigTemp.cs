namespace core.config
{
	public class AwakenbossconfigTemp : XlsConfigBase<AwakenbossconfigTemp, IAwakenbossconfigTempInfo>
	{
		public override string fileName
		{
			get
			{
				return "awakenbossconfig_temp";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAwakenbossconfigTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAwakenbossconfigTempInfo();
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
