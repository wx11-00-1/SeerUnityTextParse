using System;
using System.Collections.Generic;
using common;
using core.config.itemFilter;


namespace core.config
{
	// Token: 0x02001EA2 RID: 7842
	public class ItemFilterXMLInfo : ConfigManagerSingleton<ItemFilterXMLInfo>
	{

		// Token: 0x0600EA31 RID: 59953 RVA: 0x003E6C26 File Offset: 0x003E4E26
		

		// Token: 0x0600EA32 RID: 59954 RVA: 0x003E6C34 File Offset: 0x003E4E34
		

		// Token: 0x0600EA33 RID: 59955 RVA: 0x003E6C77 File Offset: 0x003E4E77
		public bool isCatch(int id)
		{
			return this.s_CatchIdList.IndexOf(id) != -1;
		}

		// Token: 0x0600EA34 RID: 59956 RVA: 0x003E6C8B File Offset: 0x003E4E8B
		public bool isBlood(int id)
		{
			return this.s_BloodIdList.IndexOf(id) != -1;
		}

		// Token: 0x0600EA35 RID: 59957 RVA: 0x003E6CA0 File Offset: 0x003E4EA0
		public int pporblood(int id)
		{
			if (this.s_HpList.ContainsKey(id) && this.s_HpList[id] > 0)
			{
				return 1;
			}
			if (this.s_PpList.ContainsKey(id) && this.s_PpList[id] > 0)
			{
				return 2;
			}
			if (this.s_RemoveStatList.ContainsKey(id) && this.s_RemoveStatList[id] >= 0)
			{
				return 3;
			}
			return 0;
		}

		// Token: 0x0600EA36 RID: 59958 RVA: 0x003E6D0B File Offset: 0x003E4F0B
		public bool isTopLevelBlood(int id)
		{
			return this.s_TopLevelBloodIdList.IndexOf(id) != -1;
		}

		// Token: 0x0600EA37 RID: 59959 RVA: 0x003E6D1F File Offset: 0x003E4F1F
		public bool isPeakJihadBlood(int id)
		{
			return this.s_TopLevelBloodIdList.IndexOf(id) != -1;
		}

		// Token: 0x0600EA38 RID: 59960 RVA: 0x003E6D33 File Offset: 0x003E4F33
		public bool isGoblinKingBattleStatusItem(int id)
		{
			return this.s_GoblinkingList.IndexOf(id) != -1;
		}

		// Token: 0x0600EA39 RID: 59961 RVA: 0x003E6D47 File Offset: 0x003E4F47
		public bool isHave(int id)
		{
			return this.s_AllIdList.IndexOf(id) != -1;
		}

		// Token: 0x0600EA3A RID: 59962 RVA: 0x003E6D5C File Offset: 0x003E4F5C
		public int getSort(int id)
		{
			int result;
			if (this.s_SortList.TryGetValue(id, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0600EA3B RID: 59963 RVA: 0x003E6D7C File Offset: 0x003E4F7C
		public int getSecSortValue(int id)
		{
			int num;
			if (this.s_HpList.TryGetValue(id, out num) && num > 0)
			{
				return num;
			}
			int num2;
			if (this.s_PpList.TryGetValue(id, out num2) && num2 > 0)
			{
				return num2;
			}
			int num3;
			if (this.s_RemoveStatList.TryGetValue(id, out num3) && num3 > 0)
			{
				return num3;
			}
			return 0;
		}

		// Token: 0x0400ED3D RID: 60733
		private List<int> s_AllIdList = new List<int>();

		// Token: 0x0400ED3E RID: 60734
		private List<int> s_BloodIdList = new List<int>();

		// Token: 0x0400ED3F RID: 60735
		private List<int> s_CatchIdList = new List<int>();

		// Token: 0x0400ED40 RID: 60736
		private List<int> s_StatusIdList = new List<int>();

		// Token: 0x0400ED41 RID: 60737
		private List<int> s_TopLevelBloodIdList = new List<int>();

		// Token: 0x0400ED42 RID: 60738
		private List<int> s_SpCatchIdList = new List<int>();

		// Token: 0x0400ED43 RID: 60739
		private List<int> s_SuperIdCatchIdList = new List<int>();

		// Token: 0x0400ED44 RID: 60740
		private Dictionary<int, int> s_BonusList = new Dictionary<int, int>();

		// Token: 0x0400ED45 RID: 60741
		private Dictionary<int, int> s_HpList = new Dictionary<int, int>();

		// Token: 0x0400ED46 RID: 60742
		private Dictionary<int, int> s_PpList = new Dictionary<int, int>();

		// Token: 0x0400ED47 RID: 60743
		private Dictionary<int, int> s_RemoveStatList = new Dictionary<int, int>();

		// Token: 0x0400ED48 RID: 60744
		private List<int> s_PeakJihadList = new List<int>();

		// Token: 0x0400ED49 RID: 60745
		private List<int> s_GoblinkingList = new List<int>();

		// Token: 0x0400ED4A RID: 60746
		private Dictionary<int, int> s_SortList = new Dictionary<int, int>();

		// Token: 0x0400ED4B RID: 60747
		private IRoot root;
	}
}
