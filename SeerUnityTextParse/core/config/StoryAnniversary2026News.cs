using System;

namespace core.config
{
	// Token: 0x020026C2 RID: 9922
	public class StoryAnniversary2026News : XlsConfigBase<StoryAnniversary2026News, IStoryAnniversary2026NewsInfo>
	{
		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x06013524 RID: 79140 RVA: 0x0052399E File Offset: 0x00521B9E
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026News";
			}
		}

		// Token: 0x06013525 RID: 79141 RVA: 0x005239A8 File Offset: 0x00521BA8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStoryAnniversary2026NewsInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStoryAnniversary2026NewsInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013526 RID: 79142 RVA: 0x005239FC File Offset: 0x00521BFC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
