using System;

namespace core.config
{
	// Token: 0x02001E6B RID: 7787
	public class Story2007 : XlsConfigBase<Story2007, IStory2007Info>
	{
		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x0600E792 RID: 59282 RVA: 0x003E2369 File Offset: 0x003E0569
		public override string fileName
		{
			get
			{
				return "story_2007";
			}
		}

		// Token: 0x0600E793 RID: 59283 RVA: 0x003E2370 File Offset: 0x003E0570
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory2007Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory2007Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E794 RID: 59284 RVA: 0x003E23C4 File Offset: 0x003E05C4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
