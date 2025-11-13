using System;

namespace core.config
{
	// Token: 0x02001E6F RID: 7791
	public class Story3002 : XlsConfigBase<Story3002, IStory3002Info>
	{
		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x0600E7C2 RID: 59330 RVA: 0x003E26F1 File Offset: 0x003E08F1
		public override string fileName
		{
			get
			{
				return "story_3002";
			}
		}

		// Token: 0x0600E7C3 RID: 59331 RVA: 0x003E26F8 File Offset: 0x003E08F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory3002Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory3002Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E7C4 RID: 59332 RVA: 0x003E274C File Offset: 0x003E094C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
