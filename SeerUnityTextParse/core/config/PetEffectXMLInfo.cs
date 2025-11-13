using System;
using System.Collections.Generic;
using common;
using core.config.new_se;


namespace core.config
{
	// Token: 0x02001EB3 RID: 7859
	public class PetEffectXMLInfo : ConfigManagerSingleton<PetEffectXMLInfo>
	{
		// Token: 0x0600EAE7 RID: 60135 RVA: 0x003EB308 File Offset: 0x003E9508
		

		// Token: 0x0600EAE8 RID: 60136 RVA: 0x003EB32B File Offset: 0x003E952B
		

		// Token: 0x0600EAE9 RID: 60137 RVA: 0x003EB33C File Offset: 0x003E953C
		

		// Token: 0x0600EAEA RID: 60138 RVA: 0x003EB380 File Offset: 0x003E9580
		public string getEffectType(int eid, string arg)
		{
			string result = "0";
			foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
			{
				if (newSeIdxItem.Eid == eid && newSeIdxItem.Args == arg && newSeIdxItem.Idx > 1000)
				{
					result = newSeIdxItem.AdditionType.ToString();
					break;
				}
			}
			return result;
		}

		// Token: 0x0600EAEB RID: 60139 RVA: 0x003EB408 File Offset: 0x003E9608
		public int getEffectAdditonNum(int eid, string arg)
		{
			int result = 0;
			foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
			{
				if (newSeIdxItem.Eid == eid && newSeIdxItem.Args == arg && newSeIdxItem.Idx > 1000)
				{
					result = newSeIdxItem.AdditionNum;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600EAEC RID: 60140 RVA: 0x003EB484 File Offset: 0x003E9684
		public string getName(int id)
		{
			INewSeIdxItem newSeIdxItem;
			if (!this.s_DataMap.TryGetValue(id, out newSeIdxItem) || newSeIdxItem.Des == null)
			{
				return string.Empty;
			}
			return newSeIdxItem.Des;
		}

		// Token: 0x0600EAED RID: 60141 RVA: 0x003EB4B8 File Offset: 0x003E96B8
		public string getDes(int id)
		{
			INewSeIdxItem newSeIdxItem;
			if (!this.s_DataMap.TryGetValue(id, out newSeIdxItem) || newSeIdxItem.Intro == null)
			{
				return string.Empty;
			}
			return newSeIdxItem.Intro;
		}

		// Token: 0x0600EAEE RID: 60142 RVA: 0x003EB4EC File Offset: 0x003E96EC
		public string getEffect(int eid, string arg)
		{
			string result = string.Empty;
			foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
			{
				if (newSeIdxItem.Eid == eid && newSeIdxItem.Args == arg && newSeIdxItem.Idx > 1000)
				{
					result = newSeIdxItem.Desc;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600EAEF RID: 60143 RVA: 0x003EB56C File Offset: 0x003E976C
		public string getEffectDes(int eid, string arg)
		{
			string result = string.Empty;
			foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
			{
				if (newSeIdxItem.Eid == eid && newSeIdxItem.Args == arg && newSeIdxItem.Idx > 1000)
				{
					result = newSeIdxItem.Intro;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600EAF0 RID: 60144 RVA: 0x003EB5EC File Offset: 0x003E97EC
		public int getStarLevel(int eid, string arg)
		{
			int result = 0;
			foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
			{
				if (newSeIdxItem.Eid == eid && newSeIdxItem.Args == arg && newSeIdxItem.Idx > 1000)
				{
					result = newSeIdxItem.StarLevel;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600EAF1 RID: 60145 RVA: 0x003EB668 File Offset: 0x003E9868
		//public Dictionary<int, string> getIntros(string desc)
		//{
		//	Dictionary<int, string> dictionary = new Dictionary<int, string>();
		//	foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
		//	{
		//		if (newSeIdxItem.Desc == desc)
		//		{
		//			dictionary.TryAddReplace(newSeIdxItem.StarLevel, newSeIdxItem.Intro);
		//		}
		//	}
		//	return dictionary;
		//}

		// Token: 0x0600EAF2 RID: 60146 RVA: 0x003EB6DC File Offset: 0x003E98DC
		public string getDescByIdx(int idx)
		{
			foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
			{
				if (newSeIdxItem.Idx == idx)
				{
					return newSeIdxItem.Desc;
				}
			}
			return string.Empty;
		}

		// Token: 0x0600EAF3 RID: 60147 RVA: 0x003EB744 File Offset: 0x003E9944
		public INewSeIdxItem getEffctInfoByIdx(int idx)
		{
			foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
			{
				if (newSeIdxItem.Idx == idx)
				{
					return newSeIdxItem;
				}
			}
			return null;
		}

		// Token: 0x0600EAF4 RID: 60148 RVA: 0x003EB7A0 File Offset: 0x003E99A0
		public int getEffectIdx(int eid, string arg)
		{
			int result = 0;
			foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
			{
				if (newSeIdxItem.Eid == eid && newSeIdxItem.Args == arg && newSeIdxItem.Idx > 1000)
				{
					result = newSeIdxItem.Idx;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600EAF5 RID: 60149 RVA: 0x003EB81C File Offset: 0x003E9A1C
		public int getEid(int newSeIdx)
		{
			foreach (INewSeIdxItem newSeIdxItem in this.s_StatXML)
			{
				if (newSeIdxItem.Idx == newSeIdx)
				{
					return newSeIdxItem.Eid;
				}
			}
			return 0;
		}

		// Token: 0x0400EEC0 RID: 61120
		private List<INewSeIdxItem> s_StatXML = new List<INewSeIdxItem>(353);

		// Token: 0x0400EEC1 RID: 61121
		private Dictionary<int, INewSeIdxItem> s_DataMap;

		// Token: 0x0400EEC2 RID: 61122
		public string RACIAl_VALUE_ADDITION = "1";

		// Token: 0x0400EEC3 RID: 61123
		public string SKILL_POWER_ADDITION = "2";
	}
}
