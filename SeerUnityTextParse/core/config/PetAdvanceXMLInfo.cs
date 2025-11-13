using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.pet_advance;
using core.manager;


namespace core.config
{
	// Token: 0x02001EB1 RID: 7857
	public class PetAdvanceXMLInfo : ConfigManagerSingleton<PetAdvanceXMLInfo>
	{
		// Token: 0x0600EAC6 RID: 60102 RVA: 0x003EABC4 File Offset: 0x003E8DC4
		

		// Token: 0x0600EAC7 RID: 60103 RVA: 0x003EABE1 File Offset: 0x003E8DE1
		

		// Token: 0x0600EAC8 RID: 60104 RVA: 0x003EABF0 File Offset: 0x003E8DF0
		

		// Token: 0x0600EAC9 RID: 60105 RVA: 0x003EAC33 File Offset: 0x003E8E33
		public IBackItem getBackInfo(int taskId)
		{
			return this._backAdvInfos[taskId];
		}

		// Token: 0x0600EACA RID: 60106 RVA: 0x003EAC44 File Offset: 0x003E8E44
		public IBackItem[] getAllBackInfo()
		{
			if (ResetableSingleTon<PetAdvanceXMLInfo>.Ins.curBackInfos == null)
			{
				ResetableSingleTon<PetAdvanceXMLInfo>.Ins.curBackInfos = (from x in this._backAdvInfos.Values
				where x.IsBack > 0
				select x).OrderBy(delegate(IBackItem a)
				{
					int result;
					if (int.TryParse(a.desc.Split("|", StringSplitOptions.None)[0], out result))
					{
						return result;
					}
					return 0;
				}).ToArray<IBackItem>();
			}
			return this.curBackInfos;
		}

		// Token: 0x0600EACB RID: 60107 RVA: 0x003EACC5 File Offset: 0x003E8EC5
		public bool checkIsBackAdv(int petId)
		{
			return (from x in this._backAdvInfos.Values
			select x.MonsterId).Contains(petId);
		}

		// Token: 0x0600EACC RID: 60108 RVA: 0x003EACFC File Offset: 0x003E8EFC
		public ITaskItem getTaskInfo(int taskId)
		{
			for (int i = 0; i < this.s_TaskInfo.Length; i++)
			{
				if (taskId == this.s_TaskInfo[i].ID)
				{
					return this.s_TaskInfo[i];
				}
			}
			return null;
		}

		// Token: 0x0600EACD RID: 60109 RVA: 0x003EAD36 File Offset: 0x003E8F36
		public bool getIncludeAdvance(int pid)
		{
			return this.s_PetArr.Contains(pid) || ResetableSingleTon<PetAwakeXMLInfo>.Ins.getIncludeAdvance(pid);
		}

		// Token: 0x0600EACE RID: 60110 RVA: 0x003EAD54 File Offset: 0x003E8F54
		public int[] getAdvanceRace(int pid)
		{
			if (ResetableSingleTon<PetAwakeXMLInfo>.Ins.getIncludeAdvance(pid))
			{
				return ResetableSingleTon<PetAwakeXMLInfo>.Ins.getAdvanceRace(pid);
			}
			if (this.s_PetArr.Contains(pid))
			{
				int[] newRace = this.s_PetAdvanceInfos[pid].Race.NewRace;
				int[] array = new int[newRace.Length];
				for (int i = 0; i < newRace.Length; i++)
				{
					array[i] = newRace[i];
				}
				return array;
			}
			return new int[0];
		}

		// Token: 0x0600EACF RID: 60111 RVA: 0x003EADC4 File Offset: 0x003E8FC4
		public ITaskItem GetTaskInfoByPetID(int petId)
		{
			return this.s_TaskInfo.FirstOrDefault((ITaskItem x) => x.Advances.MonsterId == petId);
		}

		// Token: 0x0600EAD0 RID: 60112 RVA: 0x003EADF8 File Offset: 0x003E8FF8
		public int[] getOldRace(int pid)
		{
			if (ResetableSingleTon<PetAwakeXMLInfo>.Ins.getIncludeAdvance(pid))
			{
				return ResetableSingleTon<PetAwakeXMLInfo>.Ins.getOldRace(pid);
			}
			if (this.s_PetArr.Contains(pid))
			{
				int[] oldRace = this.s_PetAdvanceInfos[pid].Race.OldRace;
				int[] array = new int[oldRace.Length];
				for (int i = 0; i < oldRace.Length; i++)
				{
					array[i] = oldRace[i];
				}
				return array;
			}
			return new int[0];
		}

		// Token: 0x0600EAD1 RID: 60113 RVA: 0x003EAE68 File Offset: 0x003E9068
		public int[] getAdvanceSkill(int pid)
		{
			if (ResetableSingleTon<PetAwakeXMLInfo>.Ins.getIncludeAdvance(pid))
			{
				return ResetableSingleTon<PetAwakeXMLInfo>.Ins.getAdvanceSkill(pid);
			}
			if (!this.s_PetArr.Contains(pid))
			{
				return new int[0];
			}
			int[] spMoves = this.s_PetAdvanceInfos[pid].spMove.SpMoves;
			if (spMoves == null)
			{
				return new int[0];
			}
			int[] array = new int[spMoves.Length];
			for (int i = 0; i < spMoves.Length; i++)
			{
				array[i] = spMoves[i];
			}
			return array;
		}

		// Token: 0x0600EAD2 RID: 60114 RVA: 0x003EAEE4 File Offset: 0x003E90E4
		public int[] getAdvanceFifthSkill(int pid)
		{
			if (ResetableSingleTon<PetAwakeXMLInfo>.Ins.getIncludeAdvance(pid))
			{
				return ResetableSingleTon<PetAwakeXMLInfo>.Ins.getAdvanceFifthSkill(pid);
			}
			if (!this.s_PetArr.Contains(pid))
			{
				return new int[0];
			}
			int extraMoves = this.s_PetAdvanceInfos[pid].exMove.ExtraMoves;
			if (extraMoves == 0)
			{
				return new int[0];
			}
			string[] array = extraMoves.ToString().Split(" ", StringSplitOptions.None);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = Convert.ToInt32(array[i]);
			}
			return array2;
		}

		// Token: 0x0600EAD3 RID: 60115 RVA: 0x003EAF78 File Offset: 0x003E9178
		public int getAdvanceEffectId(int pid)
		{
			if (ResetableSingleTon<PetAwakeXMLInfo>.Ins.getIncludeAdvance(pid))
			{
				return ResetableSingleTon<PetAwakeXMLInfo>.Ins.getAdvanceEffectId(pid);
			}
			if (this.s_PetArr.Contains(pid))
			{
				return this.s_PetAdvanceInfos[pid].AdvEffect.Id;
			}
			return 0;
		}

		// Token: 0x0600EAD5 RID: 60117 RVA: 0x003EB040 File Offset: 0x003E9240
		public int getAdvType(int petId)
		{
			int advType = ResetableSingleTon<PetAwakeXMLInfo>.Ins.getAdvType(petId);
			if (advType != -1)
			{
				return advType;
			}
			IAdvances advances;
			if (!this.s_PetAdvanceInfos.TryGetValue(petId, out advances))
			{
				return -1;
			}
			return advances.AdvType;
		}

		// Token: 0x0600EAD6 RID: 60118 RVA: 0x003EB078 File Offset: 0x003E9278
		public string getAdvTypeName(int petId)
		{
			int num = ResetableSingleTon<PetAwakeXMLInfo>.Ins.getAdvType(petId);
			if (num != -1)
			{
				return "觉醒";
			}
			IAdvances advances;
			num = (this.s_PetAdvanceInfos.TryGetValue(petId, out advances) ? advances.AdvType : -1);
			if (num == 0)
			{
				return "觉醒";
			}
			if (num == 1)
			{
				return "觉醒";
			}
			return "";
		}

		// Token: 0x0600EAD7 RID: 60119 RVA: 0x003EB0D0 File Offset: 0x003E92D0
		public string getAdvSignSource(int petId)
		{
			if (petId <= 0)
			{
				return ClientConfig.getCommonIcon("common_pet_basic_icon", "");
			}
			switch (this.getAdvType(petId))
			{
			case 0:
				return ClientConfig.getCommonIcon("common_pet_shenyu_icon", "");
			case 1:
				return ClientConfig.getCommonIcon("common_pet_juexin_icon", "");
			case 2:
				return ClientConfig.getCommonIcon("common_pet_juexin_icon", "");
			default:
				return ClientConfig.getCommonIcon("common_pet_basic_icon", "");
			}
		}

		// Token: 0x0400EEB2 RID: 61106
		private ITaskItem[] s_TaskInfo;

		// Token: 0x0400EEB3 RID: 61107
		private List<int> s_PetArr;

		// Token: 0x0400EEB4 RID: 61108
		private Dictionary<int, IAdvances> s_PetAdvanceInfos;

		// Token: 0x0400EEB5 RID: 61109
		private Dictionary<int, IBackItem> _backAdvInfos = new Dictionary<int, IBackItem>();

		// Token: 0x0400EEB6 RID: 61110
		public int backRefreshFree;

		// Token: 0x0400EEB7 RID: 61111
		public int backRefCost;

		// Token: 0x0400EEB8 RID: 61112
		public int backRefAddCost;

		// Token: 0x0400EEB9 RID: 61113
		public int backRefMaxCost;

		// Token: 0x0400EEBA RID: 61114
		public IBackItem[] curBackInfos;
	}
}
