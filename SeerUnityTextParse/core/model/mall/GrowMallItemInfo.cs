using System;
using core.config;

namespace core.model.mall
{
	// Token: 0x02001AFB RID: 6907
	public class GrowMallItemInfo : AMallItemInfo
	{
		// Token: 0x0600CF19 RID: 53017 RVA: 0x003C1C08 File Offset: 0x003BFE08
		public GrowMallItemInfo(object config) : base(config)
		{
			this._itemItem = (config as IShopCultivateInfo);
			if (this._itemItem != null)
			{
				this.name = this._itemItem.name;
			}
		}

		// Token: 0x0600CF1A RID: 53018 RVA: 0x003C1C38 File Offset: 0x003BFE38
		public override string GetIcon()
		{
			int[] reward = this._itemItem.reward;
			int num = reward[0];
			int id = reward[1];
			if (num == 1)
			{
				return ClientConfig.getItemIcon(id);
			}
			if (num == 2)
			{
				return ClientConfig.getMarkPath(id);
			}
			return base.GetIcon();
		}

		// Token: 0x0600CF1B RID: 53019 RVA: 0x003C1C73 File Offset: 0x003BFE73
		public override int GetSort()
		{
			return this._itemItem.sort;
		}

		// Token: 0x0600CF1C RID: 53020 RVA: 0x003C1C80 File Offset: 0x003BFE80
		public virtual int GetItemType()
		{
			return this._itemItem.type;
		}

		// Token: 0x0600CF1D RID: 53021 RVA: 0x003C1C8D File Offset: 0x003BFE8D
		public override int GetProductID()
		{
			return this._itemItem.prop;
		}

		// Token: 0x0600CF1E RID: 53022 RVA: 0x003C1C9A File Offset: 0x003BFE9A
		public override int GetItemID()
		{
			return this._itemItem.reward[1];
		}

		// Token: 0x0600CF1F RID: 53023 RVA: 0x003C1CA9 File Offset: 0x003BFEA9
		public override int[] GetItemIDs()
		{
			return this._itemItem.reward;
		}

		// Token: 0x0600CF20 RID: 53024 RVA: 0x003C1CB6 File Offset: 0x003BFEB6
		public override int GetCostType()
		{
			return this._itemItem.price[0];
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x003C1CC5 File Offset: 0x003BFEC5
		public override string GetCostIcon()
		{
			return ClientConfig.getItemIcon(this._itemItem.price[1]);
		}

		// Token: 0x0600CF22 RID: 53026 RVA: 0x003C1CD9 File Offset: 0x003BFED9
		public override int GetPrice()
		{
			return this._itemItem.price[2];
		}

		// Token: 0x0600CF23 RID: 53027 RVA: 0x003C1CE8 File Offset: 0x003BFEE8
		public override int GetCostID()
		{
			return this._itemItem.price[1];
		}

		// Token: 0x0600CF24 RID: 53028 RVA: 0x003C1CF7 File Offset: 0x003BFEF7
		public override bool CanBuy()
		{
			return true;
		}

		// Token: 0x0600CF25 RID: 53029 RVA: 0x003C1CFA File Offset: 0x003BFEFA
		public override GiftMallItemInfo.LimitType GetLimitType()
		{
			if (this._itemItem.quota != 0)
			{
				return (GiftMallItemInfo.LimitType)this._itemItem.quota;
			}
			return GiftMallItemInfo.LimitType.Forever;
		}

		// Token: 0x0600CF26 RID: 53030 RVA: 0x003C1D16 File Offset: 0x003BFF16
		public override int GetLimitNum()
		{
			return this._itemItem.number;
		}

		// Token: 0x0600CF27 RID: 53031 RVA: 0x003C1D23 File Offset: 0x003BFF23
		public override bool IsShow()
		{
			return this._itemItem.show != 0;
		}

		// Token: 0x0600CF28 RID: 53032 RVA: 0x003C1D33 File Offset: 0x003BFF33
		public override int GetID()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CF29 RID: 53033 RVA: 0x003C1D40 File Offset: 0x003BFF40
		public override int GetMidItemId()
		{
			return this._itemItem.miditem;
		}

		// Token: 0x0400E4CC RID: 58572
		private IShopCultivateInfo _itemItem;
	}
}
