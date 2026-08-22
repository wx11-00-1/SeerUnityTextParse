using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.petbook;

namespace core.config
{
	// Token: 0x02001FA6 RID: 8102
	public class PetBookXMLInfo : ConfigManagerSingleton<PetBookXMLInfo>
	{


		// Token: 0x0600F24D RID: 62029 RVA: 0x00403FE4 File Offset: 0x004021E4
		public List<int> getRecMinMark(int index)
		{
			List<int> list = new List<int>();
			IPlaceItem[] recMintmarkXml = this.getRecMintmarkXml();
			for (int i = 0; i < recMintmarkXml.Length; i++)
			{
				list.Add(recMintmarkXml[i].Mintmark[index]);
			}
			return list;
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x0600F24E RID: 62030 RVA: 0x0040401D File Offset: 0x0040221D
		public IMonsterItem[] dataList
		{
			get
			{
				return this.s_RootData.root.Monster;
			}
		}

		// Token: 0x0600F24F RID: 62031 RVA: 0x00404030 File Offset: 0x00402230
		public IMonsterItem getPetXML(int id)
		{
			IMonsterItem result;
			if (this.s_Monster.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x0600F250 RID: 62032 RVA: 0x00404050 File Offset: 0x00402250
		public List<int> idList
		{
			get
			{
				return this.s_Monster.Keys.ToList<int>();
			}
		}

		// Token: 0x0600F251 RID: 62033 RVA: 0x00404064 File Offset: 0x00402264
		public int[] getLabels(int id)
		{
			IPetDataItem[] hotPetXml = this.getHotPetXml();
			int i = 0;
			while (i < hotPetXml.Length)
			{
				IPetDataItem petDataItem = hotPetXml[i];
				if (petDataItem.pid == id)
				{
					if (petDataItem.TagB == null || (petDataItem.TagB.Length == 1 && petDataItem.TagB[0] == 0))
					{
						return null;
					}
					return petDataItem.TagB;
				}
				else
				{
					i++;
				}
			}
			return null;
		}

		// Token: 0x0600F252 RID: 62034 RVA: 0x004040BA File Offset: 0x004022BA
		public IPetDataItem[] getHotPetXml()
		{
			IHotPet hotPet = this.s_HotPet;
			if (hotPet == null)
			{
				return null;
			}
			return hotPet.PetData;
		}

		// Token: 0x0600F253 RID: 62035 RVA: 0x004040CD File Offset: 0x004022CD
		public IItem getHotspotXml()
		{
			IHotspot hotspot = this.s_Hotspot;
			if (hotspot == null)
			{
				return null;
			}
			return hotspot.item;
		}

		// Token: 0x0600F254 RID: 62036 RVA: 0x004040E0 File Offset: 0x004022E0
		public IPlaceItem[] getRecMintmarkXml()
		{
			IRecMintmark recMintmark = this.s_RecMintmark;
			if (recMintmark == null)
			{
				return null;
			}
			return recMintmark.place;
		}

		// Token: 0x0600F255 RID: 62037 RVA: 0x004040F4 File Offset: 0x004022F4
		public string getJumptarget(int id)
		{
			IMonsterItem petXML = this.getPetXML(id);
			if (petXML == null)
			{
				return "";
			}
			return petXML.Target;
		}

		// Token: 0x0400F51E RID: 62750
		private IHotPet s_HotPet;

		// Token: 0x0400F51F RID: 62751
		private IHotspot s_Hotspot;

		// Token: 0x0400F520 RID: 62752
		private IRecMintmark s_RecMintmark;

		// Token: 0x0400F521 RID: 62753
		private Dictionary<int, IMonsterItem> s_Monster;

		// Token: 0x0400F522 RID: 62754
		private IRootInterface s_RootData;
	}
}
