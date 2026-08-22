namespace core.config
{
	public class AutocardEffectIconDes : XlsConfigBase<AutocardEffectIconDes, IAutocardEffectIconDesInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardEffectIconDes";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardEffectIconDesInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardEffectIconDesInfo();
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
