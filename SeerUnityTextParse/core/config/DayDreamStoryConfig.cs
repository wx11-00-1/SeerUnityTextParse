using System;

namespace core.config
{
	// Token: 0x02002662 RID: 9826
	public class DayDreamStoryConfig : XlsConfigBase<DayDreamStoryConfig, IDayDreamStoryConfigInfo>
	{
		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06013457 RID: 78935 RVA: 0x00553234 File Offset: 0x00551434
		public override string fileName
		{
			get
			{
				return "dayDreamStoryConfig";
			}
		}

		// Token: 0x06013458 RID: 78936 RVA: 0x0055323C File Offset: 0x0055143C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDayDreamStoryConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDayDreamStoryConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013459 RID: 78937 RVA: 0x00553290 File Offset: 0x00551490
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
