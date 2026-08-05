using System;

namespace core.config
{
	// Token: 0x020029E8 RID: 10728
	public class Story1026 : XlsConfigBase<Story1026, IStory1026Info>
	{
		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x06015C2B RID: 89131 RVA: 0x005AFBBD File Offset: 0x005ADDBD
		public override string fileName
		{
			get
			{
				return "story_1026";
			}
		}

		// Token: 0x06015C2C RID: 89132 RVA: 0x005AFBC4 File Offset: 0x005ADDC4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1026Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1026Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06015C2D RID: 89133 RVA: 0x005AFC18 File Offset: 0x005ADE18
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
