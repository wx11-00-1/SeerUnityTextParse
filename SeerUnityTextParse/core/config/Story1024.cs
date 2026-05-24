using System;

namespace core.config
{
	// Token: 0x020026F8 RID: 9976
	public class Story1024 : XlsConfigBase<Story1024, IStory1024Info>
	{
		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x060137A6 RID: 79782 RVA: 0x00526945 File Offset: 0x00524B45
		public override string fileName
		{
			get
			{
				return "story_1024";
			}
		}

		// Token: 0x060137A7 RID: 79783 RVA: 0x0052694C File Offset: 0x00524B4C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1024Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1024Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060137A8 RID: 79784 RVA: 0x005269A0 File Offset: 0x00524BA0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
