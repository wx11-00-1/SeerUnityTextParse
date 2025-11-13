using System;

namespace core.config
{
	// Token: 0x02001E69 RID: 7785
	public class Story2006 : XlsConfigBase<Story2006, IStory2006Info>
	{
		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x0600E77A RID: 59258 RVA: 0x003E21A5 File Offset: 0x003E03A5
		public override string fileName
		{
			get
			{
				return "story_2006";
			}
		}

		// Token: 0x0600E77B RID: 59259 RVA: 0x003E21AC File Offset: 0x003E03AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory2006Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory2006Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E77C RID: 59260 RVA: 0x003E2200 File Offset: 0x003E0400
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
