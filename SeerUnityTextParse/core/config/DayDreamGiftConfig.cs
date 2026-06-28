using System;

namespace core.config
{
	// Token: 0x02002660 RID: 9824
	public class DayDreamGiftConfig : XlsConfigBase<DayDreamGiftConfig, IDayDreamGiftConfigInfo>
	{
		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x0601343F RID: 78911 RVA: 0x00553085 File Offset: 0x00551285
		public override string fileName
		{
			get
			{
				return "dayDreamGiftConfig";
			}
		}

		// Token: 0x06013440 RID: 78912 RVA: 0x0055308C File Offset: 0x0055128C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDayDreamGiftConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDayDreamGiftConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013441 RID: 78913 RVA: 0x005530E0 File Offset: 0x005512E0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
