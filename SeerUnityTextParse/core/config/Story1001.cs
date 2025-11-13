using System;

namespace core.config
{
	// Token: 0x02001E47 RID: 7751
	public class Story1001 : XlsConfigBase<Story1001, IStory1001Info>
	{
		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x0600E5E2 RID: 58850 RVA: 0x003E039F File Offset: 0x003DE59F
		public override string fileName
		{
			get
			{
				return "story_1001";
			}
		}

		// Token: 0x0600E5E3 RID: 58851 RVA: 0x003E03A8 File Offset: 0x003DE5A8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1001Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1001Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E5E4 RID: 58852 RVA: 0x003E03FC File Offset: 0x003DE5FC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
