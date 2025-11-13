using System;
using core.config.skin_shop;
//using module.mall;

namespace core.model.mall
{
	// Token: 0x02001B00 RID: 6912
	public class SkinMallItemInfo : AMallItemInfo
	{
		// Token: 0x0600CF71 RID: 53105 RVA: 0x003C2636 File Offset: 0x003C0836
		public SkinMallItemInfo(object config) : base(config)
		{
			this._skinItem = (config as ISkinItem);
			this.name = this._skinItem.Name;
		}

		// Token: 0x0600CF72 RID: 53106 RVA: 0x003C265C File Offset: 0x003C085C
		public override bool HaveDiscount()
		{
			return this._skinItem.OriginalPrice != 0;
		}

		// Token: 0x0600CF73 RID: 53107 RVA: 0x003C266C File Offset: 0x003C086C
		public override int GetSort()
		{
			return this._skinItem.Batch;
		}

		// Token: 0x0600CF74 RID: 53108 RVA: 0x003C2679 File Offset: 0x003C0879
		public override int GetMidItemId()
		{
			return 0;
		}

		// Token: 0x0600CF75 RID: 53109 RVA: 0x003C267C File Offset: 0x003C087C
		public override int GetDiamondNum()
		{
			return this._skinItem.DiamondPrice;
		}

		// Token: 0x0600CF76 RID: 53110 RVA: 0x003C2689 File Offset: 0x003C0889
		public override int GetProductId()
		{
			return this._skinItem.ProductId;
		}

		// Token: 0x0600CF77 RID: 53111 RVA: 0x003C2696 File Offset: 0x003C0896
		public override int GetDiscountPrice()
		{
			return this._skinItem.CardPrice;
		}

		// Token: 0x0600CF78 RID: 53112 RVA: 0x003C26A3 File Offset: 0x003C08A3
		public override int GetPrice()
		{
			if (this._skinItem.OriginalPrice > 0)
			{
				return this._skinItem.OriginalPrice;
			}
			return this._skinItem.CardPrice;
		}

		// Token: 0x0600CF79 RID: 53113 RVA: 0x003C26CA File Offset: 0x003C08CA
		public override int GetCostID()
		{
			return 1723116;
		}

		// Token: 0x0600CF7A RID: 53114 RVA: 0x003C26D1 File Offset: 0x003C08D1
		public override int GetCostType()
		{
			//return MallPanel.POP_TYPE_ITEM;
			return 0;
		}

		// Token: 0x0600CF7B RID: 53115 RVA: 0x003C26D8 File Offset: 0x003C08D8
		public override int GetID()
		{
			return this._skinItem.ID;
		}

		// Token: 0x0600CF7C RID: 53116 RVA: 0x003C26E5 File Offset: 0x003C08E5
		public override int GetProductID()
		{
			return this._skinItem.ID;
		}

		// Token: 0x0600CF7D RID: 53117 RVA: 0x003C26F2 File Offset: 0x003C08F2
		public override int GetItemID()
		{
			return this._skinItem.SkinID;
		}

		// Token: 0x0600CF7E RID: 53118 RVA: 0x003C26FF File Offset: 0x003C08FF
		public override int[] GetItemIDs()
		{
			return new int[]
			{
				this._skinItem.SkinID
			};
		}

		// Token: 0x0600CF7F RID: 53119 RVA: 0x003C2715 File Offset: 0x003C0915
		public int GetSkinID()
		{
			return this._skinItem.SkinID;
		}

		// Token: 0x0600CF80 RID: 53120 RVA: 0x003C2722 File Offset: 0x003C0922
		public int GetDayLeft()
		{
			return this._skinItem.dayLeft;
		}

		// Token: 0x0600CF81 RID: 53121 RVA: 0x003C272F File Offset: 0x003C092F
		public override int GetDiscount()
		{
			return 10 * this.GetDiscountPrice() / this.GetPrice();
		}

		// Token: 0x0400E4D6 RID: 58582
		private ISkinItem _skinItem;
	}
}
