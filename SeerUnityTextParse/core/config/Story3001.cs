namespace core.config
{
	public class Story3001 : XlsConfigBase<Story3001, IStory3001Info>
	{
		public override string fileName
		{
			get
			{
				return "story_3001";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory3001Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory3001Info();
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
