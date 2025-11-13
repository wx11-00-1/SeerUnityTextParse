using System;

namespace core.config
{
	// Token: 0x02001E51 RID: 7761
	public class Story1006 : XlsConfigBase<Story1006, IStory1006Info>
	{
		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x0600E65A RID: 58970 RVA: 0x003E0C75 File Offset: 0x003DEE75
		public override string fileName
		{
			get
			{
				return "story_1006";
			}
		}

		// Token: 0x0600E65B RID: 58971 RVA: 0x003E0C7C File Offset: 0x003DEE7C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1006Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1006Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E65C RID: 58972 RVA: 0x003E0CD0 File Offset: 0x003DEED0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
