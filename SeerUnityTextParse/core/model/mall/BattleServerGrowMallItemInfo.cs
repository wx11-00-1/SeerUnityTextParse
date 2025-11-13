using System;
using common;
using core.config;

namespace core.model.mall
{
	// Token: 0x02001AF8 RID: 6904
	public class BattleServerGrowMallItemInfo : AMallItemInfo
	{
		// Token: 0x0600CEDB RID: 52955 RVA: 0x003C1644 File Offset: 0x003BF844
		public BattleServerGrowMallItemInfo(object config) : base(config)
		{
			this._itemItem = (config as IBattleServerShopInfo);
			if (this._itemItem != null)
			{
				this.name = ResetableSingleTon<ItemXMLInfo>.Ins.getName(this._itemItem.realid);
			}
		}

		// Token: 0x0600CEDC RID: 52956 RVA: 0x003C167C File Offset: 0x003BF87C
		public override string GetIcon()
		{
			int type = this._itemItem.type;
			int realid = this._itemItem.realid;
			if (type == 1)
			{
				return ClientConfig.getItemIcon(realid);
			}
			if (type == 2)
			{
				return ClientConfig.getMarkPath(realid);
			}
			return base.GetIcon();
		}

		// Token: 0x0600CEDD RID: 52957 RVA: 0x003C16BD File Offset: 0x003BF8BD
		public override int GetSort()
		{
			return 0;
		}

		// Token: 0x0600CEDE RID: 52958 RVA: 0x003C16C0 File Offset: 0x003BF8C0
		public virtual int GetItemType()
		{
			return this._itemItem.type;
		}

		// Token: 0x0600CEDF RID: 52959 RVA: 0x003C16CD File Offset: 0x003BF8CD
		public override int GetProductID()
		{
			return 0;
		}

		// Token: 0x0600CEE0 RID: 52960 RVA: 0x003C16D0 File Offset: 0x003BF8D0
		public override int GetItemID()
		{
			return this._itemItem.realid;
		}

		// Token: 0x0600CEE1 RID: 52961 RVA: 0x003C16DD File Offset: 0x003BF8DD
		public override int[] GetItemIDs()
		{
			return new int[]
			{
				1,
				this._itemItem.realid,
				this._itemItem.count
			};
		}

		// Token: 0x0600CEE2 RID: 52962 RVA: 0x003C1705 File Offset: 0x003BF905
		public override int GetCostType()
		{
			return this._itemItem.cointype;
		}

		// Token: 0x0600CEE3 RID: 52963 RVA: 0x003C1712 File Offset: 0x003BF912
		public override string GetCostIcon()
		{
			return ClientConfig.getItemIcon(this._itemItem.coinid);
		}

		// Token: 0x0600CEE4 RID: 52964 RVA: 0x003C1724 File Offset: 0x003BF924
		public override int GetPrice()
		{
			return this._itemItem.price;
		}

		// Token: 0x0600CEE5 RID: 52965 RVA: 0x003C1731 File Offset: 0x003BF931
		public override int GetCostID()
		{
			return this._itemItem.coinid;
		}

		// Token: 0x0600CEE6 RID: 52966 RVA: 0x003C173E File Offset: 0x003BF93E
		public override bool CanBuy()
		{
			return !base.IsSoldOut();
		}

		// Token: 0x0600CEE7 RID: 52967 RVA: 0x003C174B File Offset: 0x003BF94B
		public override GiftMallItemInfo.LimitType GetLimitType()
		{
			if (this._itemItem.Limittype != 1)
			{
				return GiftMallItemInfo.LimitType.None;
			}
			return GiftMallItemInfo.LimitType.Forever;
		}

		// Token: 0x0600CEE8 RID: 52968 RVA: 0x003C175E File Offset: 0x003BF95E
		public override int GetLimitNum()
		{
			return this._itemItem.Limitcount;
		}

		// Token: 0x0600CEE9 RID: 52969 RVA: 0x003C176B File Offset: 0x003BF96B
		public override bool IsShow()
		{
			return true;
		}

		// Token: 0x0600CEEA RID: 52970 RVA: 0x003C176E File Offset: 0x003BF96E
		public override int GetID()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CEEB RID: 52971 RVA: 0x003C177B File Offset: 0x003BF97B
		public override int GetMidItemId()
		{
			return 0;
		}

		// Token: 0x0600CEEC RID: 52972 RVA: 0x003C177E File Offset: 0x003BF97E
		public int GetBuyCount()
		{
			return this._itemItem.count;
		}

		// Token: 0x0400E4C9 RID: 58569
		private IBattleServerShopInfo _itemItem;
	}
}
