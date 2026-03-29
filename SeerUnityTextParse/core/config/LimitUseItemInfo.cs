using System;

namespace core.config
{
	// Token: 0x02002294 RID: 8852
	public class LimitUseItemInfo : XlsConfigBase<LimitUseItemInfo, ILimitUseItemInfoInfo>
	{
		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x06010BD6 RID: 68566 RVA: 0x0048F494 File Offset: 0x0048D694
		public override string fileName
		{
			get
			{
				return "LimitUseItemInfo";
			}
		}

		// Token: 0x06010BD7 RID: 68567 RVA: 0x0048F49C File Offset: 0x0048D69C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILimitUseItemInfoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILimitUseItemInfoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06010BD8 RID: 68568 RVA: 0x0048F4F0 File Offset: 0x0048D6F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
