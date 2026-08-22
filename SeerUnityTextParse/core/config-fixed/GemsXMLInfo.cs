using System;
using System.Collections.Generic;
using System.Text;
using common;
using core.config.gems;
using core.manager;


namespace core.config
{
	// Token: 0x02001EA0 RID: 7840
	public class GemsXMLInfo : ConfigManagerSingleton<GemsXMLInfo>
	{
		// Token: 0x0600EA19 RID: 59929 RVA: 0x003E66B7 File Offset: 0x003E48B7
		

		// Token: 0x0600EA1A RID: 59930 RVA: 0x003E66F3 File Offset: 0x003E48F3
		

		// Token: 0x0600EA1B RID: 59931 RVA: 0x003E6704 File Offset: 0x003E4904
		

		// Token: 0x0600EA1C RID: 59932 RVA: 0x003E6748 File Offset: 0x003E4948
		public string getEffect(int id)
		{
			StringBuilder stringBuilder = PoolUtils<StringBuilder>.Shared.Rent();
			if (this.gemsMap.ContainsKey(id))
			{
				ISkillEffectsItem[] skillEffects = this.gemsMap[id].SkillEffects;
				for (int i = 0; i < skillEffects.Length; i++)
				{
					IEffect effect = skillEffects[i].Effect;
					int effectId = effect.EffectId;
					int[] param = effect.Param;
					if (effectId != 0)
					{
						//string info = ResetableSingleTon<EffectInfoManager>.Ins.getInfo(effectId, param);
						//if (stringBuilder.Length == 0)
						//{
						//	stringBuilder.Append(info);
						//}
						//else
						//{
						//	stringBuilder.Append("\r");
						//	stringBuilder.Append(info);
						//}
					}
				}
			}
			string result = stringBuilder.ToString();
			stringBuilder.Clear();
			PoolUtils<StringBuilder>.Shared.Return(stringBuilder);
			return result;
		}

		// Token: 0x0600EA1D RID: 59933 RVA: 0x003E67F8 File Offset: 0x003E49F8
		public string getName(int id)
		{
			if (!this.gemsMap.ContainsKey(id))
			{
				return string.Empty;
			}
			string name = this.gemsMap[id].Name;
			int num = name.LastIndexOf("Lv");
			if (num != -1)
			{
				return name.Substring(0, num);
			}
			return name;
		}

		// Token: 0x0600EA1E RID: 59934 RVA: 0x003E6845 File Offset: 0x003E4A45
		public int getCategory(int id)
		{
			if (this.gemsMap.ContainsKey(id))
			{
				return this.gemsMap[id].Category;
			}
			return 0;
		}

		// Token: 0x0600EA1F RID: 59935 RVA: 0x003E6868 File Offset: 0x003E4A68
		public int getLv(int id)
		{
			if (this.gemsMap.ContainsKey(id))
			{
				return this.gemsMap[id].Lv;
			}
			return 0;
		}

		// Token: 0x0600EA20 RID: 59936 RVA: 0x003E688B File Offset: 0x003E4A8B
		public int getEquitLv1Cnt1(int id)
		{
			if (this.gemsMap.ContainsKey(id))
			{
				return this.gemsMap[id].EquitLv1Cnt1;
			}
			return 0;
		}

		// Token: 0x0600EA21 RID: 59937 RVA: 0x003E68AE File Offset: 0x003E4AAE
		public int getUpgradeGemId(int id)
		{
			if (this.gemsMap.ContainsKey(id))
			{
				return this.gemsMap[id].UpgradeGemId;
			}
			return 0;
		}

		// Token: 0x0600EA22 RID: 59938 RVA: 0x003E68D1 File Offset: 0x003E4AD1
		public int getDecomposeNum(int id)
		{
			if (this.gemsMap.ContainsKey(id))
			{
				return this.gemsMap[id].DecomposeProb;
			}
			return 0;
		}

		// Token: 0x0600EA23 RID: 59939 RVA: 0x003E68F4 File Offset: 0x003E4AF4
		public int getAllGemNum(int type)
		{
			return this.numAllGem[type - 1];
		}

		// Token: 0x0400ED38 RID: 60728
		private IGemItem[] s_Data;

		// Token: 0x0400ED39 RID: 60729
		private int[] numAllGem = new int[2];

		// Token: 0x0400ED3A RID: 60730
		public Dictionary<int, IGemItem> gemsMap;

		// Token: 0x0400ED3B RID: 60731
		public Dictionary<int, IGemItem> lv1Map = new Dictionary<int, IGemItem>(37);
	}
}
