using System;

namespace core.config
{
	// Token: 0x02001DC7 RID: 7623
	public class PrivateShop : XlsConfigBase<PrivateShop, IPrivateShopInfo>
	{
		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x0600E064 RID: 57444 RVA: 0x003D9333 File Offset: 0x003D7533
		public override string fileName
		{
			get
			{
				return "privateShop";
			}
		}

		// Token: 0x0600E065 RID: 57445 RVA: 0x003D933C File Offset: 0x003D753C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPrivateShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPrivateShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E066 RID: 57446 RVA: 0x003D9390 File Offset: 0x003D7590
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
