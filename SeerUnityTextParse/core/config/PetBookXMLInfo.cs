using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.petbook;


namespace core.config
{
	// Token: 0x02001EB2 RID: 7858
	public class PetBookXMLInfo : ConfigManagerSingleton<PetBookXMLInfo>
	{
		// Token: 0x0600EAD9 RID: 60121 RVA: 0x003EB15F File Offset: 0x003E935F
		

		// Token: 0x0600EADA RID: 60122 RVA: 0x003EB16C File Offset: 0x003E936C
		

		// Token: 0x0600EADB RID: 60123 RVA: 0x003EB17C File Offset: 0x003E937C
		

		// Token: 0x0600EADC RID: 60124 RVA: 0x003EB1BF File Offset: 0x003E93BF
		public IPlaceItem[] getWeekHotPets()
		{
			return this.getHotspotXml().place;
		}

		// Token: 0x0600EADD RID: 60125 RVA: 0x003EB1CC File Offset: 0x003E93CC
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

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x0600EADE RID: 60126 RVA: 0x003EB205 File Offset: 0x003E9405
		public IMonsterItem[] dataList
		{
			get
			{
				return this.s_RootData.root.Monster;
			}
		}

		// Token: 0x0600EADF RID: 60127 RVA: 0x003EB218 File Offset: 0x003E9418
		public IMonsterItem getPetXML(int id)
		{
			IMonsterItem result;
			if (this.s_Monster.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x0600EAE0 RID: 60128 RVA: 0x003EB238 File Offset: 0x003E9438
		public List<int> idList
		{
			get
			{
				return this.s_Monster.Keys.ToList<int>();
			}
		}

		// Token: 0x0600EAE1 RID: 60129 RVA: 0x003EB24C File Offset: 0x003E944C
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

		// Token: 0x0600EAE2 RID: 60130 RVA: 0x003EB2A2 File Offset: 0x003E94A2
		public IPetDataItem[] getHotPetXml()
		{
			IHotPet hotPet = this.s_HotPet;
			if (hotPet == null)
			{
				return null;
			}
			return hotPet.PetData;
		}

		// Token: 0x0600EAE3 RID: 60131 RVA: 0x003EB2B5 File Offset: 0x003E94B5
		public IItem getHotspotXml()
		{
			IHotspot hotspot = this.s_Hotspot;
			if (hotspot == null)
			{
				return null;
			}
			return hotspot.item;
		}

		// Token: 0x0600EAE4 RID: 60132 RVA: 0x003EB2C8 File Offset: 0x003E94C8
		public IPlaceItem[] getRecMintmarkXml()
		{
			IRecMintmark recMintmark = this.s_RecMintmark;
			if (recMintmark == null)
			{
				return null;
			}
			return recMintmark.place;
		}

		// Token: 0x0600EAE5 RID: 60133 RVA: 0x003EB2DC File Offset: 0x003E94DC
		public string getJumptarget(int id)
		{
			IMonsterItem petXML = this.getPetXML(id);
			if (petXML == null)
			{
				return "";
			}
			return petXML.Target;
		}

		// Token: 0x0400EEBB RID: 61115
		private IHotPet s_HotPet;

		// Token: 0x0400EEBC RID: 61116
		private IHotspot s_Hotspot;

		// Token: 0x0400EEBD RID: 61117
		private IRecMintmark s_RecMintmark;

		// Token: 0x0400EEBE RID: 61118
		private Dictionary<int, IMonsterItem> s_Monster;

		// Token: 0x0400EEBF RID: 61119
		private IRootInterface s_RootData;
	}
}
