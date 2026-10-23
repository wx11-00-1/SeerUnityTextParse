namespace core.config
{
	public class AutocardHappyActivity : XlsConfigBase<AutocardHappyActivity, IAutocardHappyActivityInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardHappyActivity";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardHappyActivityInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardHappyActivityInfo();
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
