using System;
using System.Collections.Generic;
using common;
using core.config.achievements;
using core.config.medals;
//using Cysharp.Threading.Tasks;
//using Cysharp.Threading.Tasks.CompilerServices;

namespace core.config
{
	// Token: 0x02001C7E RID: 7294
	public class AchieveXMLInfo : ConfigManagerSingleton<AchieveXMLInfo>
	{
		// Token: 0x0600D27C RID: 53884 RVA: 0x003C8195 File Offset: 0x003C6395
		

		// Token: 0x0600D27F RID: 53887 RVA: 0x003C8230 File Offset: 0x003C6430
		public int getAchievePoint(int speNameBonus)
		{
			IRuleItem ruleItem;
			if (this.titleRules.TryGetValue(speNameBonus, out ruleItem))
			{
				return ruleItem.AchievementPoint;
			}
			return 0;
		}

		// Token: 0x0600D280 RID: 53888 RVA: 0x003C8258 File Offset: 0x003C6458
		public string getOriginalTitle(int speNameBonus)
		{
			IRuleItem ruleItem;
			if (this.titleRules.TryGetValue(speNameBonus, out ruleItem))
			{
				return ruleItem.title;
			}
			return "无称号";
		}

		// Token: 0x0600D281 RID: 53889 RVA: 0x003C8281 File Offset: 0x003C6481
		public string getTitle(int speNameBonus)
		{
			return this.getOriginalTitle(speNameBonus).Replace("|", string.Empty);
		}

		// Token: 0x0600D282 RID: 53890 RVA: 0x003C829C File Offset: 0x003C649C
		public int getTitleIconId(int speNameBonus)
		{
			IRuleItem ruleItem;
			if (this.titleRules.TryGetValue(speNameBonus, out ruleItem))
			{
				return ruleItem.proicon;
			}
			return 0;
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x003C82C4 File Offset: 0x003C64C4
		public int getTitleColor(int speNameBonus)
		{
			IRuleItem ruleItem;
			//if (this.titleRules.TryGetValue(speNameBonus, out ruleItem) && ruleItem.titleColor.IsValidStr())
            if (this.titleRules.TryGetValue(speNameBonus, out ruleItem))
                {
				return Convert.ToInt32(ruleItem.titleColor, 16);
			}
			return 0;
		}

		// Token: 0x0600D284 RID: 53892 RVA: 0x003C8300 File Offset: 0x003C6500
		public bool isAbilityTitle(int speNameBonus)
		{
			IRuleItem ruleItem;
			return this.titleRules.TryGetValue(speNameBonus, out ruleItem) && ruleItem.AbilityTitle > 0;
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x003C832C File Offset: 0x003C652C
		public string getTitleDesc(int speNameBonus)
		{
			IRuleItem ruleItem;
			if (this.titleRules.TryGetValue(speNameBonus, out ruleItem))
			{
				return ruleItem.Desc;
			}
			return string.Empty;
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x003C8358 File Offset: 0x003C6558
		public string getTitleEffDesc(int speNameBonus)
		{
			IRuleItem ruleItem;
			if (this.titleRules.TryGetValue(speNameBonus, out ruleItem) && ruleItem.abtext != null && ruleItem.abtext.Length > 0)
			{
				return ruleItem.abtext;
			}
			return "无称号特效";
		}

		// Token: 0x0600D287 RID: 53895 RVA: 0x003C8398 File Offset: 0x003C6598
		public int getTypeByBranchId(int branchId)
		{
			for (int i = 0; i < this.s_Types.Count; i++)
			{
				ITypeItem typeItem = this.s_Types[i];
				for (int j = 0; j < typeItem.Branches.Length; j++)
				{
					IBranchesItem branchesItem = typeItem.Branches[j];
					for (int k = 0; k < branchesItem.Branch.Length; k++)
					{
						if (branchesItem.Branch[k].ID == branchId)
						{
							return typeItem.ID;
						}
					}
				}
			}
			return 0;
		}

		// Token: 0x0600D288 RID: 53896 RVA: 0x003C8414 File Offset: 0x003C6614
		public IBranchItem getBranchById(int branchId)
		{
			IBranchItem result;
			if (this.cacheBranchById.TryGetValue(branchId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0600D289 RID: 53897 RVA: 0x003C8434 File Offset: 0x003C6634
		public IRuleItem getRule(int branchId, int ruleId)
		{
			if (branchId == 0)
			{
				return null;
			}
			IBranchItem branchById = this.getBranchById(branchId);
			if (branchById != null && branchById.Rule != null)
			{
				for (int i = 0; i < branchById.Rule.Length; i++)
				{
					IRuleItem ruleItem = branchById.Rule[i];
					if (ruleItem.ID == ruleId)
					{
						ruleItem.branchId = branchId;
						return ruleItem;
					}
				}
			}
			return null;
		}

		// Token: 0x0600D28A RID: 53898 RVA: 0x003C8488 File Offset: 0x003C6688
		public ITypeItem getBranchesByType(int type)
		{
			for (int i = 0; i < this.s_Types.Count; i++)
			{
				ITypeItem typeItem = this.s_Types[i];
				if (typeItem.ID == type)
				{
					return typeItem;
				}
			}
			return null;
		}

		// Token: 0x0600D28B RID: 53899 RVA: 0x003C84C4 File Offset: 0x003C66C4
		public IMedalItem getAchieveInfo(int achievePoint)
		{
			IMedalItem[] medal = ResetableSingleTon<core.config.medals.IRootInterface>.Ins.medals.medal;
			for (int i = medal.Length - 1; i >= 0; i--)
			{
				if (medal[i] != null && medal[i].achievepoint <= achievePoint)
				{
					return medal[i];
				}
			}
			return null;
		}

		// Token: 0x0600D28C RID: 53900 RVA: 0x003C8506 File Offset: 0x003C6706
		public IMedalItem[] getAllAchieveInfo()
		{
			return ResetableSingleTon<core.config.medals.IRootInterface>.Ins.medals.medal;
		}

		// Token: 0x0600D28D RID: 53901 RVA: 0x003C8517 File Offset: 0x003C6717
		public List<IRuleItem> getAllRules()
		{
			return this.s_RuleMap;
		}

		// Token: 0x0400E4D8 RID: 58584
		private IAchievementRules s_Data;

		// Token: 0x0400E4D9 RID: 58585
		private Dictionary<int, ITypeItem> s_Types;

		// Token: 0x0400E4DA RID: 58586
		private readonly Dictionary<int, IBranchItem> cacheBranchById = new Dictionary<int, IBranchItem>(163);

		// Token: 0x0400E4DB RID: 58587
		private List<IRuleItem> s_RuleMap = new List<IRuleItem>(1327);

		// Token: 0x0400E4DC RID: 58588
		public readonly Dictionary<int, IRuleItem> titleRules = new Dictionary<int, IRuleItem>(631);
	}
}
