using System;

namespace core.config
{
	// Token: 0x02001D41 RID: 7489
	public class ExchangeRestrict : XlsConfigBase<ExchangeRestrict, IExchangeRestrictInfo>
	{
		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x0600DAE8 RID: 56040 RVA: 0x003D2486 File Offset: 0x003D0686
		public override string fileName
		{
			get
			{
				return "exchangeRestrict";
			}
		}

		// Token: 0x0600DAE9 RID: 56041 RVA: 0x003D2490 File Offset: 0x003D0690
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IExchangeRestrictInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IExchangeRestrictInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DAEA RID: 56042 RVA: 0x003D24F0 File Offset: 0x003D06F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400E7E7 RID: 59367
		private bool b;
	}
}
