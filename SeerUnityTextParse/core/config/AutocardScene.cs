namespace core.config
{
	public class AutocardScene : XlsConfigBase<AutocardScene, IAutocardSceneInfo>
	{
		public override string fileName
		{
			get
			{
				return "autocardScene";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IAutocardSceneInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IAutocardSceneInfo();
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
