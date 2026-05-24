using System;

namespace core.config
{
	// Token: 0x020026F6 RID: 9974
	public class Story1023 : XlsConfigBase<Story1023, IStory1023Info>
	{
		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x0601378E RID: 79758 RVA: 0x00526781 File Offset: 0x00524981
		public override string fileName
		{
			get
			{
				return "story_1023";
			}
		}

		// Token: 0x0601378F RID: 79759 RVA: 0x00526788 File Offset: 0x00524988
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1023Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1023Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013790 RID: 79760 RVA: 0x005267DC File Offset: 0x005249DC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
