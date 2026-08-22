namespace core.config
{
	public class AutocardSession : XlsConfigBase<AutocardSession, IAutocardSessionInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardSession";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardSessionInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardSessionInfo();
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
