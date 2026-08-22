using System;
using System.Collections.Generic;
using common;
using core.config.mintmark;
using core.manager;
using core.model;
//using Cysharp.Threading.Tasks;
//using Cysharp.Threading.Tasks.CompilerServices;
//

namespace core.config
{
	// Token: 0x02001E9B RID: 7835
	public class CountermarkXMLInfo : ConfigManagerSingleton<CountermarkXMLInfo>
	{
		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x0600E9CC RID: 59852 RVA: 0x003E57AC File Offset: 0x003E39AC
		public int quanNengKyMax
		{
			get
			{
				return this.s_QuanNengKyMax;
			}
		}

		// Token: 0x0600E9CD RID: 59853 RVA: 0x003E57B4 File Offset: 0x003E39B4
		//

		// Token: 0x0600E9CE RID: 59854 RVA: 0x003E57D7 File Offset: 0x003E39D7
		//

		// Token: 0x0600E9CF RID: 59855 RVA: 0x003E57E8 File Offset: 0x003E39E8
		//

		// Token: 0x0600E9D0 RID: 59856 RVA: 0x003E582C File Offset: 0x003E3A2C
		private string getQuanxiaoDes(int id)
		{
			int quanxiaoAbilityID = this.getQuanxiaoAbilityID(id);
			int quanxiaoSkillID = this.getQuanxiaoSkillID(id);
			string des = this.getDes(quanxiaoAbilityID);
			string text = this.getDes(quanxiaoSkillID);
			string str = text.Substring(0, text.Length - 2);
			string str2 = "·";
			text = des;
			return str + str2 + text.Substring(0, text.Length - 2) + "全效刻印";
		}

		// Token: 0x0600E9D1 RID: 59857 RVA: 0x003E5888 File Offset: 0x003E3A88
		private string getQuanxiaoEffectDes(int id)
		{
			int quanxiaoAbilityID = this.getQuanxiaoAbilityID(id);
			int quanxiaoSkillID = this.getQuanxiaoSkillID(id);
			string effectDes = this.getEffectDes(quanxiaoAbilityID);
			return this.getEffectDes(quanxiaoSkillID) + "，" + effectDes;
		}

		// Token: 0x0600E9D2 RID: 59858 RVA: 0x003E58BF File Offset: 0x003E3ABF
		public int getQuanxiaoSkillID(int id)
		{
			return id % 100000;
		}

		// Token: 0x0600E9D3 RID: 59859 RVA: 0x003E58C8 File Offset: 0x003E3AC8
		private int getQuanxiaoAbilityID(int id)
		{
			return id / 100000;
		}

		// Token: 0x0600E9D4 RID: 59860 RVA: 0x003E58D4 File Offset: 0x003E3AD4
		private int getLevel(int id)
		{
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return mintMarkItem.Level;
			}
			return 0;
		}

		// Token: 0x0600E9D5 RID: 59861 RVA: 0x003E58FC File Offset: 0x003E3AFC
		private int getSkillID(int id)
		{
			IMintMarkItem mintMarkItem;
			if (!this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return 0;
			}
			if (mintMarkItem.MoveID != null && mintMarkItem.MoveID.Length != 0)
			{
				return mintMarkItem.MoveID[0];
			}
			return 0;
		}

		// Token: 0x0600E9D6 RID: 59862 RVA: 0x003E5938 File Offset: 0x003E3B38
		public string getDes(int id)
		{
			if (this.isQuanxiaoMark(id))
			{
				return this.getQuanxiaoDes(id);
			}
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return mintMarkItem.Des;
			}
			return string.Empty;
		}

		// Token: 0x0600E9D7 RID: 59863 RVA: 0x003E5974 File Offset: 0x003E3B74
		public string getEffectDes(int id)
		{
			if (this.isQuanxiaoMark(id))
			{
				return this.getQuanxiaoEffectDes(id);
			}
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return mintMarkItem.EffectDes;
			}
			return string.Empty;
		}

		// Token: 0x0600E9D8 RID: 59864 RVA: 0x003E59B0 File Offset: 0x003E3BB0
		public string getSkillEffectDes(int id, int skillID)
		{
			IMintMarkItem mintMarkItem;
			if (this.isQuanxiaoMark(id))
			{
				int quanxiaoSkillID = this.getQuanxiaoSkillID(id);
				if (quanxiaoSkillID == skillID)
				{
					return this.getEffectDes(quanxiaoSkillID);
				}
			}
			else if (this.s_DataMap.TryGetValue(id, out mintMarkItem) && mintMarkItem.MoveID != null && skillID == mintMarkItem.MoveID[0])
			{
				return mintMarkItem.EffectDes;
			}
			return string.Empty;
		}

		// Token: 0x0600E9D9 RID: 59865 RVA: 0x003E5A0C File Offset: 0x003E3C0C
		public int getType(int id)
		{
			if (id.ToString().Length == 10)
			{
				int quanxiaoAbilityID = this.getQuanxiaoAbilityID(id);
				int quanxiaoSkillID = this.getQuanxiaoSkillID(id);
				if (this.isAbilityMark(quanxiaoAbilityID) && this.isSkillMark(quanxiaoSkillID))
				{
					return 55;
				}
				return 3;
			}
			else
			{
				IMintMarkItem mintMarkItem;
				if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
				{
					return mintMarkItem.Type;
				}
				return -1;
			}
		}

		// Token: 0x0600E9DA RID: 59866 RVA: 0x003E5A68 File Offset: 0x003E3C68
		public int getMax(int id)
		{
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return mintMarkItem.Max;
			}
			return -1;
		}

		// Token: 0x0600E9DB RID: 59867 RVA: 0x003E5A90 File Offset: 0x003E3C90
		public string getTypeName(int id)
		{
			int type = this.getType(id);
			if (type == 0)
			{
				return "能力刻印";
			}
			if (type == 1)
			{
				return "技能刻印";
			}
			if (type == 2)
			{
				return "通用刻印";
			}
			if (type == 3)
			{
				return "全能刻印";
			}
			if (type == 4)
			{
				return "刻印碎片";
			}
			if (type == 55)
			{
				return "全效刻印";
			}
			return string.Empty;
		}

		// Token: 0x0600E9DC RID: 59868 RVA: 0x003E5AE8 File Offset: 0x003E3CE8
		public int getMintMarkClass(int id)
		{
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return mintMarkItem.MintmarkClass;
			}
			return 0;
		}

		// Token: 0x0600E9DD RID: 59869 RVA: 0x003E5B10 File Offset: 0x003E3D10
		public int[] getArg(int id)
		{
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return mintMarkItem.Arg;
			}
			return new int[0];
		}

		// Token: 0x0600E9DE RID: 59870 RVA: 0x003E5B3C File Offset: 0x003E3D3C
		public string getIconURL(int id)
		{
			int num = id;
			if (this.isQuanxiaoMark(id))
			{
				num = this.getQuanxiaoSkillID(id);
			}
			return ClientConfig.getResPath("assets/countermark/icon/" + num.ToString() + ".png");
		}

		// Token: 0x0600E9DF RID: 59871 RVA: 0x003E5B78 File Offset: 0x003E3D78
		//public int getMarkId(int id)
		//{
		//	if (!this.isUniversalMark(id))
		//	{
		//		return id;
		//	}
		//	CountermarkInfo universalMarkInfo = ResetableSingleTon<ItemManager>.Ins.getUniversalMarkInfo(id);
		//	if (universalMarkInfo == null)
		//	{
		//		return 0;
		//	}
		//	return universalMarkInfo.markID;
		//}

		// Token: 0x0600E9E0 RID: 59872 RVA: 0x003E5BA8 File Offset: 0x003E3DA8
		public int getMonsterID(int id)
		{
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem) && mintMarkItem.MonsterID != null && mintMarkItem.MonsterID.Length != 0)
			{
				return mintMarkItem.MonsterID[0];
			}
			return 0;
		}

		// Token: 0x0600E9E1 RID: 59873 RVA: 0x003E5BE0 File Offset: 0x003E3DE0
		public List<int> getMonsterIDs(int id)
		{
			IMintMarkItem mintMarkItem;
			if (!this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return new List<int>();
			}
			if (mintMarkItem.MonsterID == null)
			{
				return new List<int>();
			}
			List<int> list = new List<int>();
			list.AddRange(mintMarkItem.MonsterID);
			return list;
		}

		// Token: 0x0600E9E2 RID: 59874 RVA: 0x003E5C22 File Offset: 0x003E3E22
		public bool isExclusive(int id)
		{
			return id > 0 && this.getMonsterIDs(id).Count > 0;
		}

		// Token: 0x0600E9E3 RID: 59875 RVA: 0x003E5C39 File Offset: 0x003E3E39
		public bool isAbilityMark(int id)
		{
			return this.getType(id) == 0;
		}

		// Token: 0x0600E9E4 RID: 59876 RVA: 0x003E5C45 File Offset: 0x003E3E45
		public bool isSkillMark(int id)
		{
			return this.getType(id) == 1;
		}

		// Token: 0x0600E9E5 RID: 59877 RVA: 0x003E5C51 File Offset: 0x003E3E51
		public bool isUniversalMark(int id)
		{
			return this.getType(id) == 3;
		}

		// Token: 0x0600E9E6 RID: 59878 RVA: 0x003E5C5D File Offset: 0x003E3E5D
		public bool isQuanxiaoMark(int id)
		{
			return this.getType(id) == 55;
		}

		// Token: 0x0600E9E7 RID: 59879 RVA: 0x003E5C6C File Offset: 0x003E3E6C
		public List<int> getSkillArr(int id)
		{
			List<int> list = new List<int>();
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				for (int i = 0; i < mintMarkItem.MoveID.Length; i++)
				{
					list.Add(mintMarkItem.MoveID[i]);
				}
			}
			return list;
		}

		// Token: 0x0600E9E8 RID: 59880 RVA: 0x003E5CB4 File Offset: 0x003E3EB4
		public string getRestrictDes(int id)
		{
			if (this.isQuanxiaoMark(id))
			{
				id = this.getQuanxiaoSkillID(id);
			}
			if (this.getMonsterID(id) != 0)
			{
				return ResetableSingleTon<PetXMLInfo>.Ins.getName(this.getMonsterID(id));
			}
			if (this.getLevel(id) != 0)
			{
				return this.getLevel(id).ToString() + "级";
			}
			if (this.getSkillID(id) != 0)
			{
				return ResetableSingleTon<SkillXMLInfo>.Ins.getName(this.getSkillID(id), 0);
			}
			return string.Empty;
		}

		// Token: 0x0600E9E9 RID: 59881 RVA: 0x003E5D32 File Offset: 0x003E3F32
		public bool isminMark(int id)
		{
			return this.isAbilityMark(id) || this.isSkillMark(id) || this.isUniversalMark(id) || this.isQuanxiaoMark(id);
		}

		// Token: 0x0600E9EA RID: 59882 RVA: 0x003E5D58 File Offset: 0x003E3F58
		public int getCurrentGrade(int id, int[] currentAttriArr)
		{
			if (!this.isUniversalMark(id))
			{
				return 0;
			}
			int maxGrade = this.getMaxGrade(id);
			int[] maxAttriValue = this.getMaxAttriValue(id);
			int[] baseAttriValue = this.getBaseAttriValue(id);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < baseAttriValue.Length; i++)
			{
				num += maxAttriValue[i];
				num3 += baseAttriValue[i];
				num2 += currentAttriArr[i];
			}
			if (num == num2)
			{
				return maxGrade;
			}
			if (num2 <= num3)
			{
				return 0;
			}
			float num4 = (float)(num - num3) / ((float)((1 + maxGrade) * maxGrade) / 2f);
			int num5 = num3;
			for (int j = 0; j < maxGrade; j++)
			{
				num5 += (int)Math.Ceiling((double)(num4 * (float)(j + 1)));
				num5 = Math.Min(num5, num);
				if (num2 < num5)
				{
					return j;
				}
			}
			return 0;
		}

		// Token: 0x0600E9EB RID: 59883 RVA: 0x003E5E1C File Offset: 0x003E401C
		public int getTotalConsume(int id)
		{
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem) && this.isUniversalMark(id))
			{
				int result;
				if (mintMarkItem.TotalConsume > 0)
				{
					result = mintMarkItem.TotalConsume;
				}
				else
				{
					int[] maxAttriValue = this.getMaxAttriValue(id);
					double num = Math.Round((double)this.getHornNum(id) - 1.47, 2);
					result = (int)Math.Ceiling((double)(maxAttriValue[0] * 1521 + maxAttriValue[1] * 1517 + maxAttriValue[2] * 1521 + maxAttriValue[3] * 1517 + maxAttriValue[4] * 1822 + maxAttriValue[5] * 1510) * num);
				}
				return result;
			}
			return 0;
		}

		// Token: 0x0600E9EC RID: 59884 RVA: 0x003E5EC0 File Offset: 0x003E40C0
		public int getMaxGrade(int id)
		{
			if (!this.isUniversalMark(id))
			{
				return 0;
			}
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return mintMarkItem.Grade;
			}
			return 15;
		}

		// Token: 0x0600E9ED RID: 59885 RVA: 0x003E5EF4 File Offset: 0x003E40F4
		public List<int> getExtraAttriValue(int id)
		{
			IMintMarkItem mintMarkItem;
			if (!this.s_DataMap.TryGetValue(id, out mintMarkItem) || !this.isUniversalMark(id) || mintMarkItem.ExtraAttriValue == null)
			{
				return null;
			}
			if (mintMarkItem.ExtraAttriValue == null)
			{
				return null;
			}
			List<int> list = new List<int>();
			foreach (int item in mintMarkItem.ExtraAttriValue)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0600E9EE RID: 59886 RVA: 0x003E5F58 File Offset: 0x003E4158
		public int[] getBaseAttriValue(int id)
		{
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return mintMarkItem.BaseAttriValue;
			}
			return null;
		}

		// Token: 0x0600E9EF RID: 59887 RVA: 0x003E5F80 File Offset: 0x003E4180
		public int getHornNum(int id)
		{
			int[] array;
			if (this.isUniversalMark(id))
			{
				array = this.getBaseAttriValue(id);
			}
			else
			{
				array = this.getArg(id);
			}
			if (array == null)
			{
				return 5;
			}
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != 0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0600E9F0 RID: 59888 RVA: 0x003E5FC8 File Offset: 0x003E41C8
		public int[] getMaxAttriValue(int id)
		{
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem) && mintMarkItem.BaseAttriValue != null && mintMarkItem.BaseAttriValue.Length != 0)
			{
				return mintMarkItem.MaxAttriValue;
			}
			return new int[6];
		}

		// Token: 0x0600E9F1 RID: 59889 RVA: 0x003E6004 File Offset: 0x003E4204
		public int getMintmarkQuality(int id)
		{
			IMintMarkItem mintMarkItem;
			if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return mintMarkItem.Quality;
			}
			return 0;
		}

		// Token: 0x0600E9F2 RID: 59890 RVA: 0x003E602C File Offset: 0x003E422C
		public int getMintmarkRare(int id)
		{
			//IMintMarkItem mintMarkItem;
			//if (this.s_DataMap.TryGetValue(id, out mintMarkItem))
			//{
			//	return Mathf.Min(6, mintMarkItem.Rare);
			//}
			return 0;
		}

		// Token: 0x0600E9F3 RID: 59891 RVA: 0x003E6057 File Offset: 0x003E4257
		public Dictionary<int, IMintMarkItem> getMap()
		{
			return this.s_DataMap;
		}

		// Token: 0x0600E9F4 RID: 59892 RVA: 0x003E6060 File Offset: 0x003E4260
		public string getClassNameByMarkId(int id)
		{
			string result = "无系列";
			int mintMarkClass = this.getMintMarkClass(id);
			if (mintMarkClass > 0)
			{
				IMintmarkClassItem mintmarkClassItem;
				if (this.s_MintMarkClassDataMap.TryGetValue(mintMarkClass, out mintmarkClassItem))
				{
					result = mintmarkClassItem.ClassName;
				}
			}
			else if (this.getType(id) == 3)
			{
				result = "专属全能刻印";
			}
			return result;
		}

		// Token: 0x0600E9F5 RID: 59893 RVA: 0x003E60AC File Offset: 0x003E42AC
		[Obsolete("请使用getMintmarkRare")]
		public int getRarity(int id)
		{
			IMintMarkItem mintMarkItem;
			if (!this.s_DataMap.TryGetValue(id, out mintMarkItem))
			{
				return 0;
			}
			return mintMarkItem.Rarity;
		}

		// Token: 0x0400ED2E RID: 60718
		private Dictionary<int, IMintMarkItem> s_DataMap;

		// Token: 0x0400ED2F RID: 60719
		private Dictionary<int, IMintmarkClassItem> s_MintMarkClassDataMap;

		// Token: 0x0400ED30 RID: 60720
		private int s_QuanNengKyMax;
	}
}
