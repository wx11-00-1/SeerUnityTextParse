using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x02001937 RID: 6455
	public class AnswerJoinGpInfo
	{
		// Token: 0x0600CB81 RID: 52097 RVA: 0x003B2040 File Offset: 0x003B0240
		public AnswerJoinGpInfo(ByteArray data = null)
		{
			this.m_GroupIDInfo = new GroupIDInfo(data);
			this.m_GroupName = data.ReadUTFByte(16);
			this.m_LeaderID = (int)data.ReadUnsignedInt();
			int num = (int)data.ReadUnsignedByte();
			for (int i = 0; i < num; i++)
			{
				int item = (int)data.ReadUnsignedInt();
				this.m_MembList.Add(item);
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x0600CB82 RID: 52098 RVA: 0x003B20AA File Offset: 0x003B02AA
		public GroupIDInfo groupIDInfo
		{
			get
			{
				return this.m_GroupIDInfo;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x0600CB83 RID: 52099 RVA: 0x003B20B2 File Offset: 0x003B02B2
		public int leaderID
		{
			get
			{
				return this.m_LeaderID;
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x0600CB84 RID: 52100 RVA: 0x003B20BA File Offset: 0x003B02BA
		public string groupName
		{
			get
			{
				return this.m_GroupName;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x0600CB85 RID: 52101 RVA: 0x003B20C2 File Offset: 0x003B02C2
		public List<int> membList
		{
			get
			{
				return this.m_MembList;
			}
		}

		// Token: 0x0400E001 RID: 57345
		private GroupIDInfo m_GroupIDInfo;

		// Token: 0x0400E002 RID: 57346
		private int m_LeaderID;

		// Token: 0x0400E003 RID: 57347
		private string m_GroupName;

		// Token: 0x0400E004 RID: 57348
		private List<int> m_MembList = new List<int>();
	}
}
