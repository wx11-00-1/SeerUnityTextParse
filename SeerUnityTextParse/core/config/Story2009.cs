namespace core.config
{
	public class Story2009 : XlsConfigBase<Story2009, IStory2009Info>
	{
		public override string fileName
		{
			get
			{
				return "story_2009";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory2009Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory2009Info();
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
