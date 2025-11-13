using System;
using common;
using core.config;
using core.manager;
//using Game.Scripts.GameLogic.core.manager;

namespace core.model.mall
{
	// Token: 0x02001AF2 RID: 6898
	public abstract class AMallItemInfo
	{
		// Token: 0x0600CEA3 RID: 52899 RVA: 0x003C1332 File Offset: 0x003BF532
		public AMallItemInfo(object config)
		{
			this.config = config;
		}

		// Token: 0x0600CEA4 RID: 52900 RVA: 0x003C1341 File Offset: 0x003BF541
		public virtual int GetHorRedId()
		{
			return 0;
		}

		// Token: 0x0600CEA5 RID: 52901 RVA: 0x003C1344 File Offset: 0x003BF544
		public virtual int GetDiamondNum()
		{
			return 0;
		}

		// Token: 0x0600CEA6 RID: 52902 RVA: 0x003C1347 File Offset: 0x003BF547
		public virtual int GetProductId()
		{
			return 0;
		}

		// Token: 0x0600CEA7 RID: 52903 RVA: 0x003C134A File Offset: 0x003BF54A
		public virtual string GetIcon()
		{
			return string.Empty;
		}

		// Token: 0x0600CEA8 RID: 52904 RVA: 0x003C1351 File Offset: 0x003BF551
		public virtual string GetAtlas()
		{
			return string.Empty;
		}

		// Token: 0x0600CEA9 RID: 52905 RVA: 0x003C1358 File Offset: 0x003BF558
		public void SetBuyedNum(int num)
		{
			this.buyedNum = num;
		}

		// Token: 0x0600CEAA RID: 52906 RVA: 0x003C1361 File Offset: 0x003BF561
		public int GetBuyedNum()
		{
			return this.buyedNum;
		}

		// Token: 0x0600CEAB RID: 52907 RVA: 0x003C1369 File Offset: 0x003BF569
		public virtual void SetIsSoldOut(bool isSoldOut)
		{
			this.buyedNum = (isSoldOut ? 1 : 0);
		}

		// Token: 0x0600CEAC RID: 52908 RVA: 0x003C1378 File Offset: 0x003BF578
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x0600CEAD RID: 52909 RVA: 0x003C1380 File Offset: 0x003BF580
		public virtual bool HaveDiscount()
		{
			return false;
		}

		// Token: 0x0600CEAE RID: 52910 RVA: 0x003C1383 File Offset: 0x003BF583
		public virtual int GetDiscountPrice()
		{
			return this.GetPrice();
		}

		// Token: 0x0600CEAF RID: 52911 RVA: 0x003C138B File Offset: 0x003BF58B
		public virtual int GetPrice()
		{
			return 0;
		}

		// Token: 0x0600CEB0 RID: 52912
		public abstract int GetCostID();

		// Token: 0x0600CEB1 RID: 52913
		public abstract int GetCostType();

		// Token: 0x0600CEB2 RID: 52914 RVA: 0x003C1390 File Offset: 0x003BF590
		public virtual string GetCostIcon()
		{
			int costID = this.GetCostID();
			int costType = this.GetCostType();
			if (costType == 1)
			{
				return ClientConfig.getItemIcon(costID);
			}
			if (costType == 2)
			{
				return ClientConfig.getMarkPath(costID);
			}
			return string.Empty;
		}

		// Token: 0x0600CEB3 RID: 52915 RVA: 0x003C13C6 File Offset: 0x003BF5C6
		public virtual string GetCostIconAtlas()
		{
			return "images";
		}

		// Token: 0x0600CEB4 RID: 52916 RVA: 0x003C13CD File Offset: 0x003BF5CD
		public virtual int GetDiscount()
		{
			return 0;
		}

		// Token: 0x0600CEB5 RID: 52917 RVA: 0x003C13D0 File Offset: 0x003BF5D0
		public virtual bool IsFree()
		{
			return true;
		}

		// Token: 0x0600CEB6 RID: 52918 RVA: 0x003C13D3 File Offset: 0x003BF5D3
		public virtual bool IsRMB()
		{
			return this.GetCostID() == 200;
		}

		// Token: 0x0600CEB7 RID: 52919 RVA: 0x003C13E2 File Offset: 0x003BF5E2
		public bool IsSoldOut()
		{
			return this.GetRemainNum() <= 0;
		}

		// Token: 0x0600CEB8 RID: 52920
		public abstract int GetID();

		// Token: 0x0600CEB9 RID: 52921 RVA: 0x003C13F0 File Offset: 0x003BF5F0
		public virtual int GetRemainNum()
		{
			if (this.GetLimitNum() == 0)
			{
				return 999;
			}
			return this.GetLimitNum() - this.buyedNum;
		}

		// Token: 0x0600CEBA RID: 52922 RVA: 0x003C140D File Offset: 0x003BF60D
		public virtual GiftMallItemInfo.LimitType GetLimitType()
		{
			return GiftMallItemInfo.LimitType.Forever;
		}

		// Token: 0x0600CEBB RID: 52923
		public abstract int GetProductID();

		// Token: 0x0600CEBC RID: 52924
		public abstract int GetItemID();

		// Token: 0x0600CEBD RID: 52925
		public abstract int[] GetItemIDs();

		// Token: 0x0600CEBE RID: 52926 RVA: 0x003C1410 File Offset: 0x003BF610
		public virtual bool CanBuy()
		{
			//return (!this.HasTimeLimit() || this.endTime > SystemTimerManager.sysBJDate.getTime()) && !this.IsSoldOut();
			return true;
		}

		// Token: 0x0600CEBF RID: 52927
		public abstract int GetSort();

		// Token: 0x0600CEC0 RID: 52928 RVA: 0x003C143C File Offset: 0x003BF63C
		public virtual string GetLimitTime()
		{
			//if (this.GetLimitType() == GiftMallItemInfo.LimitType.Forever)
			//{
			//	return string.Empty;
			//}
			//long time = SystemTimerManager.sysBJDate.getTime();
			//long num = this.endTime - time;
			//if (num <= 0L)
			//{
			//	return "结束";
			//}
			//return SystemTimerManager.ConvertSecondToStrDay(num, true, true);
			return "";
		}

		// Token: 0x0600CEC1 RID: 52929 RVA: 0x003C147F File Offset: 0x003BF67F
		public virtual bool HasTimeLimit()
		{
			return false;
		}

		// Token: 0x0600CEC2 RID: 52930 RVA: 0x003C1482 File Offset: 0x003BF682
		public virtual int GetLimitNum()
		{
			return 1;
		}

		// Token: 0x0600CEC3 RID: 52931 RVA: 0x003C1488 File Offset: 0x003BF688
		public void SetData(ByteArray data)
		{
			int num = data.ReadSignedInt();
			uint num2 = data.ReadUnsignedInt();
			this.SetBuyedNum(num);
			//this.endTime = (long)((ulong)num2 + (ulong)SystemTimerManager.sysBJDate.getTime());
		}

		// Token: 0x0600CEC4 RID: 52932 RVA: 0x003C14BD File Offset: 0x003BF6BD
		public virtual bool IsShow()
		{
			return true;
		}

		// Token: 0x0600CEC5 RID: 52933
		public abstract int GetMidItemId();

		// Token: 0x0600CEC6 RID: 52934 RVA: 0x003C14C0 File Offset: 0x003BF6C0
		public virtual int GetOnceMax()
		{
			return 999;
		}

		// Token: 0x0400E4BD RID: 58557
		//public MallManager.MallTab tabType;

		// Token: 0x0400E4BE RID: 58558
		public object config;

		// Token: 0x0400E4BF RID: 58559
		protected int buyedNum;

		// Token: 0x0400E4C0 RID: 58560
		protected string name;

		// Token: 0x0400E4C1 RID: 58561
		protected long endTime;

		// Token: 0x0400E4C2 RID: 58562
		public int subTabType;
	}
}
