using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.equip;


namespace core.config
{
	// Token: 0x02001EA3 RID: 7843
	public class ItemSeXMLInfo : ConfigManagerSingleton<ItemSeXMLInfo>
	{
		// Token: 0x0600EA3D RID: 59965 RVA: 0x003E6E79 File Offset: 0x003E5079
		

		// Token: 0x0600EA3E RID: 59966 RVA: 0x003E6E91 File Offset: 0x003E5091
		

		// Token: 0x0600EA3F RID: 59967 RVA: 0x003E6E9F File Offset: 0x003E509F
		public bool IsEquip(int id)
		{
			return this.s_EquipDict.ContainsKey(id);
		}

		// Token: 0x0600EA40 RID: 59968 RVA: 0x003E6EB0 File Offset: 0x003E50B0
		

		// Token: 0x0600EA41 RID: 59969 RVA: 0x003E6EF4 File Offset: 0x003E50F4
		public int getQuality(int id)
		{
			IEquipItem equipItem;
			if (this.s_EquipDict.TryGetValue(id, out equipItem))
			{
				return equipItem.Quality;
			}
			return 0;
		}

		// Token: 0x0600EA42 RID: 59970 RVA: 0x003E6F1C File Offset: 0x003E511C
		public string getItemDes(int id, int lv)
		{
			string result = string.Empty;
			IEquipItem equipItem;
			if (this.s_EquipDict.TryGetValue(id, out equipItem))
			{
				foreach (IRankItem rankItem in equipItem.Rank)
				{
					if (rankItem.Lv == lv)
					{
						result = rankItem.Desc;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600EA43 RID: 59971 RVA: 0x003E6F70 File Offset: 0x003E5170
		public int getSuitId(int id)
		{
			IEquipItem equipItem;
			if (this.s_EquipDict.TryGetValue(id, out equipItem))
			{
				return equipItem.SuitID;
			}
			return 0;
		}

		// Token: 0x0600EA44 RID: 59972 RVA: 0x003E6F98 File Offset: 0x003E5198
		public string getSuitDes(int id)
		{
			IEquipItem equipItem;
			if (this.s_EquipDict.TryGetValue(id, out equipItem))
			{
				return equipItem.Desc;
			}
			return string.Empty;
		}

		// Token: 0x0600EA45 RID: 59973 RVA: 0x003E6FC4 File Offset: 0x003E51C4
		public string getSuitEff(int sid)
		{
			IEquipItem equipItem;
			if (this.s_EquipSuitDict.TryGetValue(sid, out equipItem))
			{
				return equipItem.Desc;
			}
			return string.Empty;
		}

		// Token: 0x0600EA46 RID: 59974 RVA: 0x003E6FED File Offset: 0x003E51ED
		public bool getIsEffSuit(int sid)
		{
			return this.s_EquipSuitDict.ContainsKey(sid);
		}

		// Token: 0x0600EA47 RID: 59975 RVA: 0x003E6FFB File Offset: 0x003E51FB
		public int[] getAllAbilitySuit()
		{
			return this.s_EquipSuitDict.Keys.ToArray<int>();
		}

		// Token: 0x0600EA48 RID: 59976 RVA: 0x003E7010 File Offset: 0x003E5210
		public string getItemName(int id)
		{
			IEquipItem equipItem;
			if (this.s_EquipDict.TryGetValue(id, out equipItem))
			{
				return equipItem.Name;
			}
			return string.Empty;
		}

		// Token: 0x0400ED4C RID: 60748
		private Dictionary<int, IEquipItem> s_EquipDict;

		// Token: 0x0400ED4D RID: 60749
		private Dictionary<int, IEquipItem> s_EquipSuitDict = new Dictionary<int, IEquipItem>(89);
	}
}
