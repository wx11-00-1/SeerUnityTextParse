using System;

namespace core.config
{
	// Token: 0x02001E63 RID: 7779
	public class Story2003 : XlsConfigBase<Story2003, IStory2003Info>
	{
		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x0600E732 RID: 59186 RVA: 0x003E1C59 File Offset: 0x003DFE59
		public override string fileName
		{
			get
			{
				return "story_2003";
			}
		}

		// Token: 0x0600E733 RID: 59187 RVA: 0x003E1C60 File Offset: 0x003DFE60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory2003Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory2003Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E734 RID: 59188 RVA: 0x003E1CB4 File Offset: 0x003DFEB4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
