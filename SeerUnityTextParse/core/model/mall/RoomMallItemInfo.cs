using System;
using System.Collections.Generic;
using common;
using core.config;
using core.manager;

namespace core.model.mall
{
	// Token: 0x02001AFF RID: 6911
	public class RoomMallItemInfo : AMallItemInfo
	{
		// Token: 0x0600CF60 RID: 53088 RVA: 0x003C24B4 File Offset: 0x003C06B4
		public RoomMallItemInfo(object config) : base(config)
		{
			this._itemItem = (config as IBaseShopInfo);
			//this._cost = ResetableSingleTon<ItemManager>.Ins.parseItem(this._itemItem.cost);
			this.name = this._itemItem.name;
		}

		// Token: 0x0600CF61 RID: 53089 RVA: 0x003C2500 File Offset: 0x003C0700
		public override int GetCostID()
		{
			return this._cost[0].id;
		}

		// Token: 0x0600CF62 RID: 53090 RVA: 0x003C2513 File Offset: 0x003C0713
		public override int GetCostType()
		{
			return this._cost[0].type;
		}

		// Token: 0x0600CF63 RID: 53091 RVA: 0x003C2526 File Offset: 0x003C0726
		public override int GetID()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CF64 RID: 53092 RVA: 0x003C2533 File Offset: 0x003C0733
		public override int GetItemID()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CF65 RID: 53093 RVA: 0x003C2540 File Offset: 0x003C0740
		public override int[] GetItemIDs()
		{
			return new int[]
			{
				this._itemItem.id
			};
		}

		// Token: 0x0600CF66 RID: 53094 RVA: 0x003C2556 File Offset: 0x003C0756
		public override int GetMidItemId()
		{
			return 0;
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x003C2559 File Offset: 0x003C0759
		public override int GetProductID()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x003C2566 File Offset: 0x003C0766
		public override int GetSort()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x003C2573 File Offset: 0x003C0773
		public bool IsVipOnly()
		{
			return this._itemItem.vipOnly > 0;
		}

		// Token: 0x0600CF6A RID: 53098 RVA: 0x003C2583 File Offset: 0x003C0783
		public override int GetPrice()
		{
			return this._cost[0].num;
		}

		// Token: 0x0600CF6B RID: 53099 RVA: 0x003C2596 File Offset: 0x003C0796
		public override int GetDiscountPrice()
		{
			return this.GetPrice();
		}

		// Token: 0x0600CF6C RID: 53100 RVA: 0x003C259E File Offset: 0x003C079E
		public override string GetIcon()
		{
			return ClientConfig.getFurnitureIcon(this._itemItem.id);
		}

		// Token: 0x0600CF6D RID: 53101 RVA: 0x003C25B0 File Offset: 0x003C07B0
		public override int GetLimitNum()
		{
			return this._itemItem.max;
		}

		// Token: 0x0600CF6E RID: 53102 RVA: 0x003C25C0 File Offset: 0x003C07C0
		public override int GetRemainNum()
		{
			//FitmentInfo fitmentInfo;
			//RoomManager.curRoomFurnitureMap.TryGetValue(this.GetItemID(), out fitmentInfo);
			//if (fitmentInfo != null)
			//{
			//	return this.GetLimitNum() - fitmentInfo.allCount;
			//}
			return base.GetRemainNum();
		}

		// Token: 0x0600CF6F RID: 53103 RVA: 0x003C25F7 File Offset: 0x003C07F7
		public override int GetOnceMax()
		{
			if (this._itemItem.max > 0)
			{
				return this._itemItem.max;
			}
			return base.GetOnceMax();
		}

		// Token: 0x0600CF70 RID: 53104 RVA: 0x003C2619 File Offset: 0x003C0819
		public int GetOnceCount()
		{
			if (this._itemItem.num > 0)
			{
				return this._itemItem.num;
			}
			return 1;
		}

		// Token: 0x0400E4D4 RID: 58580
		private IBaseShopInfo _itemItem;

		// Token: 0x0400E4D5 RID: 58581
		private List<ItemParseInfo> _cost;
	}
}
