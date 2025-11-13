using System;

namespace core.config
{
	// Token: 0x02001E4D RID: 7757
	public class Story1004 : XlsConfigBase<Story1004, IStory1004Info>
	{
		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x0600E62A RID: 58922 RVA: 0x003E08ED File Offset: 0x003DEAED
		public override string fileName
		{
			get
			{
				return "story_1004";
			}
		}

		// Token: 0x0600E62B RID: 58923 RVA: 0x003E08F4 File Offset: 0x003DEAF4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1004Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1004Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E62C RID: 58924 RVA: 0x003E0948 File Offset: 0x003DEB48
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
