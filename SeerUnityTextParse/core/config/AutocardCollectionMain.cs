namespace core.config
{
	public class AutocardCollectionMain : XlsConfigBase<AutocardCollectionMain, IAutocardCollectionMainInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardCollectionMain";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardCollectionMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardCollectionMainInfo();
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
