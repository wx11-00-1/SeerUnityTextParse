using System;

namespace core.config
{
	// Token: 0x02001D9D RID: 7581
	public class NatolesJourneyOfRevivalEventConfig : XlsConfigBase<NatolesJourneyOfRevivalEventConfig, INatolesJourneyOfRevivalEventConfigInfo>
	{
		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x0600DE86 RID: 56966 RVA: 0x003D6EBE File Offset: 0x003D50BE
		public override string fileName
		{
			get
			{
				return "natolesJourneyOfRevivalEventConfig";
			}
		}

		// Token: 0x0600DE87 RID: 56967 RVA: 0x003D6EC8 File Offset: 0x003D50C8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INatolesJourneyOfRevivalEventConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INatolesJourneyOfRevivalEventConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DE88 RID: 56968 RVA: 0x003D6F1C File Offset: 0x003D511C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
