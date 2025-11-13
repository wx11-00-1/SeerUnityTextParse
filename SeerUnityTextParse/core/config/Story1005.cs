using System;

namespace core.config
{
	// Token: 0x02001E4F RID: 7759
	public class Story1005 : XlsConfigBase<Story1005, IStory1005Info>
	{
		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x0600E642 RID: 58946 RVA: 0x003E0AB1 File Offset: 0x003DECB1
		public override string fileName
		{
			get
			{
				return "story_1005";
			}
		}

		// Token: 0x0600E643 RID: 58947 RVA: 0x003E0AB8 File Offset: 0x003DECB8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1005Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1005Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E644 RID: 58948 RVA: 0x003E0B0C File Offset: 0x003DED0C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
