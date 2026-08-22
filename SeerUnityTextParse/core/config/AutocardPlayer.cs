namespace core.config
{
	public class AutocardPlayer : XlsConfigBase<AutocardPlayer, IAutocardPlayerInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardPlayer";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardPlayerInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardPlayerInfo();
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
