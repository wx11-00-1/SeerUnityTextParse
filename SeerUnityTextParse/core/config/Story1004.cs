namespace core.config
{
	public class Story1004 : XlsConfigBase<Story1004, IStory1004Info>
	{
		public override string fileName
		{
			get
			{
				return "story_1004";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory1004Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory1004Info();
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
