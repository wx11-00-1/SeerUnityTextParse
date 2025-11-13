using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using common;
//using core.eventConst;
using core.manager;

namespace core.model
{
	// Token: 0x02001967 RID: 6503
	public class PetUpdatePropController
	{
		// Token: 0x0600CC4B RID: 52299 RVA: 0x003B5494 File Offset: 0x003B3694
		public PetUpdatePropController()
		{
			PetUpdatePropController.owner = this;
			//EventManager<string>.addEventListener(PetFightEvent.PET_UPDATE_PROP, new Action(this.onFightClose), PetUpdatePropController.owner.GetHashCode());
			//EventManager<string>.addEventListener("ReconnectSuccess", new Action(this.onReconnect), PetUpdatePropController.owner.GetHashCode());
		}

		// Token: 0x0600CC4C RID: 52300 RVA: 0x003B54F8 File Offset: 0x003B36F8
		public void setup(PetUpdatePropInfo data)
		{
			//PetUpdatePropController.addition = data.addition;
			//PetUpdatePropController.addPer = data.addPer;
			//PetUpdatePropController.eggAddition = data.eggAddition;
			//this.m_InfoArray = data.dataArray;
			//foreach (UpdatePropInfo updatePropInfo in this.m_InfoArray)
			//{
			//	if (updatePropInfo.level > ResetableSingleTon<MainManager>.Ins.actorInfo.petMaxLev)
			//	{
			//		ResetableSingleTon<MainManager>.Ins.actorInfo.petMaxLev = updatePropInfo.level;
			//	}
			//}
		}

		// Token: 0x0600CC4D RID: 52301 RVA: 0x003B55A0 File Offset: 0x003B37A0
		private void onFightClose()
		{
			//PetUpdatePropController.<onFightClose>d__10 <onFightClose>d__;
			//<onFightClose>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<onFightClose>d__.<>4__this = this;
			//<onFightClose>d__.<>1__state = -1;
			//<onFightClose>d__.<>t__builder.Start<PetUpdatePropController.<onFightClose>d__10>(ref <onFightClose>d__);
		}

		// Token: 0x0600CC4E RID: 52302 RVA: 0x003B55D8 File Offset: 0x003B37D8
		public void show(bool showByLevelPanel = false)
		{
			//if (showByLevelPanel)
			//{
			//	return;
			//}
			//if (PetUpdatePropController.m_virtualFightVirtualResultType.IndexOf((int)PetFightModel.type) > -1)
			//{
			//	ResetableSingleTon<ModuleManager>.Ins.showModule(260, PetUpdatePropController.USE_FIGHT_DATA, AppDoStyle.HIDEN, null);
			//	return;
			//}
			//ResetableSingleTon<ModuleManager>.Ins.showModule(260, this.m_InfoArray, AppDoStyle.HIDEN, null);
		}

		// Token: 0x0600CC4F RID: 52303 RVA: 0x003B5629 File Offset: 0x003B3829
		private void onReconnect()
		{
			if (PetUpdatePropController.isMarkReconnect)
			{
				PetUpdatePropController.isMarkReconnect = false;
				this.onFightClose();
			}
		}

		// Token: 0x0400E2A5 RID: 58021
		public static PetUpdatePropController owner;

		// Token: 0x0400E2A6 RID: 58022
		public static double addition;

		// Token: 0x0400E2A7 RID: 58023
		public static int addPer;

		// Token: 0x0400E2A8 RID: 58024
		public static int eggAddition;

		// Token: 0x0400E2A9 RID: 58025
		public static string USE_FIGHT_DATA = "USE_FIGHT_DATA";

		// Token: 0x0400E2AA RID: 58026
		private static List<int> m_virtualFightVirtualResultType = new List<int>
		{
			103,
			104,
			105
		};

		// Token: 0x0400E2AB RID: 58027
		private List<UpdatePropInfo> m_InfoArray = new List<UpdatePropInfo>();

		// Token: 0x0400E2AC RID: 58028
		private static bool isMarkReconnect;
	}
}
