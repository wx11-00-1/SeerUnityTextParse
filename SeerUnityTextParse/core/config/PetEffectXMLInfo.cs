using core.config.new_se;

namespace core.config
{
	public class PetEffectXMLInfo : ConfigManagerSingleton<PetEffectXMLInfo>
	{
		private List<INewSeIdxItem> s_StatXML = new List<INewSeIdxItem>(353);

		private Dictionary<int, INewSeIdxItem> s_DataMap;

		public string RACIAl_VALUE_ADDITION = "1";

		public string SKILL_POWER_ADDITION = "2";

		public string getEffectType(int eid, string arg)
		{
			string result = "0";
			foreach (INewSeIdxItem item in s_StatXML)
			{
				if (item.Eid == eid && item.Args == arg && item.Idx > 1000)
				{
					result = item.AdditionType.ToString();
					break;
				}
			}
			return result;
		}

		public int getEffectAdditonNum(int eid, string arg)
		{
			int result = 0;
			foreach (INewSeIdxItem item in s_StatXML)
			{
				if (item.Eid == eid && item.Args == arg && item.Idx > 1000)
				{
					result = item.AdditionNum;
					break;
				}
			}
			return result;
		}

		public string getName(int id)
		{
			INewSeIdxItem value;
			if (!s_DataMap.TryGetValue(id, out value) || value.Des == null)
			{
				return string.Empty;
			}
			return value.Des;
		}

		public string getDes(int id)
		{
			INewSeIdxItem value;
			if (!s_DataMap.TryGetValue(id, out value) || value.Intro == null)
			{
				return string.Empty;
			}
			return value.Intro;
		}

		public string getEffect(int eid, string arg)
		{
			string result = string.Empty;
			foreach (INewSeIdxItem item in s_StatXML)
			{
				if (item.Eid == eid && item.Args == arg && item.Idx > 1000)
				{
					result = item.Desc;
					break;
				}
			}
			return result;
		}

		public string getEffectDes(int eid, string arg)
		{
			string result = string.Empty;
			foreach (INewSeIdxItem item in s_StatXML)
			{
				if (item.Eid == eid && item.Args == arg && item.Idx > 1000)
				{
					result = item.Intro;
					break;
				}
			}
			return result;
		}

		public int getStarLevel(int eid, string arg)
		{
			int result = 0;
			foreach (INewSeIdxItem item in s_StatXML)
			{
				if (item.Eid == eid && item.Args == arg && item.Idx > 1000)
				{
					result = item.StarLevel;
					break;
				}
			}
			return result;
		}

		public string getDescByIdx(int idx)
		{
			foreach (INewSeIdxItem item in s_StatXML)
			{
				if (item.Idx == idx)
				{
					return item.Desc;
				}
			}
			return string.Empty;
		}

		public INewSeIdxItem getEffctInfoByIdx(int idx)
		{
			foreach (INewSeIdxItem item in s_StatXML)
			{
				if (item.Idx == idx)
				{
					return item;
				}
			}
			return null;
		}

		public int getEffectIdx(int eid, string arg)
		{
			int result = 0;
			foreach (INewSeIdxItem item in s_StatXML)
			{
				if (item.Eid == eid && item.Args == arg && item.Idx > 1000)
				{
					result = item.Idx;
					break;
				}
			}
			return result;
		}

		public int getEid(int newSeIdx)
		{
			foreach (INewSeIdxItem item in s_StatXML)
			{
				if (item.Idx == newSeIdx)
				{
					return item.Eid;
				}
			}
			return 0;
		}
	}
}
