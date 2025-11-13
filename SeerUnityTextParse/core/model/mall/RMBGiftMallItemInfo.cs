using System;
using core.config;

namespace core.model.mall
{
	// Token: 0x02001AFE RID: 6910
	public class RMBGiftMallItemInfo : GiftMallItemInfo
	{
		// Token: 0x0600CF5B RID: 53083 RVA: 0x003C247B File Offset: 0x003C067B
		public RMBGiftMallItemInfo(IRechargeInfo rechargeInfo, object config) : base(config)
		{
			this._rechargeInfo = rechargeInfo;
		}

		// Token: 0x0600CF5C RID: 53084 RVA: 0x003C248B File Offset: 0x003C068B
		public override int GetCostType()
		{
			return 0;
		}

		// Token: 0x0600CF5D RID: 53085 RVA: 0x003C248E File Offset: 0x003C068E
		public override string GetCostIcon()
		{
			return string.Empty;
		}

		// Token: 0x0600CF5E RID: 53086 RVA: 0x003C2495 File Offset: 0x003C0695
		public override int GetPrice()
		{
			return this._rechargeInfo.money / 100;
		}

		// Token: 0x0600CF5F RID: 53087 RVA: 0x003C24A5 File Offset: 0x003C06A5
		public int GetRechargeID()
		{
			return this._rechargeInfo.id;
		}

		// Token: 0x0400E4D3 RID: 58579
		private IRechargeInfo _rechargeInfo;
	}
}
