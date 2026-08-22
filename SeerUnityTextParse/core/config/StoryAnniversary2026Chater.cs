namespace core.config
{
	public class StoryAnniversary2026Chater : XlsConfigBase<StoryAnniversary2026Chater, IStoryAnniversary2026ChaterInfo>
	{
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026Chater";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStoryAnniversary2026ChaterInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStoryAnniversary2026ChaterInfo();
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
