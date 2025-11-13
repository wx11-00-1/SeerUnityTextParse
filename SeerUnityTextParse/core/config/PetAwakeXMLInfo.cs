using System;
using System.Collections.Generic;
using System.Linq;
using common;
using core.config.awakendetail;
using core.manager;


namespace core.config
{
	// Token: 0x02001E99 RID: 7833
	public class PetAwakeXMLInfo : ConfigManagerSingleton<PetAwakeXMLInfo>
	{
		// Token: 0x0600E956 RID: 59734 RVA: 0x003E47C4 File Offset: 0x003E29C4
		

		// Token: 0x0600E957 RID: 59735 RVA: 0x003E47E7 File Offset: 0x003E29E7
		

		// Token: 0x0600E958 RID: 59736 RVA: 0x003E47F8 File Offset: 0x003E29F8
		

		// Token: 0x0600E959 RID: 59737 RVA: 0x003E483C File Offset: 0x003E2A3C
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

		// Token: 0x0600E95A RID: 59738 RVA: 0x003E4876 File Offset: 0x003E2A76
		public bool getIncludeAdvance(int pid)
		{
			return this.s_PetArr.Contains(pid);
		}

		// Token: 0x0600E95B RID: 59739 RVA: 0x003E4884 File Offset: 0x003E2A84
		public int getAdvanceEffectId(int pid)
		{
			if (this.getIncludeAdvance(pid))
			{
				return this.s_PetAdvanceInfos[pid].AdvEffect.Id;
			}
			return 0;
		}

		// Token: 0x0600E95C RID: 59740 RVA: 0x003E48A7 File Offset: 0x003E2AA7
		public int getOldEffectId(int pid)
		{
			if (this.s_TaskInfoDic.ContainsKey(pid))
			{
				return this.s_TaskInfoDic[pid].OldEffID;
			}
			return 0;
		}

		// Token: 0x0600E95D RID: 59741 RVA: 0x003E48CA File Offset: 0x003E2ACA
		public int getNewEffectId(int pid)
		{
			if (this.s_TaskInfoDic.ContainsKey(pid))
			{
				return this.s_TaskInfoDic[pid].NewEffID;
			}
			return 0;
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x003E48F0 File Offset: 0x003E2AF0
		public int[] getAdvanceRace(int pid)
		{
			if (this.getIncludeAdvance(pid))
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

		// Token: 0x0600E95F RID: 59743 RVA: 0x003E4944 File Offset: 0x003E2B44
		public ITaskItem GetTaskInfoByPetID(int petId)
		{
			return this.s_TaskInfo.FirstOrDefault((ITaskItem x) => x.Advances.MonsterId == petId);
		}

		// Token: 0x0600E960 RID: 59744 RVA: 0x003E4978 File Offset: 0x003E2B78
		public int[] getOldRace(int pid)
		{
			if (this.getIncludeAdvance(pid))
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

		// Token: 0x0600E961 RID: 59745 RVA: 0x003E49CC File Offset: 0x003E2BCC
		public int[] getAdvanceSkill(int pid)
		{
			if (!this.getIncludeAdvance(pid))
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

		// Token: 0x0600E962 RID: 59746 RVA: 0x003E4A28 File Offset: 0x003E2C28
		public int[] getAdvanceFifthSkill(int pid)
		{
			if (!this.getIncludeAdvance(pid))
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

		// Token: 0x0600E964 RID: 59748 RVA: 0x003E4B18 File Offset: 0x003E2D18
		public int getAdvType(int petId)
		{
			IAdvances advances;
			if (!this.s_PetAdvanceInfos.TryGetValue(petId, out advances))
			{
				return -1;
			}
			return 2;
		}

		// Token: 0x0600E965 RID: 59749 RVA: 0x003E4B38 File Offset: 0x003E2D38
		public string getAdvSignSource(int petId)
		{
			IAdvances advances;
			if (petId <= 0 || !this.s_PetAdvanceInfos.TryGetValue(petId, out advances))
			{
				return ClientConfig.getCommonIcon("common_pet_basic_icon", "");
			}
			if (advances.AdvType == 1)
			{
				return ClientConfig.getCommonIcon("common_pet_juexin_icon", "");
			}
			return ClientConfig.getCommonIcon("common_pet_shenyu_icon", "");
		}

		// Token: 0x0400ED1C RID: 60700
		private ITaskItem[] s_TaskInfo;

		// Token: 0x0400ED1D RID: 60701
		private List<int> s_PetArr = new List<int>();

		// Token: 0x0400ED1E RID: 60702
		private Dictionary<int, IAdvances> s_PetAdvanceInfos = new Dictionary<int, IAdvances>();

		// Token: 0x0400ED1F RID: 60703
		private Dictionary<int, ITaskItem> s_TaskInfoDic = new Dictionary<int, ITaskItem>();
	}
}
