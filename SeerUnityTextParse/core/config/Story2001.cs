using System;

namespace core.config
{
	// Token: 0x02001E5F RID: 7775
	public class Story2001 : XlsConfigBase<Story2001, IStory2001Info>
	{
		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x0600E702 RID: 59138 RVA: 0x003E18D1 File Offset: 0x003DFAD1
		public override string fileName
		{
			get
			{
				return "story_2001";
			}
		}

		// Token: 0x0600E703 RID: 59139 RVA: 0x003E18D8 File Offset: 0x003DFAD8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory2001Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory2001Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x003E192C File Offset: 0x003DFB2C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
