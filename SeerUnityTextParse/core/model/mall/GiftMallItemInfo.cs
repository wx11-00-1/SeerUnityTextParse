using System;
using core.config;

namespace core.model.mall
{
	// Token: 0x02001AFA RID: 6906
	public class GiftMallItemInfo : AMallItemInfo
	{
		// Token: 0x0600CF01 RID: 52993 RVA: 0x003C19C2 File Offset: 0x003BFBC2
		public GiftMallItemInfo(object config) : base(config)
		{
			this._itemItem = (config as IShopGiftInfo);
			this.name = this._itemItem.name;
		}

		// Token: 0x0600CF02 RID: 52994 RVA: 0x003C19E8 File Offset: 0x003BFBE8
		public override int GetHorRedId()
		{
			return 0;
		}

		// Token: 0x0600CF03 RID: 52995 RVA: 0x003C19EC File Offset: 0x003BFBEC
		public void SetData(int[] value)
		{
			int buyedNum = 0;
			int prop = this._itemItem.prop;
			if (prop <= 247680)
			{
				if (prop != 247483)
				{
					if (prop == 247680)
					{
						buyedNum = KTool.getBit(value[1], 27);
					}
				}
				else
				{
					buyedNum = KTool.getBit(value[1], 1);
				}
			}
			else if (prop != 247681)
			{
				if (prop != 251922)
				{
					if (prop == 258785)
					{
						buyedNum = KTool.getBit(value[2], 1);
					}
				}
				else
				{
					buyedNum = KTool.getBit(value[0], 5);
				}
			}
			else
			{
				buyedNum = KTool.getBit(value[1], 28);
			}
			base.SetBuyedNum(buyedNum);
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x003C1A7E File Offset: 0x003BFC7E
		public override bool IsFree()
		{
			return this._itemItem.price[0] == 100;
		}

		// Token: 0x0600CF05 RID: 52997 RVA: 0x003C1A91 File Offset: 0x003BFC91
		public override int GetSort()
		{
			return this._itemItem.sort;
		}

		// Token: 0x0600CF06 RID: 52998 RVA: 0x003C1A9E File Offset: 0x003BFC9E
		public override int GetItemID()
		{
			return this._itemItem.reward[0];
		}

		// Token: 0x0600CF07 RID: 52999 RVA: 0x003C1AAD File Offset: 0x003BFCAD
		public override int[] GetItemIDs()
		{
			return this._itemItem.reward;
		}

		// Token: 0x0600CF08 RID: 53000 RVA: 0x003C1ABA File Offset: 0x003BFCBA
		public override bool HaveDiscount()
		{
			return this._itemItem.discount > 0;
		}

		// Token: 0x0600CF09 RID: 53001 RVA: 0x003C1ACA File Offset: 0x003BFCCA
		public override int GetCostType()
		{
			return 1;
		}

		// Token: 0x0600CF0A RID: 53002 RVA: 0x003C1AD0 File Offset: 0x003BFCD0
		public override string GetCostIcon()
		{
			int[] price = this._itemItem.price;
			if (price[0] == 1)
			{
				return ClientConfig.getItemIcon(price[1]);
			}
			return this._itemItem.icon;
		}

		// Token: 0x0600CF0B RID: 53003 RVA: 0x003C1B03 File Offset: 0x003BFD03
		public override int GetProductID()
		{
			return this._itemItem.prop;
		}

		// Token: 0x0600CF0C RID: 53004 RVA: 0x003C1B10 File Offset: 0x003BFD10
		public override string GetIcon()
		{
			return this._itemItem.icon;
		}

		// Token: 0x0600CF0D RID: 53005 RVA: 0x003C1B1D File Offset: 0x003BFD1D
		public override string GetAtlas()
		{
			return this._itemItem.atlas;
		}

		// Token: 0x0600CF0E RID: 53006 RVA: 0x003C1B2A File Offset: 0x003BFD2A
		public int[] GetReward()
		{
			return this._itemItem.reward;
		}

		// Token: 0x0600CF0F RID: 53007 RVA: 0x003C1B37 File Offset: 0x003BFD37
		public override int GetDiscount()
		{
			return this._itemItem.discount;
		}

		// Token: 0x0600CF10 RID: 53008 RVA: 0x003C1B44 File Offset: 0x003BFD44
		public override int GetID()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CF11 RID: 53009 RVA: 0x003C1B51 File Offset: 0x003BFD51
		public override int GetPrice()
		{
			if (this._itemItem.price.Length == 1)
			{
				return this._itemItem.price[0];
			}
			return this._itemItem.price[2];
		}

		// Token: 0x0600CF12 RID: 53010 RVA: 0x003C1B7E File Offset: 0x003BFD7E
		public override int GetCostID()
		{
			return this._itemItem.price[1];
		}

		// Token: 0x0600CF13 RID: 53011 RVA: 0x003C1B8D File Offset: 0x003BFD8D
		public override int GetDiscountPrice()
		{
			if (this.HaveDiscount())
			{
				return this._itemItem.discountprice[2];
			}
			return this.GetPrice();
		}

		// Token: 0x0600CF14 RID: 53012 RVA: 0x003C1BAB File Offset: 0x003BFDAB
		public override GiftMallItemInfo.LimitType GetLimitType()
		{
			return (GiftMallItemInfo.LimitType)this._itemItem.quota;
		}

		// Token: 0x0600CF15 RID: 53013 RVA: 0x003C1BB8 File Offset: 0x003BFDB8
		public override bool HasTimeLimit()
		{
			GiftMallItemInfo.LimitType limitType = this.GetLimitType();
			return limitType == GiftMallItemInfo.LimitType.Daily || limitType == GiftMallItemInfo.LimitType.Weekly || limitType == GiftMallItemInfo.LimitType.Monthly || limitType == GiftMallItemInfo.LimitType.Activity;
		}

		// Token: 0x0600CF16 RID: 53014 RVA: 0x003C1BDE File Offset: 0x003BFDDE
		public override int GetLimitNum()
		{
			return this._itemItem.number;
		}

		// Token: 0x0600CF17 RID: 53015 RVA: 0x003C1BEB File Offset: 0x003BFDEB
		public override bool IsShow()
		{
			return this._itemItem.show != 0;
		}

		// Token: 0x0600CF18 RID: 53016 RVA: 0x003C1BFB File Offset: 0x003BFDFB
		public override int GetMidItemId()
		{
			return this._itemItem.miditem;
		}

		// Token: 0x0400E4CB RID: 58571
		private IShopGiftInfo _itemItem;

		// Token: 0x02004C1D RID: 19485
		public enum LimitType
		{
			// Token: 0x0401ACDF RID: 109791
			None,
			// Token: 0x0401ACE0 RID: 109792
			Daily,
			// Token: 0x0401ACE1 RID: 109793
			Weekly,
			// Token: 0x0401ACE2 RID: 109794
			Monthly,
			// Token: 0x0401ACE3 RID: 109795
			Forever,
			// Token: 0x0401ACE4 RID: 109796
			Activity
		}
	}
}
