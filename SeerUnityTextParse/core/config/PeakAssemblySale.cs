using System;

namespace core.config
{
	// Token: 0x02001DBB RID: 7611
	public class PeakAssemblySale : XlsConfigBase<PeakAssemblySale, IPeakAssemblySaleInfo>
	{
		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x0600DFF0 RID: 57328 RVA: 0x003D8AFD File Offset: 0x003D6CFD
		public override string fileName
		{
			get
			{
				return "PeakAssemblySale";
			}
		}

		// Token: 0x0600DFF1 RID: 57329 RVA: 0x003D8B04 File Offset: 0x003D6D04
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPeakAssemblySaleInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPeakAssemblySaleInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DFF2 RID: 57330 RVA: 0x003D8B58 File Offset: 0x003D6D58
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
