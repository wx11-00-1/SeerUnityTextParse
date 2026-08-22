namespace core.config
{
	public class StoryAnniversary2026ChatTalk : XlsConfigBase<StoryAnniversary2026ChatTalk, IStoryAnniversary2026ChatTalkInfo>
	{
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026ChatTalk";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStoryAnniversary2026ChatTalkInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStoryAnniversary2026ChatTalkInfo();
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
