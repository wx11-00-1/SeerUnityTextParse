using System;

namespace core.config
{
	// Token: 0x020026E4 RID: 9956
	public class Story1014 : XlsConfigBase<Story1014, IStory1014Info>
	{
		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x060136B6 RID: 79542 RVA: 0x0052579D File Offset: 0x0052399D
		public override string fileName
		{
			get
			{
				return "story_1014";
			}
		}

		// Token: 0x060136B7 RID: 79543 RVA: 0x005257A4 File Offset: 0x005239A4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1014Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1014Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060136B8 RID: 79544 RVA: 0x005257F8 File Offset: 0x005239F8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
