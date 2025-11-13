using System;
using System.Collections.Generic;
using common;
using core.config.move_change;


namespace core.config
{
	// Token: 0x02001EBD RID: 7869
	public class SkillNameReplaceXmlInfo : ConfigManagerSingleton<SkillNameReplaceXmlInfo>
	{
		// Token: 0x0600EB66 RID: 60262 RVA: 0x003ED57D File Offset: 0x003EB77D
		

		// Token: 0x0600EB67 RID: 60263 RVA: 0x003ED58A File Offset: 0x003EB78A
		

		// Token: 0x0600EB68 RID: 60264 RVA: 0x003ED598 File Offset: 0x003EB798
		

		// Token: 0x0600EB69 RID: 60265 RVA: 0x003ED5DC File Offset: 0x003EB7DC
		public string getSkillNameBySkinId(int skinId, int skillId)
		{
			string result = "";
			List<SkillNameReplaceXmlInfo.xmlSkillInfo> list;
			if (this.replaceInfos.TryGetValue(skinId, out list) && list != null)
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					if (list[i].id == skillId)
					{
						result = list[i].sName;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x0600EB6A RID: 60266 RVA: 0x003ED634 File Offset: 0x003EB834
		public SkillNameReplaceXmlInfo.xmlSkillInfo getSkillInfo(int skillId, int skinId)
		{
			List<SkillNameReplaceXmlInfo.xmlSkillInfo> list;
			if (this.replaceInfos.TryGetValue(skinId, out list))
			{
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					if (list[i].id == skillId)
					{
						return list[i];
					}
				}
			}
			return null;
		}

		// Token: 0x0400EEE0 RID: 61152
		private Dictionary<int, List<SkillNameReplaceXmlInfo.xmlSkillInfo>> replaceInfos;

		// Token: 0x02004C46 RID: 19526
		public class xmlSkillInfo
		{
			// Token: 0x0401AD9C RID: 109980
			public int id;

			// Token: 0x0401AD9D RID: 109981
			public string sName;

			// Token: 0x0401AD9E RID: 109982
			public string moveName1;

			// Token: 0x0401AD9F RID: 109983
			public string moveName2;
		}
	}
}
