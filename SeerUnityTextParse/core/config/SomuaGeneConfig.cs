namespace core.config
{
	public class SomuaGeneConfig : XlsConfigBase<SomuaGeneConfig, ISomuaGeneConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "SomuaGeneConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISomuaGeneConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISomuaGeneConfigInfo();
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
