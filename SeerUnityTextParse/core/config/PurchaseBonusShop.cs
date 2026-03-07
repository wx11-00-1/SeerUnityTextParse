using System;

namespace core.config
{
	// Token: 0x02002074 RID: 8308
	public class PurchaseBonusShop : XlsConfigBase<PurchaseBonusShop, IPurchaseBonusShopInfo>
	{
		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x0600FAF6 RID: 64246 RVA: 0x0043FF3B File Offset: 0x0043E13B
		public override string fileName
		{
			get
			{
				return "purchaseBonus_shop";
			}
		}

		// Token: 0x0600FAF7 RID: 64247 RVA: 0x0043FF44 File Offset: 0x0043E144
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPurchaseBonusShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPurchaseBonusShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FAF8 RID: 64248 RVA: 0x0043FF98 File Offset: 0x0043E198
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
