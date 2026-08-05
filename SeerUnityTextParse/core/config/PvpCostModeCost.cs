using System;

namespace core.config
{
	// Token: 0x02002908 RID: 10504
	public class PvpCostModeCost : XlsConfigBase<PvpCostModeCost, IPvpCostModeCostInfo>
	{
		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x06015213 RID: 86547 RVA: 0x005A36A1 File Offset: 0x005A18A1
		public override string fileName
		{
			get
			{
				return "pvpCostMode_cost";
			}
		}

		// Token: 0x06015214 RID: 86548 RVA: 0x005A36A8 File Offset: 0x005A18A8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpCostModeCostInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpCostModeCostInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06015215 RID: 86549 RVA: 0x005A36FC File Offset: 0x005A18FC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
