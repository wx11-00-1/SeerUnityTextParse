using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.effectbuff;
using core.config.signIcon_fight;


namespace core.config
{
	// Token: 0x02001EBC RID: 7868
	public class SignIconXmlInfo : ConfigManagerSingleton<SignIconXmlInfo>
	{
		// Token: 0x0600EB51 RID: 60241 RVA: 0x003ED0CC File Offset: 0x003EB2CC
		

		// Token: 0x0600EB52 RID: 60242 RVA: 0x003ED12D File Offset: 0x003EB32D
		

		// Token: 0x0600EB53 RID: 60243 RVA: 0x003ED13C File Offset: 0x003EB33C
		

		// Token: 0x0600EB54 RID: 60244 RVA: 0x003ED180 File Offset: 0x003EB380
		private Dictionary<int, string> getSpHashMap(string[] spStr)
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>(spStr.Length);
			for (int i = 0; i < spStr.Length; i++)
			{
				if (!string.IsNullOrEmpty(spStr[i]))
				{
					string[] array = spStr[i].Split("_", StringSplitOptions.None);
					dictionary.Add(int.Parse(array[0]), array[1]);
				}
			}
			return dictionary;
		}

		// Token: 0x0600EB55 RID: 60245 RVA: 0x003ED1D0 File Offset: 0x003EB3D0
		private Dictionary<int, string> getSpIconHashMap(string[] spIconStr)
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			for (int i = 0; i < spIconStr.Length; i++)
			{
				string[] array = spIconStr[i].Split("_", StringSplitOptions.None);
				dictionary.Add(int.Parse(array[0]), array[1]);
			}
			return dictionary;
		}

		// Token: 0x0600EB56 RID: 60246 RVA: 0x003ED214 File Offset: 0x003EB414
		private Dictionary<int, string> getHeadFrameHashMap(string[] headFrameIconStr)
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			for (int i = 0; i < headFrameIconStr.Length; i++)
			{
				string[] array = headFrameIconStr[i].Split("_", StringSplitOptions.None);
				dictionary.Add(int.Parse(array[0]), array[1]);
			}
			return dictionary;
		}

		// Token: 0x0600EB57 RID: 60247 RVA: 0x003ED258 File Offset: 0x003EB458
		private Dictionary<int, string> getsptipsHashMapByid(int id)
		{
			Dictionary<int, string> result;
			if (!this.s_SptipsHashMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB58 RID: 60248 RVA: 0x003ED278 File Offset: 0x003EB478
		private Dictionary<int, string> getspDesHashMapByid(int id)
		{
			Dictionary<int, string> result;
			if (!this.s_SpDesHashMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB59 RID: 60249 RVA: 0x003ED298 File Offset: 0x003EB498
		private Dictionary<int, string> getspIconHashMapByid(int id)
		{
			Dictionary<int, string> result;
			if (!this.s_SpIconHashMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB5A RID: 60250 RVA: 0x003ED2B8 File Offset: 0x003EB4B8
		private Dictionary<int, string> getHeadFrameHashMapByid(int id)
		{
			Dictionary<int, string> result;
			if (!this.s_HeadFrameHashMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB5B RID: 60251 RVA: 0x003ED2D8 File Offset: 0x003EB4D8
		public IItemItem[] getAllSignIconInfos()
		{
			return this.s_ItemHash.Values.ToArray<IItemItem>();
		}

		// Token: 0x0600EB5C RID: 60252 RVA: 0x003ED2EC File Offset: 0x003EB4EC
		public IItemItem getFieldEffectInfoById(int id)
		{
			if (this._fieldEffects == null)
			{
				this._fieldEffects = new Dictionary<int, IItemItem>();
			}
			IItemItem itemItem;
			if (!this._fieldEffects.TryGetValue(id, out itemItem))
			{
				IBuffItem buffXml = ResetableSingleTon<FieldEffectXMLInfo>.Ins.getBuffXml(id);
				itemItem = new IItemItem
				{
					id = ResetableSingleTon<FieldEffectXMLInfo>.Ins.GetFieldEffectYinJiId(id),
					dec = buffXml.Name,
					tips = buffXml.Name,
					sort = 1,
					isShowNum = 1,
					NumDes = "剩余回合",
					Des = buffXml.Desc,
					sptips = null,
					spDes = null,
					spicon = null,
					frame = null
				};
				this._fieldEffects.Add(id, itemItem);
			}
			return itemItem;
		}

		// Token: 0x0600EB5D RID: 60253 RVA: 0x003ED3AC File Offset: 0x003EB5AC
		public IItemItem getInfoById(int id)
		{
			IItemItem result;
			if (!this.s_ItemHash.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB5E RID: 60254 RVA: 0x003ED3CC File Offset: 0x003EB5CC
		public string getSptipsByidAndLvNum(int id, int lvNum)
		{
			Dictionary<int, string> dictionary = this.getsptipsHashMapByid(id);
			string result;
			if (dictionary != null && dictionary.TryGetValue(lvNum, out result))
			{
				return result;
			}
			return string.Empty;
		}

		// Token: 0x0600EB5F RID: 60255 RVA: 0x003ED3F8 File Offset: 0x003EB5F8
		public string getspDesByidAndLvNum(int id, int lvNum)
		{
			Dictionary<int, string> dictionary = this.getspDesHashMapByid(id);
			string result;
			if (dictionary != null && dictionary.TryGetValue(lvNum, out result))
			{
				return result;
			}
			return string.Empty;
		}

		// Token: 0x0600EB60 RID: 60256 RVA: 0x003ED424 File Offset: 0x003EB624
		public string getspIconByidAndLvNum(int id, int lvNum)
		{
			Dictionary<int, string> dictionary = this.getspIconHashMapByid(id);
			string result;
			if (dictionary != null && dictionary.TryGetValue(lvNum, out result))
			{
				return result;
			}
			return string.Empty;
		}

		// Token: 0x0600EB61 RID: 60257 RVA: 0x003ED450 File Offset: 0x003EB650
		public string getHeadFrameByidAndLvNum(int id, int lvNum)
		{
			Dictionary<int, string> headFrameHashMapByid = this.getHeadFrameHashMapByid(id);
			string result;
			if (headFrameHashMapByid != null && headFrameHashMapByid.TryGetValue(lvNum, out result))
			{
				return result;
			}
			return string.Empty;
		}

		// Token: 0x0600EB62 RID: 60258 RVA: 0x003ED47C File Offset: 0x003EB67C
		public bool TryGetHeadFrameByIdAndLvNum(int id, int lvNum, out string iconIndex)
		{
			IItemItem infoById = this.getInfoById(id);
			if (infoById == null || infoById.frame == null)
			{
				iconIndex = string.Empty;
				return false;
			}
			if (id <= 23 && this.getInfoById(id).isShowNum < 1)
			{
				iconIndex = string.Empty;
				return true;
			}
			if (!this.s_HeadFrameHashMap.ContainsKey(id))
			{
				iconIndex = string.Empty;
				return true;
			}
			iconIndex = this.getHeadFrameByidAndLvNum(id, lvNum);
			if (iconIndex == "0")
			{
				iconIndex = string.Empty;
				return true;
			}
			return true;
		}

		// Token: 0x0600EB63 RID: 60259 RVA: 0x003ED4FB File Offset: 0x003EB6FB
		public void parse()
		{
		}

		// Token: 0x0600EB64 RID: 60260 RVA: 0x003ED500 File Offset: 0x003EB700
		public bool IsSelfSource(int id)
		{
			IItemItem infoById = this.getInfoById(id);
			return infoById != null && infoById.sort != 5;
		}

		// Token: 0x0400EEDA RID: 61146
		private Dictionary<int, IItemItem> s_ItemHash = new Dictionary<int, IItemItem>(131);

		// Token: 0x0400EEDB RID: 61147
		private Dictionary<int, Dictionary<int, string>> s_SptipsHashMap = new Dictionary<int, Dictionary<int, string>>();

		// Token: 0x0400EEDC RID: 61148
		private Dictionary<int, Dictionary<int, string>> s_SpDesHashMap = new Dictionary<int, Dictionary<int, string>>(37);

		// Token: 0x0400EEDD RID: 61149
		private Dictionary<int, Dictionary<int, string>> s_SpIconHashMap = new Dictionary<int, Dictionary<int, string>>(11);

		// Token: 0x0400EEDE RID: 61150
		private Dictionary<int, Dictionary<int, string>> s_HeadFrameHashMap = new Dictionary<int, Dictionary<int, string>>(29);

		// Token: 0x0400EEDF RID: 61151
		private Dictionary<int, IItemItem> _fieldEffects;
	}
}
