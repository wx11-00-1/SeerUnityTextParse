namespace core.config
{
	public class StoryAnniversary2026BBS : XlsConfigBase<StoryAnniversary2026BBS, IStoryAnniversary2026BBSInfo>
	{
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026BBS";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStoryAnniversary2026BBSInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStoryAnniversary2026BBSInfo();
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
