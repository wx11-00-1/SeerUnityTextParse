using System;

namespace core.config
{
	// Token: 0x020026E8 RID: 9960
	public class Story1016 : XlsConfigBase<Story1016, IStory1016Info>
	{
		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x060136E6 RID: 79590 RVA: 0x00525B25 File Offset: 0x00523D25
		public override string fileName
		{
			get
			{
				return "story_1016";
			}
		}

		// Token: 0x060136E7 RID: 79591 RVA: 0x00525B2C File Offset: 0x00523D2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1016Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1016Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060136E8 RID: 79592 RVA: 0x00525B80 File Offset: 0x00523D80
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
