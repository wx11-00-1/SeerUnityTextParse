namespace core.config
{
	public class StoryDialog : XlsConfigBase<StoryDialog, IStoryDialog>
	{
		private int _ChapterId = 1001;

		private bool b;

		public int ChapterId
		{
			get
			{
				return _ChapterId;
			}
			set
			{
				m_IsLoaded = false;
				_ChapterId = value;
			}
		}

		public override string fileName
		{
			get
			{
				return "story_" + ChapterId;
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IStoryDialog[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IStoryDialog();
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
