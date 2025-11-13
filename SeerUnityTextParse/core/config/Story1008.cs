using System;

namespace core.config
{
	// Token: 0x02001E55 RID: 7765
	public class Story1008 : XlsConfigBase<Story1008, IStory1008Info>
	{
		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x0600E68A RID: 59018 RVA: 0x003E0FFD File Offset: 0x003DF1FD
		public override string fileName
		{
			get
			{
				return "story_1008";
			}
		}

		// Token: 0x0600E68B RID: 59019 RVA: 0x003E1004 File Offset: 0x003DF204
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1008Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1008Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E68C RID: 59020 RVA: 0x003E1058 File Offset: 0x003DF258
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
