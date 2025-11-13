using System;

namespace core.config
{
	// Token: 0x02001E4B RID: 7755
	public class Story1003 : XlsConfigBase<Story1003, IStory1003Info>
	{
		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x0600E612 RID: 58898 RVA: 0x003E0729 File Offset: 0x003DE929
		public override string fileName
		{
			get
			{
				return "story_1003";
			}
		}

		// Token: 0x0600E613 RID: 58899 RVA: 0x003E0730 File Offset: 0x003DE930
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1003Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1003Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E614 RID: 58900 RVA: 0x003E0784 File Offset: 0x003DE984
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
