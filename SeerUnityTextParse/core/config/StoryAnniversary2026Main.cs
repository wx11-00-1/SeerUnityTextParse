using System;

namespace core.config
{
	// Token: 0x020026C0 RID: 9920
	public class StoryAnniversary2026Main : XlsConfigBase<StoryAnniversary2026Main, IStoryAnniversary2026MainInfo>
	{
		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x06013510 RID: 79120 RVA: 0x0052382C File Offset: 0x00521A2C
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026Main";
			}
		}

		// Token: 0x06013511 RID: 79121 RVA: 0x00523834 File Offset: 0x00521A34
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStoryAnniversary2026MainInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStoryAnniversary2026MainInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013512 RID: 79122 RVA: 0x00523888 File Offset: 0x00521A88
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
