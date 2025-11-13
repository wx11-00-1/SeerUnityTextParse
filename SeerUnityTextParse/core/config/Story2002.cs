using System;

namespace core.config
{
	// Token: 0x02001E61 RID: 7777
	public class Story2002 : XlsConfigBase<Story2002, IStory2002Info>
	{
		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x0600E71A RID: 59162 RVA: 0x003E1A95 File Offset: 0x003DFC95
		public override string fileName
		{
			get
			{
				return "story_2002";
			}
		}

		// Token: 0x0600E71B RID: 59163 RVA: 0x003E1A9C File Offset: 0x003DFC9C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory2002Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory2002Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E71C RID: 59164 RVA: 0x003E1AF0 File Offset: 0x003DFCF0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
