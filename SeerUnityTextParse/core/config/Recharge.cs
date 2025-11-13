using System;

namespace core.config
{
	// Token: 0x02001DF1 RID: 7665
	public class Recharge : XlsConfigBase<Recharge, IRechargeInfo>
	{
		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x0600E23E RID: 57918 RVA: 0x003DB714 File Offset: 0x003D9914
		public override string fileName
		{
			get
			{
				return "recharge";
			}
		}

		// Token: 0x0600E23F RID: 57919 RVA: 0x003DB71C File Offset: 0x003D991C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IRechargeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IRechargeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E240 RID: 57920 RVA: 0x003DB770 File Offset: 0x003D9970
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
