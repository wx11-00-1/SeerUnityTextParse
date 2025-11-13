using System;

namespace core.config
{
	// Token: 0x02001E57 RID: 7767
	public class Story1009 : XlsConfigBase<Story1009, IStory1009Info>
	{
		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x0600E6A2 RID: 59042 RVA: 0x003E11C1 File Offset: 0x003DF3C1
		public override string fileName
		{
			get
			{
				return "story_1009";
			}
		}

		// Token: 0x0600E6A3 RID: 59043 RVA: 0x003E11C8 File Offset: 0x003DF3C8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1009Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1009Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E6A4 RID: 59044 RVA: 0x003E121C File Offset: 0x003DF41C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
