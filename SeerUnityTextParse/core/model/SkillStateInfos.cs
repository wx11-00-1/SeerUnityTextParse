using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x02001976 RID: 6518
	public class SkillStateInfos
	{
		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x0600CC7E RID: 52350 RVA: 0x003B5C36 File Offset: 0x003B3E36
		// (set) Token: 0x0600CC7F RID: 52351 RVA: 0x003B5C3E File Offset: 0x003B3E3E
		public int runawayMoveNum
		{
			get
			{
				return this.m_runawayMoveNum;
			}
			set
			{
				this.m_runawayMoveNum = value;
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x0600CC80 RID: 52352 RVA: 0x003B5C47 File Offset: 0x003B3E47
		// (set) Token: 0x0600CC81 RID: 52353 RVA: 0x003B5C4F File Offset: 0x003B3E4F
		public List<int> skillRunawayMarks
		{
			get
			{
				return this.m_skillRunawayMarks;
			}
			set
			{
				this.m_skillRunawayMarks = value;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x0600CC82 RID: 52354 RVA: 0x003B5C58 File Offset: 0x003B3E58
		// (set) Token: 0x0600CC83 RID: 52355 RVA: 0x003B5C60 File Offset: 0x003B3E60
		public int lockedSkillId
		{
			get
			{
				return this.m_lockedSkillId;
			}
			set
			{
				this.m_lockedSkillId = value;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x0600CC84 RID: 52356 RVA: 0x003B5C69 File Offset: 0x003B3E69
		// (set) Token: 0x0600CC85 RID: 52357 RVA: 0x003B5C71 File Offset: 0x003B3E71
		public List<int> lockedSkillArr
		{
			get
			{
				return this.m_lockedSkillArr;
			}
			set
			{
				this.m_lockedSkillArr = value;
			}
		}

		// Token: 0x0400E2E5 RID: 58085
		private int m_runawayMoveNum;

		// Token: 0x0400E2E6 RID: 58086
		private List<int> m_skillRunawayMarks = new List<int>();

		// Token: 0x0400E2E7 RID: 58087
		private int m_lockedSkillId;

		// Token: 0x0400E2E8 RID: 58088
		private List<int> m_lockedSkillArr = new List<int>();
	}
}
