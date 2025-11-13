using System;
using core.config.commonItem;

namespace core.config.midleExchangeItems
{
	// Token: 0x02001FCB RID: 8139
	public class IItemItem : CommonItem
	{
		// Token: 0x0600F560 RID: 62816 RVA: 0x003FACA8 File Offset: 0x003F8EA8
		public override int GetTargetId()
		{
			return this.TargetId;
		}

		// Token: 0x0600F561 RID: 62817 RVA: 0x003FACB0 File Offset: 0x003F8EB0
		public override int GetExchangeId()
		{
			return this.ExchangeId;
		}

		// Token: 0x0600F562 RID: 62818 RVA: 0x003FACB8 File Offset: 0x003F8EB8
		public override string GetExchangeOutId()
		{
			return this.ExchangeOutId;
		}

		// Token: 0x0600F563 RID: 62819 RVA: 0x003FACC0 File Offset: 0x003F8EC0
		public override string GetExchangeOutCnt()
		{
			return this.ExchangeOutCnt;
		}

		// Token: 0x0600F564 RID: 62820 RVA: 0x003FACC8 File Offset: 0x003F8EC8
		public override int GetSkinId()
		{
			return this.SkinId;
		}

		// Token: 0x0600F565 RID: 62821 RVA: 0x003FACD0 File Offset: 0x003F8ED0
		public override int GetExchangeType()
		{
			return this.ExchangeType;
		}

		// Token: 0x0400F36F RID: 62319
		public int TargetId;

		// Token: 0x0400F370 RID: 62320
		public int ExchangeId;

		// Token: 0x0400F371 RID: 62321
		public string ExchangeOutId = string.Empty;

		// Token: 0x0400F372 RID: 62322
		public string ExchangeOutCnt = string.Empty;

		// Token: 0x0400F373 RID: 62323
		public int SkinId;

		// Token: 0x0400F374 RID: 62324
		public int ExchangeType;
	}
}
