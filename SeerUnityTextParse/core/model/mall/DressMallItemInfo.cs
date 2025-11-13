using System;
using common;
using core.config;
using core.manager;

namespace core.model.mall
{
	// Token: 0x02001AF9 RID: 6905
	public class DressMallItemInfo : AMallItemInfo
	{
		// Token: 0x0600CEED RID: 52973 RVA: 0x003C178B File Offset: 0x003BF98B
		public DressMallItemInfo(object config) : base(config)
		{
			this._itemItem = (config as IShopAttireInfo);
			this.name = this._itemItem.name;
		}

		// Token: 0x0600CEEE RID: 52974 RVA: 0x003C17B4 File Offset: 0x003BF9B4
		public int GetSuitID()
		{
			int type = this._itemItem.type;
			if (type - 1 <= 1)
			{
				return this._itemItem.suit;
			}
			if (type - 3 > 1)
			{
				return 0;
			}
			return this._itemItem.reward[0];
		}

		// Token: 0x0600CEEF RID: 52975 RVA: 0x003C17F6 File Offset: 0x003BF9F6
		public bool HasTag()
		{
			return this._itemItem.label == 1;
		}

		// Token: 0x0600CEF0 RID: 52976 RVA: 0x003C1806 File Offset: 0x003BFA06
		public new int GetType()
		{
			return this._itemItem.type;
		}

		// Token: 0x0600CEF1 RID: 52977 RVA: 0x003C1814 File Offset: 0x003BFA14
		public override string GetIcon()
		{
			switch (this._itemItem.type)
			{
			case 1:
			case 2:
				return ClientConfig.getSuitBodyPng(this._itemItem.suit);
			case 3:
				return ClientConfig.getMountIcon(this._itemItem.reward[0]);
			case 4:
				return ClientConfig.getClothSmallIcon(this._itemItem.reward[0]);
			default:
				return base.GetIcon();
			}
		}

		// Token: 0x0600CEF2 RID: 52978 RVA: 0x003C1884 File Offset: 0x003BFA84
		public override int GetProductID()
		{
			//if (ResetableSingleTon<MainManager>.Ins.actorInfo.isVip && this._itemItem.prop.Length > 1)
			//{
			//	return this._itemItem.prop[1];
			//}
			return this._itemItem.prop[0];
		}

		// Token: 0x0600CEF3 RID: 52979 RVA: 0x003C18C2 File Offset: 0x003BFAC2
		public override int GetItemID()
		{
			return this._itemItem.reward[0];
		}

		// Token: 0x0600CEF4 RID: 52980 RVA: 0x003C18D1 File Offset: 0x003BFAD1
		public override int[] GetItemIDs()
		{
			return this._itemItem.reward;
		}

		// Token: 0x0600CEF5 RID: 52981 RVA: 0x003C18DE File Offset: 0x003BFADE
		public override int GetSort()
		{
			return this._itemItem.sort;
		}

		// Token: 0x0600CEF6 RID: 52982 RVA: 0x003C18EB File Offset: 0x003BFAEB
		public override int GetPrice()
		{
			return this._itemItem.price[2];
		}

		// Token: 0x0600CEF7 RID: 52983 RVA: 0x003C18FA File Offset: 0x003BFAFA
		public override int GetCostID()
		{
			return this._itemItem.price[1];
		}

		// Token: 0x0600CEF8 RID: 52984 RVA: 0x003C1909 File Offset: 0x003BFB09
		public override int GetCostType()
		{
			return this._itemItem.price[0];
		}

		// Token: 0x0600CEF9 RID: 52985 RVA: 0x003C1918 File Offset: 0x003BFB18
		public override int GetDiscount()
		{
			if (!this.HaveDiscount())
			{
				return 0;
			}
			return 5;
		}

		// Token: 0x0600CEFA RID: 52986 RVA: 0x003C1925 File Offset: 0x003BFB25
		public override int GetDiscountPrice()
		{
			return this._itemItem.vipprice[2];
		}

		// Token: 0x0600CEFB RID: 52987 RVA: 0x003C1934 File Offset: 0x003BFB34
		public override bool IsShow()
		{
			return this._itemItem.show == 1;
		}

		// Token: 0x0600CEFC RID: 52988 RVA: 0x003C1944 File Offset: 0x003BFB44
		public override int GetMidItemId()
		{
			//if (ResetableSingleTon<MainManager>.Ins.actorInfo.isVip && this._itemItem.miditem.Length > 1)
			//{
			//	return this._itemItem.miditem[1];
			//}
			return this._itemItem.miditem[0];
		}

		// Token: 0x0600CEFD RID: 52989 RVA: 0x003C1982 File Offset: 0x003BFB82
		public override string GetCostIcon()
		{
			return ClientConfig.getItemIcon(this._itemItem.price[1]);
		}

		// Token: 0x0600CEFE RID: 52990 RVA: 0x003C1996 File Offset: 0x003BFB96
		public override bool HaveDiscount()
		{
			return this._itemItem.vip != 0;
		}

		// Token: 0x0600CEFF RID: 52991 RVA: 0x003C19A6 File Offset: 0x003BFBA6
		public override int GetID()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CF00 RID: 52992 RVA: 0x003C19B3 File Offset: 0x003BFBB3
		public int GetCostId()
		{
			return this._itemItem.price[1];
		}

		// Token: 0x0400E4CA RID: 58570
		private IShopAttireInfo _itemItem;
	}
}
