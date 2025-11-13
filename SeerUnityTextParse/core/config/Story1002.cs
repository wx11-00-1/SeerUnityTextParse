using System;

namespace core.config
{
	// Token: 0x02001E49 RID: 7753
	public class Story1002 : XlsConfigBase<Story1002, IStory1002Info>
	{
		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x0600E5FA RID: 58874 RVA: 0x003E0565 File Offset: 0x003DE765
		public override string fileName
		{
			get
			{
				return "story_1002";
			}
		}

		// Token: 0x0600E5FB RID: 58875 RVA: 0x003E056C File Offset: 0x003DE76C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1002Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1002Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E5FC RID: 58876 RVA: 0x003E05C0 File Offset: 0x003DE7C0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
