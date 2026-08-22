namespace core.config
{
	public class Story3002 : XlsConfigBase<Story3002, IStory3002Info>
	{
		public override string fileName
		{
			get
			{
				return "story_3002";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory3002Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory3002Info();
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
