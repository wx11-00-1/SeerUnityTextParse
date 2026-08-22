namespace core.config
{
	public class BraveGuide : XlsConfigBase<BraveGuide, IBraveGuideInfo>
	{
		public override string fileName
		{
			get
			{
				return "brave_guide";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBraveGuideInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBraveGuideInfo();
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
