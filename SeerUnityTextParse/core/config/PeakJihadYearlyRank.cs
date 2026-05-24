using System;

namespace core.config
{
	// Token: 0x02002600 RID: 9728
	public class PeakJihadYearlyRank : XlsConfigBase<PeakJihadYearlyRank, IPeakJihadYearlyRankInfo>
	{
		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x06012CA4 RID: 76964 RVA: 0x005191A5 File Offset: 0x005173A5
		public override string fileName
		{
			get
			{
				return "peakJihadYearlyRank";
			}
		}

		// Token: 0x06012CA5 RID: 76965 RVA: 0x005191AC File Offset: 0x005173AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPeakJihadYearlyRankInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPeakJihadYearlyRankInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06012CA6 RID: 76966 RVA: 0x00519200 File Offset: 0x00517400
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
