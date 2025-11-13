using System;

namespace core.model
{
	// Token: 0x02001982 RID: 6530
	public class TeamPKInfo
	{
		// Token: 0x0600CCD9 RID: 52441 RVA: 0x003B6654 File Offset: 0x003B4854
		public TeamPKInfo(ByteArray data)
		{
			this.m_groupID = (int)data.ReadUnsignedInt();
			this.m_homeTeamID = (int)data.ReadUnsignedInt();
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x0600CCDA RID: 52442 RVA: 0x003B6674 File Offset: 0x003B4874
		public int groupID
		{
			get
			{
				return this.m_groupID;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x0600CCDB RID: 52443 RVA: 0x003B667C File Offset: 0x003B487C
		// (set) Token: 0x0600CCDC RID: 52444 RVA: 0x003B6684 File Offset: 0x003B4884
		public int homeTeamID
		{
			get
			{
				return this.m_homeTeamID;
			}
			set
			{
				this.m_homeTeamID = value;
			}
		}

		// Token: 0x0400E34F RID: 58191
		private int m_groupID;

		// Token: 0x0400E350 RID: 58192
		private int m_homeTeamID;
	}
}
