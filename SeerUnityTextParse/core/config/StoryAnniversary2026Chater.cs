using System;

namespace core.config
{
	// Token: 0x020026B8 RID: 9912
	public class StoryAnniversary2026Chater : XlsConfigBase<StoryAnniversary2026Chater, IStoryAnniversary2026ChaterInfo>
	{
		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x060134B2 RID: 79026 RVA: 0x00523154 File Offset: 0x00521354
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026Chater";
			}
		}

		// Token: 0x060134B3 RID: 79027 RVA: 0x0052315C File Offset: 0x0052135C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStoryAnniversary2026ChaterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStoryAnniversary2026ChaterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060134B4 RID: 79028 RVA: 0x005231B0 File Offset: 0x005213B0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
