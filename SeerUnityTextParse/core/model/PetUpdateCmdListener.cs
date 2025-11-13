using System;
using System.Collections.Generic;
using common;
//using core.component;
//using core.manager;
//using core.view;
//using module.petNewSkillPanel;
//using socket;
//using tipsPop;

namespace core.model
{
	// Token: 0x02001966 RID: 6502
	public class PetUpdateCmdListener
	{
		// Token: 0x0600CC42 RID: 52290 RVA: 0x003B526C File Offset: 0x003B346C
		public static void start()
		{
			if (PetUpdateCmdListener.started)
			{
				return;
			}
			PetUpdateCmdListener.started = true;
			PetUpdateCmdListener.petUpdatePropCon = new PetUpdatePropController();
			PetUpdateCmdListener.petUpdataeSkillCon = new PetUpdateSkillController();
			//SocketConnection.addCmdListener(CommandID.NOTE_UPDATE_PROP, new Action<SocketEvent>(PetUpdateCmdListener.onUpdateProp));
			//SocketConnection.addCmdListener(CommandID.NOTE_UPDATE_SKILL, new Action<SocketEvent>(PetUpdateCmdListener.onUpdateSkill));
			//SocketConnection.addCmdListener(41821, new Action<SocketEvent>(PetUpdateCmdListener.onUpdateExtraSkill));
			//SocketConnection.addCmdListener(CommandID.FOLLOW_PET_SHOW, new Action<SocketEvent>(PetUpdateCmdListener.onFollowPetShow));
			//SocketConnection.addCmdListener(CommandID.PET_ROOM_INFO, new Action<SocketEvent>(PetUpdateCmdListener.onPetRoomInfo));
		}



		// Token: 0x0600CC48 RID: 52296 RVA: 0x003B5473 File Offset: 0x003B3673
		public static void PauseSkillPop()
		{
			PetUpdateCmdListener.petUpdataeSkillCon.pauseShow();
		}

		// Token: 0x0600CC49 RID: 52297 RVA: 0x003B547F File Offset: 0x003B367F
		public static void ResumeSkillPop()
		{
			PetUpdateCmdListener.petUpdataeSkillCon.resumeShow();
		}

		// Token: 0x0400E2A1 RID: 58017
		public static bool IN_EXP_PANEL;

		// Token: 0x0400E2A2 RID: 58018
		private static PetUpdatePropController petUpdatePropCon;

		// Token: 0x0400E2A3 RID: 58019
		private static PetUpdateSkillController petUpdataeSkillCon;

		// Token: 0x0400E2A4 RID: 58020
		private static bool started;
	}
}
