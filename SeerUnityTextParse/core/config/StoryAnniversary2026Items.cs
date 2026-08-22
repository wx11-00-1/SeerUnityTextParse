namespace core.config
{
	public class StoryAnniversary2026Items : XlsConfigBase<StoryAnniversary2026Items, IStoryAnniversary2026ItemsInfo>
	{
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026Items";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStoryAnniversary2026ItemsInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStoryAnniversary2026ItemsInfo();
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
