using System;

namespace core.config
{
	// Token: 0x02002110 RID: 8464
	public class Story1015 : XlsConfigBase<Story1015, IStory1015Info>
	{
		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x060101B4 RID: 65972 RVA: 0x00448789 File Offset: 0x00446989
		public override string fileName
		{
			get
			{
				return "story_1015";
			}
		}

		// Token: 0x060101B5 RID: 65973 RVA: 0x00448790 File Offset: 0x00446990
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1015Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1015Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060101B6 RID: 65974 RVA: 0x004487E4 File Offset: 0x004469E4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
