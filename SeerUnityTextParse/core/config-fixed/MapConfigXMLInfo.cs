using System;
using System.Collections.Generic;
using common;
using core.config.map_config;



namespace core.config
{
	// Token: 0x02001EA7 RID: 7847
	public class MapConfigXMLInfo : ConfigManagerSingleton<MapConfigXMLInfo>
	{
		// Token: 0x0600EA88 RID: 60040 RVA: 0x003E8502 File Offset: 0x003E6702
		

		// Token: 0x0600EA89 RID: 60041 RVA: 0x003E852F File Offset: 0x003E672F
		

		// Token: 0x0600EA8A RID: 60042 RVA: 0x003E8540 File Offset: 0x003E6740
		

		// Token: 0x0600EA8B RID: 60043 RVA: 0x003E8584 File Offset: 0x003E6784
		public IMapItem getMap(int mapId)
		{
			IMapInfo item = ResetableSingleTon<Map>.Ins.getItem(mapId);
			if (item == null)
			{
				return null;
			}
			IMapItem result;
			if (!this.m_MapConfigMap.TryGetValue(item.pic, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EA8C RID: 60044 RVA: 0x003E85BC File Offset: 0x003E67BC
		private IComponentItem getChangeMapComp(int mapId, int teleportId)
		{
			IMapItem map = this.getMap(mapId);
			if (map != null && map.changeMapComp != null && map.changeMapComp.component.Length > teleportId)
			{
				return map.changeMapComp.component[teleportId];
			}
			return null;
		}

		// Token: 0x0600EA8D RID: 60045 RVA: 0x003E85FC File Offset: 0x003E67FC
		//public Vector2 getTeleportPos(int mapId, int teleportId)
		//{
		//	IComponentItem changeMapComp = this.getChangeMapComp(mapId, teleportId);
		//	if (changeMapComp != null)
		//	{
		//		return new Vector2(changeMapComp.x, changeMapComp.y);
		//	}
		//	return Vector2.zero;
		//}

		// Token: 0x0600EA8E RID: 60046 RVA: 0x003E862C File Offset: 0x003E682C
		public int getTargetMapId(int mapId, int teleportId)
		{
			IComponentItem changeMapComp = this.getChangeMapComp(mapId, teleportId);
			if (changeMapComp == null)
			{
				return 0;
			}
			IMapInfo item = ResetableSingleTon<Map>.Ins.getItem(this.getTrueMapId(changeMapComp.targetID));
			if (item == null)
			{
				return 0;
			}
			return item.id;
		}

		// Token: 0x0600EA8F RID: 60047 RVA: 0x003E866C File Offset: 0x003E686C
		public string getTargetMapName(int mapId, int teleportId)
		{
			IComponentItem changeMapComp = this.getChangeMapComp(mapId, teleportId);
			if (changeMapComp == null)
			{
				return string.Empty;
			}
			int trueMapId = this.getTrueMapId(changeMapComp.targetID);
			IMapInfo item = ResetableSingleTon<Map>.Ins.getItem(trueMapId);
			if (item == null)
			{
				return string.Empty;
			}
			return item.name;
		}

		// Token: 0x0600EA90 RID: 60048 RVA: 0x003E86B4 File Offset: 0x003E68B4
		private int getTrueMapId(int targetID)
		{
			this.initMapUrlKeyInfoMap();
			IMapInfo mapInfo;
			if (!this.m_MapUrlKeyInfoMap.TryGetValue(targetID, out mapInfo))
			{
				return 0;
			}
			return mapInfo.id;
		}

		// Token: 0x0600EA91 RID: 60049 RVA: 0x003E86E0 File Offset: 0x003E68E0
		private void initMapUrlKeyInfoMap()
		{
			if (this.m_IsInitMapUrlKeyInfoMap)
			{
				return;
			}
			if (this.m_MapUrlKeyInfoMap == null)
			{
				this.m_MapUrlKeyInfoMap = new Dictionary<int, IMapInfo>();
			}
			foreach (IMapInfo mapInfo in ResetableSingleTon<Map>.Ins.getItems())
			{
				this.m_MapUrlKeyInfoMap.ContainsKey(mapInfo.pic);
				this.m_MapUrlKeyInfoMap.TryAdd(mapInfo.pic, mapInfo);
			}
			this.m_IsInitMapUrlKeyInfoMap = true;
		}

		// Token: 0x0600EA92 RID: 60050 RVA: 0x003E8754 File Offset: 0x003E6954
		public IEntryItem getMapByEntry(int fromMapId, int toMapId)
		{
			IMapInfo item = ResetableSingleTon<Map>.Ins.getItem(fromMapId);
			if (item == null)
			{
				return null;
			}
			IMapItem map = this.getMap(toMapId);
			if (map != null)
			{
				IEntries entries = map.Entries;
				if (entries != null && entries.Entry != null)
				{
					foreach (IEntryItem entryItem in entries.Entry)
					{
						if (entryItem.FromMap == item.pic)
						{
							return entryItem;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x0400ED63 RID: 60771
		private Dictionary<int, IMapItem> m_MapConfigMap;

		// Token: 0x0400ED64 RID: 60772
		private Dictionary<int, IMapInfo> m_MapUrlKeyInfoMap;

		// Token: 0x0400ED65 RID: 60773
		private bool m_IsInitMapUrlKeyInfoMap;
	}
}
