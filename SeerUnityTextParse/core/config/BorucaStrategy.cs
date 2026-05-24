using System;

namespace core.config
{
	// Token: 0x02002496 RID: 9366
	public class BorucaStrategy : XlsConfigBase<BorucaStrategy, IBorucaStrategyInfo>
	{
		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06011CCE RID: 72910 RVA: 0x00505D88 File Offset: 0x00503F88
		public override string fileName
		{
			get
			{
				return "boruca_strategy";
			}
		}

		// Token: 0x06011CCF RID: 72911 RVA: 0x00505D90 File Offset: 0x00503F90
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBorucaStrategyInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBorucaStrategyInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011CD0 RID: 72912 RVA: 0x00505DE4 File Offset: 0x00503FE4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
