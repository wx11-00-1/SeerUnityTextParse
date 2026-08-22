namespace core.config
{
	public class ArchivesStory : XlsConfigBase<ArchivesStory, IArchivesStoryInfo>
	{
		public override string fileName
		{
			get
			{
				return "archivesStory";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IArchivesStoryInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IArchivesStoryInfo();
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
