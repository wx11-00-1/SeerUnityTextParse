using System;
using System.Collections.Generic;
using common;
using core.config.energyCollect;
//using Cysharp.Threading.Tasks;
//using Cysharp.Threading.Tasks.CompilerServices;

namespace core.config
{
	// Token: 0x02001E9D RID: 7837
	public class EnergyCollectXMLInfo : ConfigManagerSingleton<EnergyCollectXMLInfo>
	{
		// Token: 0x0600EA02 RID: 59906 RVA: 0x003E63E8 File Offset: 0x003E45E8
		//

		// Token: 0x0600EA03 RID: 59907 RVA: 0x003E63F6 File Offset: 0x003E45F6
		//

		// Token: 0x0600EA04 RID: 59908 RVA: 0x003E6408 File Offset: 0x003E4608
		//

		// Token: 0x0600EA05 RID: 59909 RVA: 0x003E644B File Offset: 0x003E464B
		public bool Exist(int type)
		{
			return this._energyItemMap.ContainsKey(type);
		}

		// Token: 0x0600EA06 RID: 59910 RVA: 0x003E645C File Offset: 0x003E465C
		public string getName(int type)
		{
			IEnergyItem energyItem;
			if (this._energyItemMap.TryGetValue(type, out energyItem))
			{
				return energyItem.name;
			}
			return string.Empty;
		}

		// Token: 0x0600EA07 RID: 59911 RVA: 0x003E6488 File Offset: 0x003E4688
		public string getColtType(int type)
		{
			IEnergyItem energyItem;
			if (this._energyItemMap.TryGetValue(type, out energyItem))
			{
				return energyItem.collectType;
			}
			return string.Empty;
		}

		// Token: 0x0600EA08 RID: 59912 RVA: 0x003E64B4 File Offset: 0x003E46B4
		public int GetColtCnt(int type)
		{
			IEnergyItem energyItem;
			if (this._energyItemMap.TryGetValue(type, out energyItem))
			{
				return energyItem.collectCnt;
			}
			return 0;
		}

		// Token: 0x0600EA09 RID: 59913 RVA: 0x003E64DC File Offset: 0x003E46DC
		public string getUnit(int type)
		{
			IEnergyItem energyItem;
			if (this._energyItemMap.TryGetValue(type, out energyItem))
			{
				return energyItem.unit;
			}
			return string.Empty;
		}

		// Token: 0x0600EA0A RID: 59914 RVA: 0x003E6508 File Offset: 0x003E4708
		public int getDir(int type)
		{
			IEnergyItem energyItem;
			if (this._energyItemMap.TryGetValue(type, out energyItem))
			{
				return energyItem.dir;
			}
			return 0;
		}

		// Token: 0x0400ED33 RID: 60723
		private Dictionary<int, IEnergyItem> _energyItemMap;
	}
}
