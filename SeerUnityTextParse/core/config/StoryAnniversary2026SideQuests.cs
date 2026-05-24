using System;

namespace core.config
{
	// Token: 0x020026C4 RID: 9924
	public class StoryAnniversary2026SideQuests : XlsConfigBase<StoryAnniversary2026SideQuests, IStoryAnniversary2026SideQuestsInfo>
	{
		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x06013536 RID: 79158 RVA: 0x00523B03 File Offset: 0x00521D03
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026SideQuests";
			}
		}

		// Token: 0x06013537 RID: 79159 RVA: 0x00523B0C File Offset: 0x00521D0C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStoryAnniversary2026SideQuestsInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStoryAnniversary2026SideQuestsInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013538 RID: 79160 RVA: 0x00523B60 File Offset: 0x00521D60
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
