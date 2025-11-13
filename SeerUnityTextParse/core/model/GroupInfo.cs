using System;
using System.Collections.Generic;


namespace core.model
{
	// Token: 0x0200193B RID: 6459
	public class GroupInfo
	{
		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x0600CB93 RID: 52115 RVA: 0x003B21F7 File Offset: 0x003B03F7
		// (set) Token: 0x0600CB94 RID: 52116 RVA: 0x003B21FF File Offset: 0x003B03FF
		public GroupIDInfo groupIDInfo
		{
			get
			{
				return this.m_groupIDInfo;
			}
			set
			{
				this.m_groupIDInfo = value;
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x0600CB95 RID: 52117 RVA: 0x003B2208 File Offset: 0x003B0408
		// (set) Token: 0x0600CB96 RID: 52118 RVA: 0x003B2210 File Offset: 0x003B0410
		public int leaderID
		{
			get
			{
				return this.m_leaderID;
			}
			set
			{
				this.m_leaderID = value;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x0600CB97 RID: 52119 RVA: 0x003B2219 File Offset: 0x003B0419
		// (set) Token: 0x0600CB98 RID: 52120 RVA: 0x003B2221 File Offset: 0x003B0421
		public List<int> memberList
		{
			get
			{
				return this.m_memberList;
			}
			set
			{
				this.m_memberList = value;
			}
		}

		// Token: 0x0400E011 RID: 57361
		private GroupIDInfo m_groupIDInfo;

		// Token: 0x0400E012 RID: 57362
		private int m_leaderID;

		// Token: 0x0400E013 RID: 57363
		private List<int> m_memberList = new List<int>();

		// Token: 0x0400E014 RID: 57364
		//public Vector2 sctPoint;

		// Token: 0x0400E015 RID: 57365
		public bool isLeader;

		// Token: 0x0400E016 RID: 57366
		public string groupName = string.Empty;

		// Token: 0x0400E017 RID: 57367
		public int sctID;

		// Token: 0x0400E018 RID: 57368
		public int pointID;
	}
}
