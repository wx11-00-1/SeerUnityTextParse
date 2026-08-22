using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.itemsOptimize;
using core.manager;

namespace core.config
{
	public static class DoodleXMLInfo
	{
		private static uint _dataLen = 0u;

		private static Dictionary<int, ItemData> _dataList = new Dictionary<int, ItemData>(17);

		public static void init()
		{
			_dataList.Clear();
		}

		public static void addItem(ItemData item)
		{
			if (item.GetCatID() == 2)
			{
				_dataList.TryAdd(item.GetID(), item);
			}
		}

		public static string GetName(int id)
		{
			ItemData value;
			if (!_dataList.TryGetValue(id, out value))
			{
				return null;
			}
			return value.GetName();
		}

		public static int GetPrice(int id)
		{
			ItemData value;
			if (!_dataList.TryGetValue(id, out value))
			{
				return 0;
			}
			return value.GetPrice();
		}

		public static int GetColor(int id)
		{
			ItemData value;
			if (!_dataList.TryGetValue(id, out value))
			{
				return -1;
			}
			return Convert.ToInt32(value.GetColor());
		}

		public static int GetTexture(int id)
		{
			ItemData value;
			if (!_dataList.TryGetValue(id, out value))
			{
				return 0;
			}
			return value.GetTexture();
		}

		public static List<ItemData> GetList()
		{
			List<ItemData> list = _dataList.Values.ToList();
			list.Sort((ItemData a, ItemData b) => a.GetID().CompareTo(b.GetID()));
			return list;
		}

		private static int getIntColor(string colorStr)
		{
			int result;
			if (int.TryParse(colorStr, out result))
			{
				return result;
			}
			return 0;
		}

		public static int GetDoodleIDByColorAndTexture(int texture, int color)
		{
			if (_dataList == null)
			{
				return 200008;
			}
			int num;
			if (texture == 0)
			{
				ItemData itemData = _dataList.Values.Where((ItemData item) => item != null && getIntColor(item.GetColor()) == color).FirstOrDefault();
				num = ((itemData != null) ? itemData.GetID() : 0);
			}
			else
			{
				List<ItemData> list = _dataList.Values.Where((ItemData item) => item != null && item.GetTexture() == texture).ToList();
				if (list.Count == 1)
				{
					num = list[0].GetID();
				}
				else
				{
					ItemData itemData2 = list.Where((ItemData item) => getIntColor(item.GetColor()) == color).FirstOrDefault();
					num = ((itemData2 != null) ? itemData2.GetID() : 0);
				}
			}
			if (num != 0)
			{
				return num;
			}
			return 200008;
		}
	}
}
