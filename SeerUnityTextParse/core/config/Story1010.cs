namespace core.config
{
	public class Story1010 : XlsConfigBase<Story1010, IStory1010Info>
	{
		public override string fileName
		{
			get
			{
				return "story_1010";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory1010Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory1010Info();
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
