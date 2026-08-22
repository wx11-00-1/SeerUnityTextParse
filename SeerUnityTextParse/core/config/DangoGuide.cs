namespace core.config
{
	public class DangoGuide : XlsConfigBase<DangoGuide, IDangoGuideInfo>
	{
		public override string fileName
		{
			get
			{
				return "dangoGuide";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IDangoGuideInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IDangoGuideInfo();
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
