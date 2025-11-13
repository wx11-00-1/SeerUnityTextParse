using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x02001969 RID: 6505
	public class PetUpdateSkillInfo
	{
		// Token: 0x0600CC58 RID: 52312 RVA: 0x003B5748 File Offset: 0x003B3948
		public PetUpdateSkillInfo(ByteArray data)
		{
			int num = (int)data.ReadUnsignedInt();
			for (int i = 0; i < num; i++)
			{
				this.m_InfoArray.Add(new UpdateSkillInfo(data));
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x0600CC59 RID: 52313 RVA: 0x003B578A File Offset: 0x003B398A
		public List<UpdateSkillInfo> infoArray
		{
			get
			{
				return this.m_InfoArray;
			}
		}

		// Token: 0x0400E2AF RID: 58031
		private List<UpdateSkillInfo> m_InfoArray = new List<UpdateSkillInfo>();
	}
}
