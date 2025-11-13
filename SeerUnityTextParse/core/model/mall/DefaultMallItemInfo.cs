using System;
using core.config;

namespace core.model.mall
{
	// Token: 0x02001AF3 RID: 6899
	public class DefaultMallItemInfo : AMallItemInfo
	{
		// Token: 0x0600CEC7 RID: 52935 RVA: 0x003C14C7 File Offset: 0x003BF6C7
		public DefaultMallItemInfo(object config) : base(config)
		{
		}

		// Token: 0x0600CEC8 RID: 52936 RVA: 0x003C14D0 File Offset: 0x003BF6D0
		public override int GetCostID()
		{
			return 0;
		}

		// Token: 0x0600CEC9 RID: 52937 RVA: 0x003C14D3 File Offset: 0x003BF6D3
		public override int GetCostType()
		{
			return 0;
		}

		// Token: 0x0600CECA RID: 52938 RVA: 0x003C14D8 File Offset: 0x003BF6D8
		public override int GetID()
		{
			IShopRecommendInfo shopRecommendInfo = this.config as IShopRecommendInfo;
			if (shopRecommendInfo != null)
			{
				return shopRecommendInfo.id;
			}
			IRechargeInfo rechargeInfo = this.config as IRechargeInfo;
			if (rechargeInfo != null)
			{
				return rechargeInfo.id;
			}
			return 0;
		}

		// Token: 0x0600CECB RID: 52939 RVA: 0x003C1512 File Offset: 0x003BF712
		public override int GetProductID()
		{
			return 0;
		}

		// Token: 0x0600CECC RID: 52940 RVA: 0x003C1515 File Offset: 0x003BF715
		public override int GetItemID()
		{
			return 0;
		}

		// Token: 0x0600CECD RID: 52941 RVA: 0x003C1518 File Offset: 0x003BF718
		public override int[] GetItemIDs()
		{
			return Array.Empty<int>();
		}

		// Token: 0x0600CECE RID: 52942 RVA: 0x003C1520 File Offset: 0x003BF720
		public override int GetSort()
		{
			IShopRecommendInfo shopRecommendInfo = this.config as IShopRecommendInfo;
			if (shopRecommendInfo != null)
			{
				return shopRecommendInfo.sort;
			}
			return 0;
		}

		// Token: 0x0600CECF RID: 52943 RVA: 0x003C1544 File Offset: 0x003BF744
		public override int GetMidItemId()
		{
			return 0;
		}
	}
}
