using System;

namespace core.config
{
	// Token: 0x02001E53 RID: 7763
	public class Story1007 : XlsConfigBase<Story1007, IStory1007Info>
	{
		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x0600E672 RID: 58994 RVA: 0x003E0E39 File Offset: 0x003DF039
		public override string fileName
		{
			get
			{
				return "story_1007";
			}
		}

		// Token: 0x0600E673 RID: 58995 RVA: 0x003E0E40 File Offset: 0x003DF040
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1007Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1007Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E674 RID: 58996 RVA: 0x003E0E94 File Offset: 0x003DF094
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
