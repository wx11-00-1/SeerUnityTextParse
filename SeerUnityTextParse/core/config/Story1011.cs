using System;

namespace core.config
{
	// Token: 0x02001E5B RID: 7771
	public class Story1011 : XlsConfigBase<Story1011, IStory1011Info>
	{
		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x0600E6D2 RID: 59090 RVA: 0x003E1549 File Offset: 0x003DF749
		public override string fileName
		{
			get
			{
				return "story_1011";
			}
		}

		// Token: 0x0600E6D3 RID: 59091 RVA: 0x003E1550 File Offset: 0x003DF750
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1011Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1011Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E6D4 RID: 59092 RVA: 0x003E15A4 File Offset: 0x003DF7A4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
