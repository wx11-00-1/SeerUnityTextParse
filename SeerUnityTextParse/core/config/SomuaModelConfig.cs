namespace core.config
{
	public class SomuaModelConfig : XlsConfigBase<SomuaModelConfig, ISomuaModelConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "SomuaModelConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISomuaModelConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISomuaModelConfigInfo();
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
