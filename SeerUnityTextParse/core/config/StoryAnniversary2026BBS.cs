using System;

namespace core.config
{
	// Token: 0x020026B6 RID: 9910
	public class StoryAnniversary2026BBS : XlsConfigBase<StoryAnniversary2026BBS, IStoryAnniversary2026BBSInfo>
	{
		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x0601349E RID: 79006 RVA: 0x00522FD2 File Offset: 0x005211D2
		public override string fileName
		{
			get
			{
				return "storyAnniversary2026BBS";
			}
		}

		// Token: 0x0601349F RID: 79007 RVA: 0x00522FDC File Offset: 0x005211DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStoryAnniversary2026BBSInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStoryAnniversary2026BBSInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060134A0 RID: 79008 RVA: 0x00523030 File Offset: 0x00521230
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
