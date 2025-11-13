using System;

namespace core.config
{
	// Token: 0x02001E43 RID: 7747
	public class StoryDialog : XlsConfigBase<StoryDialog, IStoryDialog>
	{
		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x0600E5B2 RID: 58802 RVA: 0x003DFFBE File Offset: 0x003DE1BE
		public override string fileName
		{
			get
			{
				return "story_" + this.ChapterId.ToString();
			}
		}

		// Token: 0x0600E5B3 RID: 58803 RVA: 0x003DFFD8 File Offset: 0x003DE1D8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStoryDialog[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStoryDialog();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E5B4 RID: 58804 RVA: 0x003E0038 File Offset: 0x003DE238
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400EBC9 RID: 60361
		public int ChapterId = 1001;

		// Token: 0x0400EBCA RID: 60362
		private bool b;
	}
}
