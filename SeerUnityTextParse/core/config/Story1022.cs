namespace core.config
{
	public class Story1022 : XlsConfigBase<Story1022, IStory1022Info>
	{
		public override string fileName
		{
			get
			{
				return "story_1022";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory1022Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory1022Info();
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
