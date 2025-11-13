using System;

namespace core.config
{
	// Token: 0x02001E6D RID: 7789
	public class Story3001 : XlsConfigBase<Story3001, IStory3001Info>
	{
		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x0600E7AA RID: 59306 RVA: 0x003E252D File Offset: 0x003E072D
		public override string fileName
		{
			get
			{
				return "story_3001";
			}
		}

		// Token: 0x0600E7AB RID: 59307 RVA: 0x003E2534 File Offset: 0x003E0734
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory3001Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory3001Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E7AC RID: 59308 RVA: 0x003E2588 File Offset: 0x003E0788
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
