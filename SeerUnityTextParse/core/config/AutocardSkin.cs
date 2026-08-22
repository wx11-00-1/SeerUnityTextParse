namespace core.config
{
	public class AutocardSkin : XlsConfigBase<AutocardSkin, IAutocardSkinInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardSkin";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardSkinInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardSkinInfo();
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
