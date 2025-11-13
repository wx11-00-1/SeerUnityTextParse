using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.itemsOptimize;
using core.manager;


namespace core.config
{
	// Token: 0x02001E9C RID: 7836
	public static class DoodleXMLInfo
	{
		// Token: 0x0600E9F7 RID: 59895 RVA: 0x003E60D9 File Offset: 0x003E42D9
		public static void init()
		{
			DoodleXMLInfo._dataList.Clear();
		}

		// Token: 0x0600E9F8 RID: 59896 RVA: 0x003E60E5 File Offset: 0x003E42E5
		public static void addItem(ItemData item)
		{
			if (item.GetCatID() == 2)
			{
				DoodleXMLInfo._dataList.TryAdd(item.GetID(), item);
			}
		}

		// Token: 0x0600E9F9 RID: 59897 RVA: 0x003E6104 File Offset: 0x003E4304
		public static string GetName(int id)
		{
			ItemData itemData;
			if (!DoodleXMLInfo._dataList.TryGetValue(id, out itemData))
			{
				return null;
			}
			return itemData.GetName();
		}

		// Token: 0x0600E9FA RID: 59898 RVA: 0x003E6128 File Offset: 0x003E4328
		public static int GetPrice(int id)
		{
			ItemData itemData;
			if (!DoodleXMLInfo._dataList.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetPrice();
		}

		// Token: 0x0600E9FB RID: 59899 RVA: 0x003E614C File Offset: 0x003E434C
		public static int GetColor(int id)
		{
			ItemData itemData;
			if (!DoodleXMLInfo._dataList.TryGetValue(id, out itemData))
			{
				return -1;
			}
			return Convert.ToInt32(itemData.GetColor());
		}

		// Token: 0x0600E9FC RID: 59900 RVA: 0x003E6178 File Offset: 0x003E4378
		public static int GetTexture(int id)
		{
			ItemData itemData;
			if (!DoodleXMLInfo._dataList.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetTexture();
		}

		// Token: 0x0600E9FD RID: 59901 RVA: 0x003E619C File Offset: 0x003E439C
		public static List<ItemData> GetList()
		{
			List<ItemData> list = DoodleXMLInfo._dataList.Values.ToList<ItemData>();
			list.Sort((ItemData a, ItemData b) => a.GetID().CompareTo(b.GetID()));
			return list;
		}

		// Token: 0x0600E9FE RID: 59902 RVA: 0x003E61D4 File Offset: 0x003E43D4
		//public static int GetCurrentDoodleID()
		//{
		//	if (DoodleXMLInfo._dataList == null)
		//	{
		//		Debug.Log("DoodleXMLInfo GetCurrentDoodleID _dataList is null");
		//		return 200008;
		//	}
		//	int num;
		//	if (ResetableSingleTon<MainManager>.Ins.actorInfo.texture == 0)
		//	{
		//		ItemData itemData = (from item in DoodleXMLInfo._dataList.Values
		//		where item != null && DoodleXMLInfo.getIntColor(item.GetColor()) == ResetableSingleTon<MainManager>.Ins.actorInfo.color
		//		select item).FirstOrDefault<ItemData>();
		//		num = ((itemData != null) ? itemData.GetID() : 0);
		//	}
		//	else
		//	{
		//		List<ItemData> list = (from item in DoodleXMLInfo._dataList.Values
		//		where item != null && item.GetTexture() == ResetableSingleTon<MainManager>.Ins.actorInfo.texture
		//		select item).ToList<ItemData>();
		//		if (list.Count == 1)
		//		{
		//			num = list[0].GetID();
		//		}
		//		else
		//		{
		//			ItemData itemData2 = (from item in list
		//			where DoodleXMLInfo.getIntColor(item.GetColor()) == ResetableSingleTon<MainManager>.Ins.actorInfo.color
		//			select item).FirstOrDefault<ItemData>();
		//			num = ((itemData2 != null) ? itemData2.GetID() : 0);
		//		}
		//	}
		//	if (num != 0)
		//	{
		//		return num;
		//	}
		//	return 200008;
		//}

		// Token: 0x0600E9FF RID: 59903 RVA: 0x003E62E0 File Offset: 0x003E44E0
		private static int getIntColor(string colorStr)
		{
			int result;
			if (int.TryParse(colorStr, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0600EA00 RID: 59904 RVA: 0x003E62FC File Offset: 0x003E44FC
		public static int GetDoodleIDByColorAndTexture(int texture, int color)
		{
			if (DoodleXMLInfo._dataList == null)
			{
				//Debug.Log("DoodleXMLInfo GetDoodleIDByColorAndTexture _dataList is null");
				return 200008;
			}
			int num;
			if (texture == 0)
			{
				ItemData itemData = (from item in DoodleXMLInfo._dataList.Values
				where item != null && DoodleXMLInfo.getIntColor(item.GetColor()) == color
				select item).FirstOrDefault<ItemData>();
				num = ((itemData != null) ? itemData.GetID() : 0);
			}
			else
			{
				List<ItemData> list = (from item in DoodleXMLInfo._dataList.Values
				where item != null && item.GetTexture() == texture
				select item).ToList<ItemData>();
				if (list.Count == 1)
				{
					num = list[0].GetID();
				}
				else
				{
					ItemData itemData2 = (from item in list
					where DoodleXMLInfo.getIntColor(item.GetColor()) == color
					select item).FirstOrDefault<ItemData>();
					num = ((itemData2 != null) ? itemData2.GetID() : 0);
				}
			}
			if (num != 0)
			{
				return num;
			}
			return 200008;
		}

		// Token: 0x0400ED31 RID: 60721
		private static uint _dataLen = 0U;

		// Token: 0x0400ED32 RID: 60722
		private static Dictionary<int, ItemData> _dataList = new Dictionary<int, ItemData>(17);
	}
}
