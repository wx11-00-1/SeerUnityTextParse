using System;

namespace core.config
{
	// Token: 0x02001D43 RID: 7491
	public class ExchangeClt : XlsConfigBase<ExchangeClt, IExchangeCltInfo>
	{
		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x0600DAF2 RID: 56050 RVA: 0x003D255D File Offset: 0x003D075D
		public override string fileName
		{
			get
			{
				return "exchange_clt";
			}
		}

		// Token: 0x0600DAF3 RID: 56051 RVA: 0x003D2564 File Offset: 0x003D0764
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IExchangeCltInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IExchangeCltInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DAF4 RID: 56052 RVA: 0x003D25B8 File Offset: 0x003D07B8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
