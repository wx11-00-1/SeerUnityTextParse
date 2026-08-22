namespace core.config
{
	public class Story2004 : XlsConfigBase<Story2004, IStory2004Info>
	{
		public override string fileName
		{
			get
			{
				return "story_2004";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory2004Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory2004Info();
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
