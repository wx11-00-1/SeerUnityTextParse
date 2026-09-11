namespace core.config
{
	public class AutocardStore : XlsConfigBase<AutocardStore, IAutocardStoreInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardStore";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardStoreInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardStoreInfo();
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
