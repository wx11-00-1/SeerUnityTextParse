using System;

namespace core.config
{
	// Token: 0x02001E5D RID: 7773
	public class Story1012 : XlsConfigBase<Story1012, IStory1012Info>
	{
		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x0600E6EA RID: 59114 RVA: 0x003E170D File Offset: 0x003DF90D
		public override string fileName
		{
			get
			{
				return "story_1012";
			}
		}

		// Token: 0x0600E6EB RID: 59115 RVA: 0x003E1714 File Offset: 0x003DF914
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1012Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1012Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E6EC RID: 59116 RVA: 0x003E1768 File Offset: 0x003DF968
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
