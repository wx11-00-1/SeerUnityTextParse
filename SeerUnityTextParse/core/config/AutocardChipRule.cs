namespace core.config
{
	public class AutocardChipRule : XlsConfigBase<AutocardChipRule, IAutocardChipRuleInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardChipRule";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardChipRuleInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardChipRuleInfo();
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
