namespace core.config
{
	public class AwakenbosslevelTemp : XlsConfigBase<AwakenbosslevelTemp, IAwakenbosslevelTempInfo>
	{
		public override string fileName
		{
			get
			{
				return "awakenbosslevel_temp";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAwakenbosslevelTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAwakenbosslevelTempInfo();
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
