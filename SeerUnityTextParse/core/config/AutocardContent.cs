namespace core.config
{
	public class AutocardContent : XlsConfigBase<AutocardContent, IAutocardContentInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardContent";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardContentInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardContentInfo();
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
