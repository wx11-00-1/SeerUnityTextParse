namespace core.config
{
	public class ChapterpointTemp : XlsConfigBase<ChapterpointTemp, IChapterpointTempInfo>
	{
		public override string fileName
		{
			get
			{
				return "chapterpoint_temp";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IChapterpointTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IChapterpointTempInfo();
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
