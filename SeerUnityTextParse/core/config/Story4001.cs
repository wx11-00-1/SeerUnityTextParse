namespace core.config
{
	public class Story4001 : XlsConfigBase<Story4001, IStory4001Info>
	{
		public override string fileName
		{
			get
			{
				return "story_4001";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory4001Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory4001Info();
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
