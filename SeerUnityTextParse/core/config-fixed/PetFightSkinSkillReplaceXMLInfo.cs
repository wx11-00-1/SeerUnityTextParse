using System;
using System.Collections.Generic;
using common;
using core.config.PetFightSkinSkillReplace;


namespace core.config
{
	// Token: 0x02001EB4 RID: 7860
	public class PetFightSkinSkillReplaceXMLInfo : ConfigManagerSingleton<PetFightSkinSkillReplaceXMLInfo>
	{
		// Token: 0x0600EAF7 RID: 60151 RVA: 0x003EB8AE File Offset: 0x003E9AAE
		

		// Token: 0x0600EAF8 RID: 60152 RVA: 0x003EB8C0 File Offset: 0x003E9AC0
		

		// Token: 0x0600EAF9 RID: 60153 RVA: 0x003EB8D0 File Offset: 0x003E9AD0
		

		// Token: 0x0600EAFA RID: 60154 RVA: 0x003EB914 File Offset: 0x003E9B14
		private ISkill getSkillItem(int skinId, int skillId, int petId)
		{
			if (skinId > 0)
			{
				if (skinId < this.SKIN_PRE_FIX)
				{
					petId = this.SKIN_PRE_FIX + skinId;
				}
				else
				{
					petId = skinId;
				}
			}
			IItemItem itemItem;
			if (this.s_PetSkills.TryGetValue(petId, out itemItem) && skillId == itemItem.skill.id)
			{
				return itemItem.skill;
			}
			return null;
		}

		// Token: 0x0600EAFB RID: 60155 RVA: 0x003EB964 File Offset: 0x003E9B64
		public int getReplaceSkill(int skinId, int skillId, int petId = 0)
		{
			ISkill skillItem = this.getSkillItem(skinId, skillId, petId);
			if (skillItem != null)
			{
				skillId = skillItem.replaceId;
			}
			return skillId;
		}

		// Token: 0x0600EAFC RID: 60156 RVA: 0x003EB988 File Offset: 0x003E9B88
		public string getReplaceAction(int skinId, int skillId, int petId = 0)
		{
			string result = string.Empty;
			ISkill skillItem = this.getSkillItem(skinId, skillId, petId);
			if (skillItem != null)
			{
				result = skillItem.action;
			}
			return result;
		}

		// Token: 0x0600EAFD RID: 60157 RVA: 0x003EB9B0 File Offset: 0x003E9BB0
		public ISkill[] getSkills(int skinId, int petId)
		{
			if (skinId > 0)
			{
				if (skinId < this.SKIN_PRE_FIX)
				{
					petId = this.SKIN_PRE_FIX + skinId;
				}
				else
				{
					petId = skinId;
				}
			}
			IItemItem itemItem;
			if (this.s_PetSkills.TryGetValue(petId, out itemItem))
			{
				return new ISkill[]
				{
					itemItem.skill
				};
			}
			return null;
		}

		// Token: 0x0400EEC4 RID: 61124
		private readonly int SKIN_PRE_FIX = 1400000;

		// Token: 0x0400EEC5 RID: 61125
		private Dictionary<int, IItemItem> s_PetSkills;
	}
}
