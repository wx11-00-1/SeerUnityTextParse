using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.clothpos;
using core.config.suit;


namespace core.config
{
	// Token: 0x02001EC0 RID: 7872
	public class SuitXMLInfo : ConfigManagerSingleton<SuitXMLInfo>
	{
		// Token: 0x0600EB98 RID: 60312 RVA: 0x003EE3BA File Offset: 0x003EC5BA
		

		// Token: 0x0600EB99 RID: 60313 RVA: 0x003EE3E8 File Offset: 0x003EC5E8
		

		// Token: 0x0600EB9A RID: 60314 RVA: 0x003EE3F8 File Offset: 0x003EC5F8
		

		// Token: 0x0600EB9B RID: 60315 RVA: 0x003EE43C File Offset: 0x003EC63C
		public int getSuitID(List<int> clothIDs)
		{
			int num = 0;
			IItemItem itemItem = null;
			for (int i = 0; i < clothIDs.Count; i++)
			{
				if (itemItem == null)
				{
					if (!this.s_MapClothIdToSuitId.TryGetValue(clothIDs[i], out itemItem))
					{
						if (!ResetableSingleTon<ItemXMLInfo>.Ins.gettype(clothIDs[i]).Equals("bg"))
						{
							return 0;
						}
						num = 1;
					}
				}
				else if (!itemItem.cloths.Contains(clothIDs[i]))
				{
					if (num != 0 || !ResetableSingleTon<ItemXMLInfo>.Ins.gettype(clothIDs[i]).Equals("bg"))
					{
						return 0;
					}
					num = 1;
				}
			}
			if (itemItem != null && clothIDs.Count == itemItem.cloths.Length + num)
			{
				return itemItem.id;
			}
			return 0;
		}

		// Token: 0x0600EB9C RID: 60316 RVA: 0x003EE4F4 File Offset: 0x003EC6F4
		public List<int> getSuitIDs(List<int> clothIDs)
		{
			if (clothIDs == null)
			{
				return null;
			}
			List<int> list = new List<int>();
			foreach (int key in clothIDs)
			{
				int num = 0;
				IItemItem itemItem;
				if (this.s_MapClothIdToSuitId.TryGetValue(key, out itemItem) && list.IndexOf(itemItem.id) <= -1 && itemItem.cloths.Length != 0 && clothIDs.Count >= itemItem.cloths.Length)
				{
					foreach (int item in itemItem.cloths)
					{
						if (clothIDs.IndexOf(item) == -1)
						{
							break;
						}
						num++;
					}
					if (num == itemItem.cloths.Length)
					{
						list.Add(itemItem.id);
					}
				}
			}
			return list;
		}

		// Token: 0x0600EB9D RID: 60317 RVA: 0x003EE5D8 File Offset: 0x003EC7D8
		public bool getIsTransform(int id)
		{
			IItemItem itemItem;
			return this.s_DataMap.TryGetValue(id, out itemItem) && itemItem.transform == 1;
		}

		// Token: 0x0600EB9E RID: 60318 RVA: 0x003EE600 File Offset: 0x003EC800
		public int[] getCloths(int id)
		{
			IItemItem itemItem;
			if (!this.s_DataMap.TryGetValue(id, out itemItem))
			{
				return null;
			}
			return itemItem.cloths;
		}

		// Token: 0x0600EB9F RID: 60319 RVA: 0x003EE628 File Offset: 0x003EC828
		public float getSuitTranSpeed(int id)
		{
			IItemItem itemItem;
			if (!this.s_DataMap.TryGetValue(id, out itemItem))
			{
				return 4f;
			}
			return itemItem.tranSpeed;
		}

		// Token: 0x0600EBA0 RID: 60320 RVA: 0x003EE654 File Offset: 0x003EC854
		public string getName(int id)
		{
			IItemItem itemItem;
			if (!this.s_DataMap.TryGetValue(id, out itemItem))
			{
				return string.Empty;
			}
			return itemItem.name;
		}

		// Token: 0x0600EBA1 RID: 60321 RVA: 0x003EE680 File Offset: 0x003EC880
		public string getSuitNormalDesc(int id)
		{
			IItemItem itemItem;
			if (!this.s_DataMap.TryGetValue(id, out itemItem))
			{
				return string.Empty;
			}
			return itemItem.suitdes;
		}

		// Token: 0x0600EBA2 RID: 60322 RVA: 0x003EE6AC File Offset: 0x003EC8AC
		public int getSuitIdByClothId(int clothId)
		{
			IItemItem itemItem;
			if (!this.s_MapClothIdToSuitId.TryGetValue(clothId, out itemItem))
			{
				return 0;
			}
			return itemItem.id;
		}

		// Token: 0x0600EBA3 RID: 60323 RVA: 0x003EE6D4 File Offset: 0x003EC8D4
		public List<int> getSuitIdByClothId(int[] arrClothId)
		{
			List<int> list = new List<int>();
			foreach (int key in arrClothId)
			{
				IItemItem itemItem;
				if (this.s_MapClothIdToSuitId.TryGetValue(key, out itemItem) && !list.Contains(itemItem.id))
				{
					list.Add(itemItem.id);
				}
			}
			return list;
		}

		// Token: 0x0600EBA4 RID: 60324 RVA: 0x003EE728 File Offset: 0x003EC928
		public int[] getAllSuitIds()
		{
			return this.s_DataMap.Keys.ToArray<int>();
		}

		// Token: 0x0400EEF4 RID: 61172
		private Dictionary<int, IItemItem> s_DataMap;

		// Token: 0x0400EEF5 RID: 61173
		private Dictionary<int, IItemItem> s_MapClothIdToSuitId = new Dictionary<int, IItemItem>(1931);

		// Token: 0x0400EEF6 RID: 61174
		public Dictionary<int, ClothposData> ClothposDic;
	}
}
