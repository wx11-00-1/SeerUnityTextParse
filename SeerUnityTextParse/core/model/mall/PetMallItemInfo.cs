using System;
using System.Linq;
using common;
//using common.SmallItem;
using core.config;
using core.config.effectIcon;
using core.manager;

namespace core.model.mall
{
	// Token: 0x02001AFC RID: 6908
	public class PetMallItemInfo : AMallItemInfo
	{
		// Token: 0x0600CF2A RID: 53034 RVA: 0x003C1D4D File Offset: 0x003BFF4D
		public PetMallItemInfo(object config) : base(config)
		{
			this._itemItem = (IShopElfInfo)config;
			this.name = this._itemItem.name;
		}

		// Token: 0x0600CF2B RID: 53035 RVA: 0x003C1D73 File Offset: 0x003BFF73
		public int GetMonsterID()
		{
			return int.Parse(this._itemItem.reward);
		}

		// Token: 0x0600CF2C RID: 53036 RVA: 0x003C1D85 File Offset: 0x003BFF85
		public override GiftMallItemInfo.LimitType GetLimitType()
		{
			return (GiftMallItemInfo.LimitType)this._itemItem.quota;
		}

		// Token: 0x0600CF2D RID: 53037 RVA: 0x003C1D92 File Offset: 0x003BFF92
		public override int GetSort()
		{
			return this._itemItem.sort;
		}

		// Token: 0x0600CF2E RID: 53038 RVA: 0x003C1D9F File Offset: 0x003BFF9F
		public override int GetCostID()
		{
			return this._itemItem.price[1];
		}

		// Token: 0x0600CF2F RID: 53039 RVA: 0x003C1DAE File Offset: 0x003BFFAE
		public override int GetCostType()
		{
			return this._itemItem.price[0];
		}

		// Token: 0x0600CF30 RID: 53040 RVA: 0x003C1DBD File Offset: 0x003BFFBD
		public override int GetID()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CF31 RID: 53041 RVA: 0x003C1DCA File Offset: 0x003BFFCA
		public override int GetProductID()
		{
			return this._itemItem.prop;
		}

		// Token: 0x0600CF32 RID: 53042 RVA: 0x003C1DD7 File Offset: 0x003BFFD7
		public override int GetItemID()
		{
			return int.Parse(this._itemItem.reward);
		}

		// Token: 0x0600CF33 RID: 53043 RVA: 0x003C1DEC File Offset: 0x003BFFEC
		public override int[] GetItemIDs()
		{
			return (from t in this._itemItem.reward.Split("|", StringSplitOptions.None)
			select int.Parse(t)).ToArray<int>();
		}

		// Token: 0x0600CF34 RID: 53044 RVA: 0x003C1E38 File Offset: 0x003C0038
		public override int GetPrice()
		{
			return this._itemItem.price[2];
		}

		// Token: 0x0600CF35 RID: 53045 RVA: 0x003C1E47 File Offset: 0x003C0047
		public override int GetDiscount()
		{
			return this._itemItem.discount;
		}

		// Token: 0x0600CF36 RID: 53046 RVA: 0x003C1E54 File Offset: 0x003C0054
		public override int GetDiscountPrice()
		{
			if (this._itemItem.discountprice == null || this._itemItem.discountprice.Length < 3)
			{
				return 0;
			}
			return this._itemItem.discountprice[2];
		}

		// Token: 0x0600CF37 RID: 53047 RVA: 0x003C1E82 File Offset: 0x003C0082
		public override bool CanBuy()
		{
			return true;
		}

		// Token: 0x0600CF38 RID: 53048 RVA: 0x003C1E85 File Offset: 0x003C0085
		public override bool IsShow()
		{
			return this._itemItem.show == 1;
		}

		// Token: 0x0600CF39 RID: 53049 RVA: 0x003C1E95 File Offset: 0x003C0095
		public override bool HaveDiscount()
		{
			return this._itemItem.discount > 0;
		}

		// Token: 0x0600CF3A RID: 53050 RVA: 0x003C1EA8 File Offset: 0x003C00A8
		public override bool HasTimeLimit()
		{
			GiftMallItemInfo.LimitType limitType = this.GetLimitType();
			return limitType == GiftMallItemInfo.LimitType.Daily || limitType == GiftMallItemInfo.LimitType.Weekly || limitType == GiftMallItemInfo.LimitType.Monthly || limitType == GiftMallItemInfo.LimitType.Activity;
		}

		// Token: 0x0600CF3B RID: 53051 RVA: 0x003C1ED0 File Offset: 0x003C00D0
		//public override string GetLimitTime()
		//{
		//	long time = SystemTimerManager.sysBJDate.getTime();
		//	long num = this.endTime - time;
		//	if (num <= 0L)
		//	{
		//		return "已结束";
		//	}
		//	return SystemTimerManager.ConvertSecondToStrDay(num, true, true);
		//}

		// Token: 0x0600CF3C RID: 53052 RVA: 0x003C1F04 File Offset: 0x003C0104
		//public SmallItemData[] GetExtraData()
		//{
		//	if (this._extraData == null)
		//	{
		//		this._extraData = new SmallItemData[3];
		//		this._extraData[0] = new SmallItemData_Skill(this._itemItem.gift[0]);
		//		int itemID = this.GetItemID();
		//		int upgradeIdx = ResetableSingleTon<EffectIconControl>.Ins.getAllEffctByPetId(itemID).FindIndex((IEffectItem t) => t.effectId == this._itemItem.gift[1]);
		//		this._extraData[1] = new SmallItemData_Effect(itemID, upgradeIdx);
		//		this._extraData[2] = new SmallItemData_Mark(this._itemItem.gift[2]);
		//	}
		//	return this._extraData;
		//}

		// Token: 0x0600CF3D RID: 53053 RVA: 0x003C1F92 File Offset: 0x003C0192
		public override int GetMidItemId()
		{
			return this._itemItem.miditem;
		}

		// Token: 0x0400E4CD RID: 58573
		private IShopElfInfo _itemItem;

		// Token: 0x0400E4CE RID: 58574
		//private SmallItemData[] _extraData;
	}
}
