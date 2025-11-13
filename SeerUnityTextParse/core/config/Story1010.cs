using System;

namespace core.config
{
	// Token: 0x02001E59 RID: 7769
	public class Story1010 : XlsConfigBase<Story1010, IStory1010Info>
	{
		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x0600E6BA RID: 59066 RVA: 0x003E1385 File Offset: 0x003DF585
		public override string fileName
		{
			get
			{
				return "story_1010";
			}
		}

		// Token: 0x0600E6BB RID: 59067 RVA: 0x003E138C File Offset: 0x003DF58C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1010Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1010Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E6BC RID: 59068 RVA: 0x003E13E0 File Offset: 0x003DF5E0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
