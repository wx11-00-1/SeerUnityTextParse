using System;

namespace core.config
{
	// Token: 0x02001E65 RID: 7781
	public class Story2004 : XlsConfigBase<Story2004, IStory2004Info>
	{
		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x0600E74A RID: 59210 RVA: 0x003E1E1D File Offset: 0x003E001D
		public override string fileName
		{
			get
			{
				return "story_2004";
			}
		}

		// Token: 0x0600E74B RID: 59211 RVA: 0x003E1E24 File Offset: 0x003E0024
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory2004Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory2004Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E74C RID: 59212 RVA: 0x003E1E78 File Offset: 0x003E0078
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
