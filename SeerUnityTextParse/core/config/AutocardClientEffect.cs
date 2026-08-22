namespace core.config
{
	public class AutocardClientEffect : XlsConfigBase<AutocardClientEffect, IAutocardClientEffectInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardClientEffect";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardClientEffectInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardClientEffectInfo();
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
