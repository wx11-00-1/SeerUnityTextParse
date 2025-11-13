using System;
using System.Collections.Generic;
using common;
using core.config.monsters;
using core.model;



namespace core.config
{
	// Token: 0x02001EB9 RID: 7865
	public class PetXMLInfo : ConfigManagerSingleton<PetXMLInfo>
	{
		// Token: 0x0600EB22 RID: 60194 RVA: 0x003EC15C File Offset: 0x003EA35C
		

		// Token: 0x0600EB23 RID: 60195 RVA: 0x003EC169 File Offset: 0x003EA369
		

		// Token: 0x0600EB24 RID: 60196 RVA: 0x003EC178 File Offset: 0x003EA378
		

		// Token: 0x0600EB25 RID: 60197 RVA: 0x003EC1BC File Offset: 0x003EA3BC
		public string getName(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem))
			{
				return string.Empty;
			}
			return monsterItem.DefName;
		}

		// Token: 0x0600EB26 RID: 60198 RVA: 0x003EC1E8 File Offset: 0x003EA3E8
		public int getRealId(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem) || monsterItem.RealId <= 0)
			{
				return id;
			}
			return monsterItem.RealId;
		}

		// Token: 0x0600EB27 RID: 60199 RVA: 0x003EC218 File Offset: 0x003EA418
		public int getCombo(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem) || monsterItem.Combo <= 0)
			{
				return id;
			}
			return monsterItem.Combo;
		}

		// Token: 0x0600EB28 RID: 60200 RVA: 0x003EC248 File Offset: 0x003EA448
		public int getTransform(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem) || monsterItem.Transform <= 0)
			{
				return id;
			}
			return monsterItem.Transform;
		}

		// Token: 0x0600EB29 RID: 60201 RVA: 0x003EC278 File Offset: 0x003EA478
		public int getType(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem))
			{
				//Debug.LogError("PetXMLInfo.getType: id = " + id.ToString() + " not found");
				return 0;
			}
			return monsterItem.Type;
		}

		// Token: 0x0600EB2A RID: 60202 RVA: 0x003EC2B8 File Offset: 0x003EA4B8
		public bool isRealPet(int id)
		{
			IMonsterItem monsterItem;
			return this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.RealId <= 0;
		}

		// Token: 0x0600EB2B RID: 60203 RVA: 0x003EC2E4 File Offset: 0x003EA4E4
		public bool checkSuper(int id)
		{
			IMonsterItem monsterItem;
			return this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.Vip != 0;
		}

		// Token: 0x0600EB2C RID: 60204 RVA: 0x003EC30C File Offset: 0x003EA50C
		public int getEvolvFlag(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem))
			{
				return 0;
			}
			return monsterItem.EvolvFlag;
		}

		// Token: 0x0600EB2D RID: 60205 RVA: 0x003EC334 File Offset: 0x003EA534
		public int getEvolvingLv(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem))
			{
				return 0;
			}
			return monsterItem.EvolvingLv;
		}

		// Token: 0x0600EB2E RID: 60206 RVA: 0x003EC35C File Offset: 0x003EA55C
		public List<int> getSkillListForLv(int id, int lv)
		{
			List<int> list = new List<int>();
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.LearnableMoves != null)
			{
				for (int i = 0; i < monsterItem.LearnableMoves.Move.Length; i++)
				{
					if (monsterItem.LearnableMoves.Move[i].LearningLv <= lv)
					{
						list.Add(monsterItem.LearnableMoves.Move[i].ID);
					}
				}
			}
			return list;
		}

		// Token: 0x0600EB2F RID: 60207 RVA: 0x003EC3D0 File Offset: 0x003EA5D0
		public List<int> getCanLearnSkillList(int id)
		{
			List<int> list = new List<int>();
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.LearnableMoves != null)
			{
				for (int i = 0; i < monsterItem.LearnableMoves.Move.Length; i++)
				{
					list.Add(monsterItem.LearnableMoves.Move[i].ID);
				}
			}
			return list;
		}

		// Token: 0x0600EB30 RID: 60208 RVA: 0x003EC42C File Offset: 0x003EA62C
		public List<int> getCanLearnSPSkillList(int id)
		{
			List<int> list = new List<int>();
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.LearnableMoves != null && monsterItem.LearnableMoves.SpMove != null)
			{
				for (int i = 0; i < monsterItem.LearnableMoves.SpMove.Length; i++)
				{
					list.Add(monsterItem.LearnableMoves.SpMove[i].ID);
				}
			}
			return list;
		}

		// Token: 0x0600EB31 RID: 60209 RVA: 0x003EC498 File Offset: 0x003EA698
		public List<int> getAdvanceSkill(int id)
		{
			List<int> list = new List<int>();
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.LearnableMoves != null && monsterItem.LearnableMoves.AdvMove != null)
			{
				for (int i = 0; i < monsterItem.LearnableMoves.AdvMove.Length; i++)
				{
					list.Add(monsterItem.LearnableMoves.AdvMove[i].ID);
				}
			}
			return list;
		}

		// Token: 0x0600EB32 RID: 60210 RVA: 0x003EC504 File Offset: 0x003EA704
		public List<int> GetDefaultSkillIds(int petId)
		{
			List<int> list = new List<int>();
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(petId, out monsterItem) && monsterItem.LearnableMoves != null)
			{
				for (int i = 0; i < monsterItem.LearnableMoves.Move.Length; i++)
				{
					if (monsterItem.LearnableMoves.Move[i].Tag >= 1 && monsterItem.LearnableMoves.Move[i].Tag <= 4)
					{
						list.Add(monsterItem.LearnableMoves.Move[i].ID);
					}
				}
			}
			IMonsterItem monsterItem2;
			if (list.Count == 0 && this.MonsterMap.TryGetValue(petId, out monsterItem2) && monsterItem2.LearnableMoves != null)
			{
				for (int j = monsterItem2.LearnableMoves.Move.Length - 4; j < monsterItem2.LearnableMoves.Move.Length; j++)
				{
					list.Add(monsterItem2.LearnableMoves.Move[j].ID);
				}
			}
			return list;
		}

		// Token: 0x0600EB33 RID: 60211 RVA: 0x003EC5F0 File Offset: 0x003EA7F0
		public List<int> getCanLearnAdvSkillTagList(int id)
		{
			List<int> list = new List<int>();
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.LearnableMoves != null && monsterItem.LearnableMoves.AdvMove != null)
			{
				for (int i = 0; i < monsterItem.LearnableMoves.AdvMove.Length; i++)
				{
					list.Add(monsterItem.LearnableMoves.AdvMove[i].Tag);
				}
			}
			return list;
		}

		// Token: 0x0600EB34 RID: 60212 RVA: 0x003EC659 File Offset: 0x003EA859
		public string getTypeCN(int id)
		{
			return ResetableSingleTon<SkillXMLInfo>.Ins.petTypeNameCN(this.getType(id));
		}

		// Token: 0x0600EB35 RID: 60213 RVA: 0x003EC66C File Offset: 0x003EA86C
		public int getPetGender(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem))
			{
				return 0;
			}
			return monsterItem.Gender;
		}

		// Token: 0x0600EB36 RID: 60214 RVA: 0x003EC691 File Offset: 0x003EA891
		public string getPetGenderCN(int i)
		{
			if (i == 1)
			{
				return "雄性";
			}
			if (i == 2)
			{
				return "雌性";
			}
			return "无性别";
		}

		// Token: 0x0600EB37 RID: 60215 RVA: 0x003EC6AC File Offset: 0x003EA8AC
		public bool isFlyPet(int id)
		{
			IMonsterItem monsterItem;
			return this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.isFlyPet != 0;
		}

		// Token: 0x0600EB38 RID: 60216 RVA: 0x003EC6D4 File Offset: 0x003EA8D4
		public bool isRidePet(int id)
		{
			IMonsterItem monsterItem;
			return this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.isRidePet != 0;
		}
		// Token: 0x0600EB3A RID: 60218 RVA: 0x003EC844 File Offset: 0x003EAA44
		public int getEvolvesTo(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem) || monsterItem.EvolvesTo == 0)
			{
				return 0;
			}
			return monsterItem.EvolvesTo;
		}

		// Token: 0x0600EB3B RID: 60219 RVA: 0x003EC874 File Offset: 0x003EAA74
		public int[] getAllEvById(int id)
		{
			int[] array = new int[6];
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem))
			{
				array[0] = monsterItem.HP;
				array[1] = monsterItem.Atk;
				array[2] = monsterItem.Def;
				array[3] = monsterItem.SpAtk;
				array[4] = monsterItem.SpDef;
				array[5] = monsterItem.Spd;
			}
			return array;
		}

		// Token: 0x0600EB3C RID: 60220 RVA: 0x003EC8D0 File Offset: 0x003EAAD0
		public List<int> getSkillListRecommend(int id)
		{
			List<int> list = new List<int>();
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.Move != null)
			{
				for (int i = 0; i < monsterItem.LearnableMoves.Move.Length; i++)
				{
					if (monsterItem.LearnableMoves.Move[i].Rec == 1)
					{
						list.Add(monsterItem.LearnableMoves.Move[i].ID);
					}
				}
			}
			return list;
		}

		// Token: 0x0600EB3D RID: 60221 RVA: 0x003EC944 File Offset: 0x003EAB44
		public List<IMoveItem> getRecSkillList(int id)
		{
			List<IMoveItem> list = new List<IMoveItem>();
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.LearnableMoves != null)
			{
				for (int i = 0; i < monsterItem.LearnableMoves.Move.Length; i++)
				{
					if (monsterItem.LearnableMoves.Move[i].Rec == 1)
					{
						list.Add(monsterItem.LearnableMoves.Move[i]);
					}
				}
			}
			return list;
		}

		// Token: 0x0600EB3E RID: 60222 RVA: 0x003EC9B0 File Offset: 0x003EABB0
		public IMoveItem getExtraSkill(int id)
		{
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.ExtraMoves != null)
			{
				return monsterItem.ExtraMoves.Move[0];
			}
			return null;
		}

		// Token: 0x0600EB3F RID: 60223 RVA: 0x003EC9E4 File Offset: 0x003EABE4
		public int getOFifthSkill(int id)
		{
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.ExtraMoves != null && monsterItem.ExtraMoves.Move != null && monsterItem.ExtraMoves.Move.Length != 0)
			{
				return monsterItem.ExtraMoves.Move[0].ID;
			}
			return 0;
		}

		// Token: 0x0600EB40 RID: 60224 RVA: 0x003ECA38 File Offset: 0x003EAC38
		public int getPetClass(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem) || monsterItem.PetClass == 0)
			{
				return -1;
			}
			return monsterItem.PetClass;
		}

		// Token: 0x0600EB41 RID: 60225 RVA: 0x003ECA65 File Offset: 0x003EAC65
		public bool isCombinationBonusPet(int id)
		{
			return this.CombinationBonusPetIds.IndexOf(id) != -1;
		}

		// Token: 0x0600EB42 RID: 60226 RVA: 0x003ECA7C File Offset: 0x003EAC7C
		public int getCharacterAttrParam(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem))
			{
				return -1;
			}
			return monsterItem.CharacterAttrParam;
		}

		// Token: 0x0600EB43 RID: 60227 RVA: 0x003ECAA1 File Offset: 0x003EACA1
		public List<int> getShowExtra(int id)
		{
			return new List<int>();
		}

		// Token: 0x0600EB44 RID: 60228 RVA: 0x003ECAA8 File Offset: 0x003EACA8
		public List<int> getAdditionFifthSkill(int id)
		{
			List<int> list = new List<int>();
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.SpExtraMoves != null && monsterItem.SpExtraMoves.Move != null)
			{
				for (int i = 0; i < monsterItem.SpExtraMoves.Move.Length; i++)
				{
					list.Add(monsterItem.SpExtraMoves.Move[i].ID);
				}
			}
			return list;
		}

		// Token: 0x0600EB45 RID: 60229 RVA: 0x003ECB14 File Offset: 0x003EAD14
		public bool checkIsAdditionFifthSkill(int id, int skillId)
		{
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.SpExtraMoves != null && monsterItem.SpExtraMoves.Move != null)
			{
				for (int i = 0; i < monsterItem.SpExtraMoves.Move.Length; i++)
				{
					if (monsterItem.SpExtraMoves.Move[i].ID == skillId)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600EB46 RID: 60230 RVA: 0x003ECB78 File Offset: 0x003EAD78
		public int getFreeForbidden(int id)
		{
			IMonsterItem monsterItem;
			if (!this.MonsterMap.TryGetValue(id, out monsterItem))
			{
				return 0;
			}
			return monsterItem.FreeForbidden;
		}

		// Token: 0x0600EB47 RID: 60231 RVA: 0x003ECBA0 File Offset: 0x003EADA0
		private IMoveItem[] getPetMove(int petId)
		{
			IMoveItem[] result = null;
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(petId, out monsterItem) && monsterItem.LearnableMoves != null)
			{
				return monsterItem.LearnableMoves.Move;
			}
			return result;
		}

		// Token: 0x0600EB48 RID: 60232 RVA: 0x003ECBD4 File Offset: 0x003EADD4
		private ISpMoveItem[] getPetSpMove(int petId)
		{
			ISpMoveItem[] result = null;
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(petId, out monsterItem) && monsterItem.LearnableMoves != null)
			{
				return monsterItem.LearnableMoves.SpMove;
			}
			return result;
		}

		// Token: 0x0600EB49 RID: 60233 RVA: 0x003ECC08 File Offset: 0x003EAE08
		private ISpMoveItem[] getPetAdvMove(int petId)
		{
			ISpMoveItem[] result = null;
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(petId, out monsterItem) && monsterItem.LearnableMoves != null)
			{
				return monsterItem.LearnableMoves.AdvMove;
			}
			return result;
		}

		// Token: 0x0600EB4A RID: 60234 RVA: 0x003ECC3C File Offset: 0x003EAE3C
		private IMoveItem[] getPetExtraMoves(int petId)
		{
			IMoveItem[] result = null;
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(petId, out monsterItem) && monsterItem.ExtraMoves != null)
			{
				return monsterItem.ExtraMoves.Move;
			}
			return result;
		}

		// Token: 0x0600EB4B RID: 60235 RVA: 0x003ECC70 File Offset: 0x003EAE70
		private IMoveItem[] getPetShowExtraMoves(int petId)
		{
			IMoveItem[] result = null;
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(petId, out monsterItem) && monsterItem.ShowExtraMoves != null)
			{
				return monsterItem.ShowExtraMoves.Move;
			}
			return result;
		}

		// Token: 0x0600EB4C RID: 60236 RVA: 0x003ECCA4 File Offset: 0x003EAEA4
		private IMoveItem[] getPetSpExtraMoves(int petId)
		{
			IMoveItem[] result = null;
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(petId, out monsterItem) && monsterItem.SpExtraMoves != null)
			{
				return monsterItem.SpExtraMoves.Move;
			}
			return result;
		}

		// Token: 0x0600EB4E RID: 60238 RVA: 0x003ED060 File Offset: 0x003EB260
		public int getSupport(int id)
		{
			IMonsterItem monsterItem;
			if (this.MonsterMap.TryGetValue(id, out monsterItem) && monsterItem.Support > 0)
			{
				return monsterItem.Support;
			}
			return id;
		}

		// Token: 0x0400EECE RID: 61134
		public Dictionary<int, IMonsterItem> MonsterMap;

		// Token: 0x0400EECF RID: 61135
		private List<int> CombinationBonusPetIds = new List<int>
		{
			2132,
			2163,
			2190
		};
	}
}
