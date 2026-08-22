namespace core.config
{
	public class StoryAnniversary2026News : XlsConfigBase<StoryAnniversary2026News, IStoryAnniversary2026NewsInfo>
	{
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026News";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStoryAnniversary2026NewsInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStoryAnniversary2026NewsInfo();
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
