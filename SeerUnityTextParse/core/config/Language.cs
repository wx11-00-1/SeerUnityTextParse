namespace core.config
{
	public class Language : XlsConfigBase<Language, ILanguageInfo>
	{
		public override string fileName
		{
			get
			{
				return "language";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ILanguageInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ILanguageInfo();
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
