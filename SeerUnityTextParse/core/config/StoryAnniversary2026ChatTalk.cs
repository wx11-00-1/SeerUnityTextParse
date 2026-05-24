using System;

namespace core.config
{
	// Token: 0x020026BA RID: 9914
	public class StoryAnniversary2026ChatTalk : XlsConfigBase<StoryAnniversary2026ChatTalk, IStoryAnniversary2026ChatTalkInfo>
	{
		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x060134C6 RID: 79046 RVA: 0x005232DB File Offset: 0x005214DB
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026ChatTalk";
			}
		}

		// Token: 0x060134C7 RID: 79047 RVA: 0x005232E4 File Offset: 0x005214E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStoryAnniversary2026ChatTalkInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStoryAnniversary2026ChatTalkInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060134C8 RID: 79048 RVA: 0x00523338 File Offset: 0x00521538
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
