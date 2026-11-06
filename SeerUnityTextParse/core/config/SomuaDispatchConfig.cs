namespace core.config
{
	public class SomuaDispatchConfig : XlsConfigBase<SomuaDispatchConfig, ISomuaDispatchConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "SomuaDispatchConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ISomuaDispatchConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ISomuaDispatchConfigInfo();
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
