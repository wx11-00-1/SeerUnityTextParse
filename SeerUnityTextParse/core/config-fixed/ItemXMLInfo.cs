using System;
using System.Collections.Generic;
using common;
using core.config.itemsOptimize;
using core.config.itemsOptimizeCat;
using core.config.midleExchangeItems;
using core.config.midleItems;
using core.config.sp_hide_moves;
using core.manager;
using core.model;


namespace core.config
{
	// Token: 0x02001EA5 RID: 7845
	public class ItemXMLInfo : ConfigManagerSingleton<ItemXMLInfo>
	{

		// Token: 0x0600EA53 RID: 59987 RVA: 0x003E7268 File Offset: 0x003E5468
		

		// Token: 0x0600EA56 RID: 59990 RVA: 0x003E73A4 File Offset: 0x003E55A4
		private ItemData SetItem(int catID, ref int byteIndex)
		{
			ItemData result = null;
			switch (catID)
			{
			case 0:
			{
				itemsOptimizeCatItem0Def itemsOptimizeCatItem0Def = new itemsOptimizeCatItem0Def();
				itemsOptimizeCatItem0Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem0Def;
				break;
			}
			case 1:
			{
				itemsOptimizeCatItem1Def itemsOptimizeCatItem1Def = new itemsOptimizeCatItem1Def();
				itemsOptimizeCatItem1Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem1Def;
				break;
			}
			case 3:
			{
				itemsOptimizeCatItem3Def itemsOptimizeCatItem3Def = new itemsOptimizeCatItem3Def();
				itemsOptimizeCatItem3Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem3Def;
				break;
			}
			case 4:
			{
				itemsOptimizeCatItem4Def itemsOptimizeCatItem4Def = new itemsOptimizeCatItem4Def();
				itemsOptimizeCatItem4Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem4Def;
				break;
			}
			case 5:
			{
				itemsOptimizeCatItem5Def itemsOptimizeCatItem5Def = new itemsOptimizeCatItem5Def();
				itemsOptimizeCatItem5Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem5Def;
				break;
			}
			case 7:
			{
				itemsOptimizeCatItem7Def itemsOptimizeCatItem7Def = new itemsOptimizeCatItem7Def();
				itemsOptimizeCatItem7Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem7Def;
				break;
			}
			case 10:
			{
				itemsOptimizeCatItem10Def itemsOptimizeCatItem10Def = new itemsOptimizeCatItem10Def();
				itemsOptimizeCatItem10Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem10Def;
				break;
			}
			case 11:
			{
				itemsOptimizeCatItem11Def itemsOptimizeCatItem11Def = new itemsOptimizeCatItem11Def();
				itemsOptimizeCatItem11Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem11Def;
				break;
			}
			case 12:
			{
				itemsOptimizeCatItem12Def itemsOptimizeCatItem12Def = new itemsOptimizeCatItem12Def();
				itemsOptimizeCatItem12Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem12Def;
				break;
			}
			case 13:
			{
				itemsOptimizeCatItem13Def itemsOptimizeCatItem13Def = new itemsOptimizeCatItem13Def();
				itemsOptimizeCatItem13Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem13Def;
				break;
			}
			case 14:
			{
				itemsOptimizeCatItem14Def itemsOptimizeCatItem14Def = new itemsOptimizeCatItem14Def();
				itemsOptimizeCatItem14Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem14Def;
				break;
			}
			case 15:
			{
				itemsOptimizeCatItem15Def itemsOptimizeCatItem15Def = new itemsOptimizeCatItem15Def();
				itemsOptimizeCatItem15Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem15Def;
				break;
			}
			case 17:
			{
				itemsOptimizeCatItem17Def itemsOptimizeCatItem17Def = new itemsOptimizeCatItem17Def();
				itemsOptimizeCatItem17Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem17Def;
				break;
			}
			case 18:
			{
				itemsOptimizeCatItem18Def itemsOptimizeCatItem18Def = new itemsOptimizeCatItem18Def();
				itemsOptimizeCatItem18Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem18Def;
				break;
			}
			case 23:
			{
				itemsOptimizeCatItem23Def itemsOptimizeCatItem23Def = new itemsOptimizeCatItem23Def();
				itemsOptimizeCatItem23Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem23Def;
				break;
			}
			case 24:
			{
				itemsOptimizeCatItem24Def itemsOptimizeCatItem24Def = new itemsOptimizeCatItem24Def();
				itemsOptimizeCatItem24Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem24Def;
				break;
			}
			case 25:
			{
				itemsOptimizeCatItem25Def itemsOptimizeCatItem25Def = new itemsOptimizeCatItem25Def();
				itemsOptimizeCatItem25Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem25Def;
				break;
			}
			case 26:
			{
				itemsOptimizeCatItem26Def itemsOptimizeCatItem26Def = new itemsOptimizeCatItem26Def();
				itemsOptimizeCatItem26Def.Parse(this.s_ItemBytes, ref byteIndex);
				result = itemsOptimizeCatItem26Def;
				break;
			}
			}
			return result;
		}

		// Token: 0x0600EA57 RID: 59991 RVA: 0x003E75C4 File Offset: 0x003E57C4
		private string getSwfURL(int id, int level = 1)
		{
			int catID = this.getCatID(id);
			ICatsItem catsItem;
			if (!this.s_CatItemDict.TryGetValue(catID, out catsItem))
			{
				return string.Empty;
			}
			if (level == 0 || level == 1 || level > 10)
			{
				return catsItem.url + id.ToString() + ".png";
			}
			return catsItem.url + id.ToString() + level.ToString() + ".png";
		}

		// Token: 0x0600EA58 RID: 59992 RVA: 0x003E7634 File Offset: 0x003E5834
		public bool getIsMiddleItem(int id)
		{
			int num;
			core.config.midleExchangeItems.IItemsItem itemsItem;
			return this.s_ItemMidleDict.TryGetValue(id, out num) || this.s_ItemMidleExchangeDict.TryGetValue(id, out itemsItem);
		}

		// Token: 0x0600EA59 RID: 59993 RVA: 0x003E7661 File Offset: 0x003E5861
		public bool HasCloth(int clothId)
		{
			return this.s_ClothMap.Contains(clothId);
		}

		// Token: 0x0600EA5A RID: 59994 RVA: 0x003E766F File Offset: 0x003E586F
		public List<int> getAllClothID()
		{
			return this.s_ClothMap;
		}

		// Token: 0x0600EA5B RID: 59995 RVA: 0x003E7677 File Offset: 0x003E5877
		public List<int> getAllMount()
		{
			return this.s_MountMap;
		}

		// Token: 0x0600EA5C RID: 59996 RVA: 0x003E7680 File Offset: 0x003E5880
		public int getTargetItemId(int id)
		{
			core.config.midleExchangeItems.IItemsItem itemsItem;
			if (this.s_ItemMidleExchangeDict.TryGetValue(id, out itemsItem))
			{
				return itemsItem.TargetId;
			}
			return -1;
		}

		// Token: 0x0600EA5D RID: 59997 RVA: 0x003E76A8 File Offset: 0x003E58A8
		public ItemData getItemObj(int id)
		{
			ItemData result;
			if (this.s_ItemDict.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0600EA5E RID: 59998 RVA: 0x003E76C8 File Offset: 0x003E58C8
		public int getRarity(int id)
		{
			ItemData itemData;
			if (this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return itemData.GetRarity();
			}
			if (id == -999999)
			{
				return 5;
			}
			return 0;
		}

		// Token: 0x0600EA5F RID: 59999 RVA: 0x003E76F8 File Offset: 0x003E58F8
		public string getRarityBg(int itemID, string defaultSource = null, string type = "default")
		{
			if (defaultSource == null)
			{
				defaultSource = string.Empty;
			}
			int rarity = this.getRarity(itemID);
			if (type == "default")
			{
				if (rarity > 0)
				{
					return string.Format("Assets/Art/Ui/common/itemicon/rarity_item_{0}.png", rarity);
				}
				if (!string.IsNullOrEmpty(defaultSource))
				{
					return defaultSource;
				}
				return "Assets/Art/Ui/common/itemicon/rarity_item_0.png";
			}
			else
			{
				if (rarity > 0)
				{
					return SB.Empty + type + rarity + ".png";
				}
				return defaultSource;
			}
		}

		// Token: 0x0600EA60 RID: 60000 RVA: 0x003E776F File Offset: 0x003E596F
		public string getRarityBgByRarity(int rarity)
		{
			return string.Format("Assets/Art/Ui/common/itemicon/rarity_item_{0}.png", rarity);
		}

		// Token: 0x0600EA61 RID: 60001 RVA: 0x003E7784 File Offset: 0x003E5984
		public string getName(int id)
		{
			if (ResetableSingleTon<CountermarkXMLInfo>.Ins.isminMark(id))
			{
				return ResetableSingleTon<CountermarkXMLInfo>.Ins.getDes(id);
			}
			ItemData itemData;
			if (this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return itemData.GetName();
			}
			int num;
			if (this.s_ItemMidleDict.TryGetValue(id, out num))
			{
				return this.m_ItemMidleArray[num].Name;
			}
			core.config.midleExchangeItems.IItemsItem itemsItem;
			if (this.s_ItemMidleExchangeDict.TryGetValue(id, out itemsItem))
			{
				return itemsItem.Name;
			}
			return string.Empty;
		}

		// Token: 0x0600EA62 RID: 60002 RVA: 0x003E77FC File Offset: 0x003E59FC
		public int getPrice(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetPrice();
		}

		// Token: 0x0600EA63 RID: 60003 RVA: 0x003E7824 File Offset: 0x003E5A24
		public int getMax(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 999;
			}
			ICatsItem catsItem;
			if (itemData.GetMax() != 0 || !this.s_CatItemDict.TryGetValue(itemData.GetCatID(), out catsItem))
			{
				return itemData.GetMax();
			}
			int result;
			if (int.TryParse(catsItem.Max.ToString(), out result))
			{
				return result;
			}
			return int.MaxValue;
		}

		// Token: 0x0600EA64 RID: 60004 RVA: 0x003E788C File Offset: 0x003E5A8C
		public DateTime? getItemEnd(int id)
		{
			DateTime value;
			if (this.s_ItemInTimeUse.TryGetValue(id, out value))
			{
				return new DateTime?(value);
			}
			return null;
		}

		// Token: 0x0600EA65 RID: 60005 RVA: 0x003E78BC File Offset: 0x003E5ABC
		public string gettype(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return string.Empty;
			}
			return itemData.Gettype();
		}

		// Token: 0x0600EA66 RID: 60006 RVA: 0x003E78E8 File Offset: 0x003E5AE8
		public int getSelfType(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetSelfType();
		}

		// Token: 0x0600EA67 RID: 60007 RVA: 0x003E7910 File Offset: 0x003E5B10
		public int getUseMax(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetUseMax();
		}

		// Token: 0x0600EA68 RID: 60008 RVA: 0x003E7938 File Offset: 0x003E5B38
		public int getwd(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.Getwd();
		}

		// Token: 0x0600EA69 RID: 60009 RVA: 0x003E7960 File Offset: 0x003E5B60
		public int getIncreMonLvTo(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetIncreMonLvTo();
		}

		// Token: 0x0600EA6A RID: 60010 RVA: 0x003E7988 File Offset: 0x003E5B88
		public int getEvRemove(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetEvRemove();
		}

		// Token: 0x0600EA6B RID: 60011 RVA: 0x003E79B0 File Offset: 0x003E5BB0
		public string getUseEnd(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return string.Empty;
			}
			return itemData.GetUseEnd();
		}

		// Token: 0x0600EA6C RID: 60012 RVA: 0x003E79DC File Offset: 0x003E5BDC
		public int getBean(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetBean();
		}

		// Token: 0x0600EA6D RID: 60013 RVA: 0x003E7A04 File Offset: 0x003E5C04
		public int getSkinId(int id)
		{
			ItemData itemData;
			if (this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return itemData.GetSkinId();
			}
			core.config.midleExchangeItems.IItemsItem itemsItem;
			if (this.s_ItemMidleExchangeDict.TryGetValue(id, out itemsItem))
			{
				return itemsItem.SkinId;
			}
			return 0;
		}

		// Token: 0x0600EA6E RID: 60014 RVA: 0x003E7A40 File Offset: 0x003E5C40
		public int getpurpose(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.Getpurpose();
		}

		// Token: 0x0600EA6F RID: 60015 RVA: 0x003E7A68 File Offset: 0x003E5C68
		public string getIconURL(int id, int level = 1)
		{
			ItemData itemData;
			if (this.s_ItemDict.TryGetValue(id, out itemData) && itemData.Geticon() > 0)
			{
				id = itemData.Geticon();
			}
			return this.getSwfURL(id, level);
		}

		// Token: 0x0600EA70 RID: 60016 RVA: 0x003E7AA0 File Offset: 0x003E5CA0
		public int getLifeTime(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetLifeTime();
		}

		// Token: 0x0600EA71 RID: 60017 RVA: 0x003E7AC8 File Offset: 0x003E5CC8
		public int getRepairPrice(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetRepairPrice();
		}

		// Token: 0x0600EA72 RID: 60018 RVA: 0x003E7AF0 File Offset: 0x003E5CF0
		public bool isHide(int id)
		{
			ItemData itemData;
			return this.s_ItemDict.TryGetValue(id, out itemData) && itemData.IsHide();
		}

		// Token: 0x0600EA73 RID: 60019 RVA: 0x003E7B18 File Offset: 0x003E5D18
		public List<int> getLimitPetClass(int id)
		{
			ItemData itemData;
			if (this.s_ItemDict.TryGetValue(id, out itemData))
			{
				List<int> list = itemData.GetLimitPetClass();
				if (list == null)
				{
					list = new List<int>
					{
						0
					};
				}
				return list;
			}
			return new List<int>
			{
				0
			};
		}

		// Token: 0x0600EA74 RID: 60020 RVA: 0x003E7B5C File Offset: 0x003E5D5C
		public bool checkLimitPetClass(int itemId, int petId)
		{
			List<int> limitPetClass = this.getLimitPetClass(itemId);
			int petClass = ResetableSingleTon<PetXMLInfo>.Ins.getPetClass(petId);
			if (limitPetClass == null)
			{
				return true;
			}
			if (limitPetClass.Count == 1)
			{
				return limitPetClass[0] == 0 || petClass == limitPetClass[0];
			}
			return limitPetClass.IndexOf(petClass) != -1;
		}

		// Token: 0x0600EA75 RID: 60021 RVA: 0x003E7BB0 File Offset: 0x003E5DB0
		public int getPP(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetPP();
		}

		// Token: 0x0600EA76 RID: 60022 RVA: 0x003E7BD8 File Offset: 0x003E5DD8
		public float getSpeed(List<int> clothes)
		{
			foreach (int key in clothes)
			{
				ItemData itemData;
				if (this.s_ItemDict.TryGetValue(key, out itemData) && itemData.Gettype().Equals("foot") && itemData.Getspeed() != 0f)
				{
					return itemData.Getspeed() / 2f;
				}
			}
			return (float)ResetableSingleTon<MainManager>.Ins.DefSpeed / 2f;
		}

		// Token: 0x0600EA77 RID: 60023 RVA: 0x003E7C70 File Offset: 0x003E5E70
		public int getCatID(int id)
		{
			ItemData itemData;
			if (this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return itemData.GetCatID();
			}
			int num;
			if (this.s_ItemMidleDict.TryGetValue(id, out num))
			{
				return this.m_ItemMidleArray[num].catID;
			}
			core.config.midleExchangeItems.IItemsItem itemsItem;
			if (this.s_ItemMidleExchangeDict.TryGetValue(id, out itemsItem))
			{
				return itemsItem.catID;
			}
			return -1;
		}

		// Token: 0x0600EA78 RID: 60024 RVA: 0x003E7CCC File Offset: 0x003E5ECC
		public bool getIsSuper(int id)
		{
			ItemData itemData;
			return this.s_ItemDict.TryGetValue(id, out itemData) && itemData.IsSuper();
		}

		// Token: 0x0600EA79 RID: 60025 RVA: 0x003E7CF4 File Offset: 0x003E5EF4
		public bool isSpecialItem(int id)
		{
			ItemData itemData;
			return this.s_ItemDict.TryGetValue(id, out itemData) && itemData.IsSpecial();
		}

		// Token: 0x0600EA7A RID: 60026 RVA: 0x003E7D1C File Offset: 0x003E5F1C
		public int getSkillStoneRank(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetRank();
		}

		// Token: 0x0600EA7B RID: 60027 RVA: 0x003E7D44 File Offset: 0x003E5F44
		public int getSkillStoneNeedLV(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetNeedLv();
		}

		// Token: 0x0600EA7C RID: 60028 RVA: 0x003E7D6C File Offset: 0x003E5F6C
		public int getSort(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GetSort();
		}

		// Token: 0x0600EA7D RID: 60029 RVA: 0x003E7D94 File Offset: 0x003E5F94
		public int gethideNum(int id)
		{
			ItemData itemData;
			if (!this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return 0;
			}
			return itemData.GethideNum();
		}

		// Token: 0x0600EA7E RID: 60030 RVA: 0x003E7DBC File Offset: 0x003E5FBC
		public bool getItemIsType(int itemId, int type)
		{
			List<int> list;
			return this.s_TypeDict.TryGetValue(type, out list) && list.Contains(itemId);
		}

		// Token: 0x0600EA7F RID: 60031 RVA: 0x003E7DE4 File Offset: 0x003E5FE4
		public List<int> getItemIdsByBagItemType(int type)
		{
			List<int> result;
			if (!this.s_TypeDict.TryGetValue(type, out result))
			{
				return new List<int>();
			}
			return result;
		}

		// Token: 0x0600EA80 RID: 60032 RVA: 0x003E7E08 File Offset: 0x003E6008
		public int getItemType(int id)
		{
			int catID = this.getCatID(id);
			int result;
			if (this.petArray.IndexOf(id) >= 0)
			{
				result = ItemType.PET_ITEM;
			}
			else if (id > 10000 && id < 100000)
			{
				result = ItemType.COLLECTON;
			}
			else if ((id >= 100001 && id <= 200000) || (id >= 1300001 && id <= 1400000))
			{
				result = ItemType.CLOTH;
			}
			else if ((id >= 200001 && id <= 300000) || id == 1)
			{
				result = ItemType.DOODLE;
			}
			else if ((id >= 300001 && id <= 400000) || catID == 16)
			{
				result = ItemType.PET_PROPERTY;
			}
			else if ((id >= 400001 && id <= 500000) || (id >= 1200001 && id <= 1300000) || (id >= 1500001 && id <= 1506500))
			{
				result = ItemType.COLLECTON;
			}
			else if (id >= 500001 && id <= 600000)
			{
				result = ItemType.FITMENT;
			}
			else if (id >= 1000001 && id <= 1100000)
			{
				result = ItemType.SOULBEAD;
			}
			else if (catID == 17 || this.virtualArray.IndexOf(id) >= 0)
			{
				result = ItemType.COLLECTON;
			}
			else if (catID == 18)
			{
				result = ItemType.GEM_ITEM;
			}
			else if (catID == 19)
			{
				result = ItemType.GEM_ASSIST_ITEM;
			}
			else if (new List<int>
			{
				20,
				21
			}.IndexOf(catID) != -1)
			{
				result = ItemType.COLLECTON;
			}
			else
			{
				result = ItemType.SUIT;
			}
			return result;
		}

		// Token: 0x0600EA81 RID: 60033 RVA: 0x003E7F8C File Offset: 0x003E618C
		public int getExchangeType(int id)
		{
			ItemData itemData;
			if (this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return itemData.GetExchangeType();
			}
			core.config.midleExchangeItems.IItemsItem itemsItem;
			if (this.s_ItemMidleExchangeDict.TryGetValue(id, out itemsItem))
			{
				return itemsItem.ExchangeType;
			}
			return -1;
		}

		// Token: 0x0600EA82 RID: 60034 RVA: 0x003E7FC8 File Offset: 0x003E61C8
		public int getExchangeId(int id)
		{
			ItemData itemData;
			if (this.s_ItemDict.TryGetValue(id, out itemData))
			{
				return itemData.GetExchangeId();
			}
			core.config.midleExchangeItems.IItemsItem itemsItem;
			if (this.s_ItemMidleExchangeDict.TryGetValue(id, out itemsItem))
			{
				return itemsItem.ExchangeId;
			}
			return -1;
		}

		// Token: 0x0600EA83 RID: 60035 RVA: 0x003E8004 File Offset: 0x003E6204
		public bool isFifthSkillItem(int id, out int skillId)
		{
			ISpMovesItem spMovesItem;
			skillId = (this.s_DictFifthSkillItem.TryGetValue(id, out spMovesItem) ? spMovesItem.moves : 0);
			return skillId > 0;
		}

		// Token: 0x0600EA84 RID: 60036 RVA: 0x003E8031 File Offset: 0x003E6231
		public bool isPetItem(int id)
		{
			return id <= 300250 || id >= 1600001 || (id >= 300601 && id <= 301200 && id != 300658);
		}

		// Token: 0x0600EA85 RID: 60037 RVA: 0x003E8062 File Offset: 0x003E6262
		public bool isQuicklyUse(int itemId)
		{
			return this.quicklyUseItemList.Contains(itemId);
		}

		// Token: 0x0400ED51 RID: 60753
		private List<int> s_MountMap = new List<int>();

		// Token: 0x0400ED52 RID: 60754
		private Dictionary<int, ItemData> s_ItemDict = new Dictionary<int, ItemData>(14591);

		// Token: 0x0400ED53 RID: 60755
		private Dictionary<int, int> s_ItemMidleDict;

		// Token: 0x0400ED54 RID: 60756
		private core.config.midleItems.IItemsItem[] m_ItemMidleArray;

		// Token: 0x0400ED55 RID: 60757
		private Dictionary<int, core.config.midleExchangeItems.IItemsItem> s_ItemMidleExchangeDict;

		// Token: 0x0400ED56 RID: 60758
		private Dictionary<int, ICatsItem> s_CatItemDict;

		// Token: 0x0400ED57 RID: 60759
		private Dictionary<int, List<int>> s_TypeDict;

		// Token: 0x0400ED58 RID: 60760
		private Dictionary<int, ISpMovesItem> s_DictFifthSkillItem = new Dictionary<int, ISpMovesItem>();

		// Token: 0x0400ED59 RID: 60761
		private List<string> s_ArrType = new List<string>
		{
			"head",
			"hand",
			"foot",
			"waist",
			"eye",
			"top"
		};

		// Token: 0x0400ED5A RID: 60762
		private List<int> s_ClothMap = new List<int>();

		// Token: 0x0400ED5B RID: 60763
		private Dictionary<int, DateTime> s_ItemInTimeUse = new Dictionary<int, DateTime>(37);

		// Token: 0x0400ED5C RID: 60764
		private byte[] s_ItemBytes;

		// Token: 0x0400ED5D RID: 60765
		private byte[] s_CatBytes;

		// Token: 0x0400ED5E RID: 60766
		private byte[] s_ItemMidleBytes;

		// Token: 0x0400ED5F RID: 60767
		private byte[] s_ItemMidleExchangeBytes;

		// Token: 0x0400ED60 RID: 60768
		private List<int> petArray = new List<int>
		{
			1500008,
			1500045,
			1500071,
			1500076,
			1500078,
			1500080,
			1500081,
			1500084,
			1500228,
			1500257,
			1500345,
			1500340,
			1500315,
			1500242,
			1500230,
			1500204,
			1500286,
			400127,
			400133,
			400152,
			400158,
			400159,
			400207,
			400215,
			400230,
			400240,
			400281,
			400293,
			400295,
			400303,
			400324,
			400338,
			400415,
			400426,
			400438,
			400439,
			400457,
			400478,
			400481,
			1709076,
			1709077,
			1709078,
			1709079,
			1709080,
			1709081,
			1709082,
			1709083,
			1709084,
			1709085,
			1709086,
			1709087,
			1709088,
			1709089,
			1709090,
			1709091,
			1709092,
			1709093,
			1709094,
			1709095,
			1710550,
			1710551,
			1710552,
			1710553,
			1710554,
			1710555,
			1713276,
			1713277,
			1713278,
			1713279,
			1713280,
			1713281,
			1713282,
			1713283
		};

		// Token: 0x0400ED61 RID: 60769
		private List<int> virtualArray = new List<int>
		{
			1400352
		};

		// Token: 0x0400ED62 RID: 60770
		private readonly List<int> quicklyUseItemList = new List<int>
		{
			300122,
			300652,
			300706,
			300123,
			300653,
			300707,
			300654,
			300129,
			300874,
			300021,
			300617,
			300618,
			300665,
			300666,
			300667
		};
	}
}
