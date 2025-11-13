using System;
using System.Collections.Generic;
using common;
//using common.SmallItem;
using core.config;
using core.config.achievements;
using core.config.effectIcon;
using core.manager;


namespace core.model.mall
{
	// Token: 0x02001AFD RID: 6909
	public class PveResourceMallItemInfo : GrowMallItemInfo
	{
		// Token: 0x0600CF3F RID: 53055 RVA: 0x003C1FB8 File Offset: 0x003C01B8
		public PveResourceMallItemInfo(object config) : base(config)
		{
			this._itemItem = (config as IExchangeCltInfo);
			int realid = this._itemItem.realid;
			switch (this._itemItem.type)
			{
			case 1:
				this.name = ResetableSingleTon<ItemXMLInfo>.Ins.getName(realid);
				break;
			case 2:
				this.name = ResetableSingleTon<ItemXMLInfo>.Ins.getName(realid);
				break;
			case 4:
				this.name = ResetableSingleTon<PetXMLInfo>.Ins.getName(realid);
				break;
			case 5:
			{
				//int branchId = (int)Mathf.Floor((float)realid / 100f);
				//int ruleId = realid % 100;
				//IRuleItem rule = ResetableSingleTon<AchieveXMLInfo>.Ins.getRule(branchId, ruleId);
				//this.name = ((!string.IsNullOrEmpty(rule.achName)) ? rule.achName : ResetableSingleTon<AchieveXMLInfo>.Ins.getBranchById(branchId).Desc);
				break;
			}
			}
			this._rewardIds = new int[]
			{
				realid
			};
		}

		// Token: 0x0600CF40 RID: 53056 RVA: 0x003C20AC File Offset: 0x003C02AC
		public override string GetIcon()
		{
			int itemType = this.GetItemType();
			int itemID = this.GetItemID();
			switch (itemType)
			{
			case 1:
				return ClientConfig.getItemIcon(itemID);
			case 2:
				return ClientConfig.getMarkPath(itemID);
			case 4:
				return ClientConfig.getPetHalfIcon(itemID);
			case 5:
			{
						//int branchId = (int)Mathf.Floor((float)itemID / 100f);
						int branchId = 100;

                        int ruleId = itemID % 100;
				return ClientConfig.getAchieveIcon(ResetableSingleTon<AchieveXMLInfo>.Ins.getRule(branchId, ruleId).proicon);
			}
			}
			return base.GetIcon();
		}

		// Token: 0x0600CF41 RID: 53057 RVA: 0x003C212C File Offset: 0x003C032C
		public override int GetSort()
		{
			if (this._itemItem.top > 0)
			{
				return this._itemItem.top;
			}
			if (this.HaveDiscount())
			{
				return int.MaxValue - this._itemItem.id;
			}
			return -this._itemItem.id;
		}

		// Token: 0x0600CF42 RID: 53058 RVA: 0x003C2179 File Offset: 0x003C0379
		public override int GetItemType()
		{
			return this._itemItem.type;
		}

		// Token: 0x0600CF43 RID: 53059 RVA: 0x003C2186 File Offset: 0x003C0386
		public override int GetProductID()
		{
			return 0;
		}

		// Token: 0x0600CF44 RID: 53060 RVA: 0x003C2189 File Offset: 0x003C0389
		public override int GetItemID()
		{
			return this._itemItem.realid;
		}

		// Token: 0x0600CF45 RID: 53061 RVA: 0x003C2196 File Offset: 0x003C0396
		public int GetRuleId()
		{
			return this._itemItem.realid % 100;
		}

		// Token: 0x0600CF46 RID: 53062 RVA: 0x003C21A6 File Offset: 0x003C03A6
		public override int[] GetItemIDs()
		{
			return this._rewardIds;
		}

		// Token: 0x0600CF47 RID: 53063 RVA: 0x003C21AE File Offset: 0x003C03AE
		public override int GetCostType()
		{
			return this._itemItem.cointype;
		}

		// Token: 0x0600CF48 RID: 53064 RVA: 0x003C21BB File Offset: 0x003C03BB
		public override string GetCostIcon()
		{
			return ClientConfig.getItemIcon(this.GetCostID());
		}

		// Token: 0x0600CF49 RID: 53065 RVA: 0x003C21C8 File Offset: 0x003C03C8
		public override int GetPrice()
		{
			return this._itemItem.price;
		}

		// Token: 0x0600CF4A RID: 53066 RVA: 0x003C21D5 File Offset: 0x003C03D5
		public override int GetCostID()
		{
			return this._itemItem.coinid;
		}

		// Token: 0x0600CF4B RID: 53067 RVA: 0x003C21E2 File Offset: 0x003C03E2
		public override bool CanBuy()
		{
			return true;
		}

		// Token: 0x0600CF4C RID: 53068 RVA: 0x003C21E5 File Offset: 0x003C03E5
		public override GiftMallItemInfo.LimitType GetLimitType()
		{
			if (this._itemItem.isjustone == 1)
			{
				return GiftMallItemInfo.LimitType.Forever;
			}
			return (GiftMallItemInfo.LimitType)this._itemItem.Limittype;
		}

		// Token: 0x0600CF4D RID: 53069 RVA: 0x003C2202 File Offset: 0x003C0402
		public override int GetRemainNum()
		{
			if (this.GetLimitNum() == 0 && this._itemItem.BitSetId == 0 && this._itemItem.UserInfoId == 0)
			{
				return 999;
			}
			return this.GetLimitNum() - this.buyedNum;
		}

		// Token: 0x0600CF4E RID: 53070 RVA: 0x003C223C File Offset: 0x003C043C
		public override int GetLimitNum()
		{
			if (this.GetItemType() == 5)
			{
				return 1;
			}
			if (this._itemItem.isjustone == 1)
			{
				return 1;
			}
			if (this.HasTimeLimit())
			{
				//return Mathf.Max(1, this._itemItem.LimitCnt);
			}
			return this._itemItem.LimitCnt;
		}

		// Token: 0x0600CF4F RID: 53071 RVA: 0x003C2289 File Offset: 0x003C0489
		public override bool HasTimeLimit()
		{
			return this.GetLimitType() > GiftMallItemInfo.LimitType.None;
		}

		// Token: 0x0600CF50 RID: 53072 RVA: 0x003C2294 File Offset: 0x003C0494
		public override bool IsShow()
		{
			return true;
		}

		// Token: 0x0600CF51 RID: 53073 RVA: 0x003C2297 File Offset: 0x003C0497
		public override int GetID()
		{
			return this._itemItem.id;
		}

		// Token: 0x0600CF52 RID: 53074 RVA: 0x003C22A4 File Offset: 0x003C04A4
		public override int GetMidItemId()
		{
			return 0;
		}

		// Token: 0x0600CF53 RID: 53075 RVA: 0x003C22A8 File Offset: 0x003C04A8
		//public SmallItemData[] GetExtraData()
		//{
		//	if (this._extraData == null)
		//	{
		//		this._extraData = new SmallItemData[3];
		//		List<SmallItemData> list = new List<SmallItemData>();
		//		string monappend = this._itemItem.monappend;
		//		string[] monappendArr = monappend.Split('_', StringSplitOptions.None);
		//		int itemID = this.GetItemID();
		//		if (monappendArr.Length != 0)
		//		{
		//			List<IEffectItem> allEffctByPetId = ResetableSingleTon<EffectIconControl>.Ins.getAllEffctByPetId(itemID);
		//			if (allEffctByPetId == null || allEffctByPetId.Count == 0)
		//			{
		//				this._extraData[1] = null;
		//			}
		//			else
		//			{
		//				int upgradeIdx = allEffctByPetId.FindIndex((IEffectItem t) => t.effectId == int.Parse(monappendArr[0]));
		//				this._extraData[1] = new SmallItemData_Effect(itemID, upgradeIdx);
		//			}
		//		}
		//		if (monappendArr.Length > 1)
		//		{
		//			this._extraData[0] = new SmallItemData_Skill(int.Parse(monappendArr[1]));
		//		}
		//		if (monappendArr.Length > 2)
		//		{
		//			this._extraData[2] = new SmallItemData_Mark(int.Parse(monappendArr[2]));
		//		}
		//		for (int i = 0; i < 3; i++)
		//		{
		//			if (this._extraData[i] != null)
		//			{
		//				list.Add(this._extraData[i]);
		//			}
		//		}
		//		this._extraData = list.ToArray();
		//	}
		//	return this._extraData;
		//}

		// Token: 0x0600CF54 RID: 53076 RVA: 0x003C23D3 File Offset: 0x003C05D3
		public void SetMarkDiscount(int discount)
		{
			this._markDiscount = discount;
		}

		// Token: 0x0600CF55 RID: 53077 RVA: 0x003C23DC File Offset: 0x003C05DC
		public int GetMarkDiscount()
		{
			return this._markDiscount;
		}

		// Token: 0x0600CF56 RID: 53078 RVA: 0x003C23E4 File Offset: 0x003C05E4
		public override bool HaveDiscount()
		{
			return this.GetItemType() == 2 && this._markDiscount > 0;
		}

		// Token: 0x0600CF57 RID: 53079 RVA: 0x003C23FA File Offset: 0x003C05FA
		public override int GetDiscountPrice()
		{
			if (this.GetItemType() == 2 && this.HaveDiscount())
			{
				return this.GetPrice() * this._markDiscount / 1000;
			}
			return this.GetPrice();
		}

		// Token: 0x0600CF58 RID: 53080 RVA: 0x003C2427 File Offset: 0x003C0627
		//internal int GetBranchId()
		//{
		//	return (int)Mathf.Floor((float)this.GetItemID() / 100f);
		//}

		// Token: 0x0600CF59 RID: 53081 RVA: 0x003C243C File Offset: 0x003C063C
		public override int GetOnceMax()
		{
			if (this._itemItem.batch > 0)
			{
				return this._itemItem.batch;
			}
			return base.GetOnceMax();
		}

		// Token: 0x0600CF5A RID: 53082 RVA: 0x003C245E File Offset: 0x003C065E
		public int GetOnceCount()
		{
			if (this._itemItem.count > 0)
			{
				return this._itemItem.count;
			}
			return 1;
		}

		// Token: 0x0400E4CF RID: 58575
		private IExchangeCltInfo _itemItem;

		// Token: 0x0400E4D0 RID: 58576
		private int[] _rewardIds;

		// Token: 0x0400E4D1 RID: 58577
		//private SmallItemData[] _extraData;

		// Token: 0x0400E4D2 RID: 58578
		private int _markDiscount;

		// Token: 0x02004C1F RID: 19487
		public enum PveResourceItemType
		{
			// Token: 0x0401ACE8 RID: 109800
			Item = 1,
			// Token: 0x0401ACE9 RID: 109801
			MintMark,
			// Token: 0x0401ACEA RID: 109802
			Suit,
			// Token: 0x0401ACEB RID: 109803
			Monsters,
			// Token: 0x0401ACEC RID: 109804
			Achievement,
			// Token: 0x0401ACED RID: 109805
			FifthSkill,
			// Token: 0x0401ACEE RID: 109806
			Trait,
			// Token: 0x0401ACEF RID: 109807
			Head,
			// Token: 0x0401ACF0 RID: 109808
			HeadFrame
		}
	}
}
