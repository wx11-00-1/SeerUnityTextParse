namespace core.config
{
	public class Story1003 : XlsConfigBase<Story1003, IStory1003Info>
	{
		public override string fileName
		{
			get
			{
				return "story_1003";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory1003Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory1003Info();
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
