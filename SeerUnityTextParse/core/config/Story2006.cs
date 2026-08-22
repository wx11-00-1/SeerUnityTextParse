namespace core.config
{
	public class Story2006 : XlsConfigBase<Story2006, IStory2006Info>
	{
		public override string fileName
		{
			get
			{
				return "story_2006";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStory2006Info[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStory2006Info();
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
